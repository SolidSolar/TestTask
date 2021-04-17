using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public TankWeapon weaponData;

    public void Start()
    {
        Destroy(gameObject, weaponData.LifeTime);
        GetComponent<Rigidbody>().velocity = weaponData.spawnPoint.transform.forward * weaponData.ProjectileSpeed;
    }
    public void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
