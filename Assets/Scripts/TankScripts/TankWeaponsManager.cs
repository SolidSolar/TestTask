using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class TankWeaponsManager : MonoBehaviour
{
    public Transform TowerParentTransform;
    [SerializeField]
    private List<AssetReference> weaponPrefabList;
    private TankWeapon currentWeapon;
    private readonly Dictionary<AssetReference, AsyncOperationHandle<GameObject>> _asyncHandles =
        new Dictionary<AssetReference, AsyncOperationHandle<GameObject>>();
    private readonly Dictionary<AssetReference, Queue<int>> _queuedSpawns= 
        new Dictionary<AssetReference, Queue<int>>();


    public TankWeapon GetCurrentWeapon()
    {
        return currentWeapon;
    }

    public void ChangeWeapon(int index)
    {
        if (index < 0 || index >= weaponPrefabList.Count)
            return;
        AssetReference reference = weaponPrefabList[index];
        if (_asyncHandles.ContainsKey(reference))  
        {
            if (_asyncHandles[reference].IsDone)
            {
                SpawnWeapon(reference, index);
            }
            else
            {
                EnqueueSpawn(reference, index);
            }
        }
        else {
            LoadWeaponReference(reference, index);
        } 
    }

    void LoadWeaponReference(AssetReference reference, int index)
    {
        var op = Addressables.LoadAssetAsync<GameObject>(reference);
        _asyncHandles[reference] = op;
        op.Completed += (operation) =>
        {
            SpawnWeapon(reference, index);
            
            if (_queuedSpawns.ContainsKey(reference))
            {
                while (_queuedSpawns[reference]?.Any() == true)
                {
                    int i = _queuedSpawns[reference].Dequeue();
                    SpawnWeapon(reference, i);
                }
            }
        };

    }

    void SpawnWeapon(AssetReference reference, int index)
    {
        if (currentWeapon)
            Destroy(currentWeapon.gameObject);
        reference.InstantiateAsync(TowerParentTransform).Completed += (asyncHandle) =>
        {
            currentWeapon = asyncHandle.Result.GetComponent<TankWeapon>();
            var notification = asyncHandle.Result.AddComponent<NotifyOnDestroy>();
            notification.assetReference = reference;
            notification.destroyed += ReleaseAssetReference;
        };
    }

    void EnqueueSpawn(AssetReference reference, int index)
    {
        if (!_queuedSpawns.ContainsKey(reference))
        {
            _queuedSpawns[reference] = new Queue<int>();
            _queuedSpawns[reference].Enqueue(index);
        }
    }

    void ReleaseAssetReference(AssetReference reference, NotifyOnDestroy notification)
    {
        reference.ReleaseInstance(notification.gameObject);
        if(_asyncHandles[reference].IsValid())
        Addressables.Release(_asyncHandles[reference]);
        _asyncHandles.Remove(reference);
    }
}
