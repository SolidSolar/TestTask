using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

//Callback Script for Adressables
public class NotifyOnDestroy : MonoBehaviour
{
    public event Action<AssetReference, NotifyOnDestroy> destroyed;
    public AssetReference assetReference;
    private void OnDestroy()
    {
        destroyed?.Invoke(assetReference, this);
    }
}
