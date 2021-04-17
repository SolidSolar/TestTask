using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEntity : MonoBehaviour
{
    public TankData tankData;
    public TankWeaponsManager tankWeaponsManager;
    public Rigidbody rigidbody;
    Bounds tankBounds;
    float movementVelocity;
    float rotationVelocity;
    public float distanceToGroundOffset;
    void Start()
    {
        tankWeaponsManager.ChangeWeapon(0);                                 //sets default MG weapon
        Collider[] colliders = GetComponentsInChildren<Collider>();
        tankBounds = new Bounds(transform.position, Vector3.zero);          
        foreach (Collider nextCollider in colliders)
        {
            tankBounds.Encapsulate(nextCollider.bounds);
        }
    }

    void Update()
    {

        if (Physics.Raycast(transform.position, -transform.up, tankBounds.extents.y + distanceToGroundOffset))
        {
            rigidbody.velocity = transform.forward * movementVelocity;
            rigidbody.angularVelocity = transform.up * rotationVelocity;
        }
    }

    public void SetMovementVector(float value)
    {
        movementVelocity = value* tankData.Speed;
    }
    public void SetRotationVector(float value)
    {
        rotationVelocity = value * tankData.AngularSpeed * Mathf.Deg2Rad;
    }

    public void ChangeWeapon(int index)
    {
        tankWeaponsManager.ChangeWeapon(index);
    }

    public void Fire()
    {
        tankWeaponsManager.GetCurrentWeapon().Fire();
    }
    public void GetHit(MonsterData monsterData)
    {
        tankData.Health -= monsterData.Damage * (1 - tankData.Armor);
        if (tankData.Health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(this.gameObject);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            MonsterData data = collision.gameObject.GetComponent<MonsterData>();
            if (data)
                GetHit(data);
            else
                Debug.LogError("Object lancks MonsterData scripts");
        }
    }

}
