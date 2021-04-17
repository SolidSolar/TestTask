using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject playerTank;
    public Transform[] SpawnPoints;
    [SerializeField]
    private List<AssetReference> monsterPrefabList;
    private readonly Dictionary<AssetReference, List<GameObject>> spawnedMonsters =
        new Dictionary<AssetReference, List<GameObject>>();
    private readonly Dictionary<AssetReference, AsyncOperationHandle<GameObject>> _asyncHandles =
        new Dictionary<AssetReference, AsyncOperationHandle<GameObject>>();
    private readonly Dictionary<AssetReference, Queue<int>> _queuedSpawns =
        new Dictionary<AssetReference, Queue<int>>();

    float _lastSpawnTime;
    public float SpawnInterval;
    private void Start()
    {
        _lastSpawnTime = Time.time;
    }
    public void Update()
    {
        if (Time.time - _lastSpawnTime >= SpawnInterval && spawnedMonsters.Sum(x => x.Value.Count) <10)
        {
            SpawnMonster(Random.Range(0, monsterPrefabList.Count));
            _lastSpawnTime = Time.time;
        }
    }

    public void SpawnMonster(int index)
    {
        if (index < 0 || index >= monsterPrefabList.Count)
            return;
        AssetReference reference = monsterPrefabList[index];
        if (_asyncHandles.ContainsKey(reference))
        {
            if (_asyncHandles[reference].IsDone)
            {
                _spawnMonster(reference, index);
            }
            else
            {
                EnqueueSpawn(reference, index);
            }
        }
        else
        {
            LoadMonsterReference(reference, index);
        }
    }

    void LoadMonsterReference(AssetReference reference, int index)
    {
        var op = Addressables.LoadAssetAsync<GameObject>(reference);
        _asyncHandles[reference] = op;
        op.Completed += (operation) =>
        {
            _spawnMonster(reference, index);

            if (_queuedSpawns.ContainsKey(reference))
            {
                while (_queuedSpawns[reference]?.Any() == true)
                {
                    int i = _queuedSpawns[reference].Dequeue();
                    _spawnMonster(reference, i);
                }
            }
        };

    }

    void _spawnMonster(AssetReference reference, int index)
    {
        reference.InstantiateAsync(SpawnPoints[Random.Range(0, SpawnPoints.Length)]).Completed += (asyncHandle) =>
        {
            if (!spawnedMonsters.ContainsKey(reference))
            {
                spawnedMonsters.Add(reference, new List<GameObject>());
            }
            spawnedMonsters[reference].Add (asyncHandle.Result);
            var notification = asyncHandle.Result.AddComponent<NotifyOnDestroy>();
            notification.assetReference = reference;
            notification.destroyed += ReleaseAssetReference;
            asyncHandle.Result.GetComponent<MonsterAIController>().target = playerTank;
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
        spawnedMonsters[reference].Remove(notification.gameObject);
        if (spawnedMonsters[reference].Count == 0)
        {
            if (_asyncHandles[reference].IsValid())
                Addressables.Release(_asyncHandles[reference]);
            _asyncHandles.Remove(reference);
        }
    }
}
