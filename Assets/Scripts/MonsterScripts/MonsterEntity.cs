using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MonsterEntity : MonoBehaviour
{
    public MonsterData monsterData;
    public NavMeshAgent navAgent;
    private void Awake()
    {
        navAgent.speed = monsterData.Speed;
    }
    public void SetDestination(Vector3 vector)
    {
        navAgent.SetDestination(vector);
    }

    public void GetHit(Bullet bullet)
    {
        monsterData.Health -= bullet.weaponData.Damage * (1 - monsterData.Armor);
        if (monsterData.Health <= 0f)
            Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tank"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Bullet data = collision.gameObject.GetComponent<Bullet>();
            if (data)
                GetHit(data);
            else
                Debug.LogError("Bullet object lancks Bullet scripts");
        }
    }
}
