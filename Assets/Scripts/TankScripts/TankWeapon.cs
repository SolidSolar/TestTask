using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankWeapon : MonoBehaviour
{
    [Tooltip("rounds per minute")]
    public float RateOfFire;
    public float Damage;
    public float ProjectileSpeed = 100f;
    public float LifeTime = 2f;
    public GameObject bullet;
    public Transform spawnPoint;

    float _lastRoundTime;
    public void Fire()
    {
        if (Time.time - _lastRoundTime >= 60f/ RateOfFire)   //seconds between individual rounds
        {
            Bullet bul = Instantiate(bullet, spawnPoint.position, Quaternion.identity).GetComponent<Bullet>();
            bul.weaponData = this;
            _lastRoundTime = Time.time;
        }
    }
}
