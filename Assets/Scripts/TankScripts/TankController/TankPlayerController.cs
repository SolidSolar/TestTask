using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class TankPlayerController : MonoBehaviour
{
    public TankEntity entity;
    InputMaster input;
    void Awake()
    {
        input = new InputMaster();
        input.Enable();
        input.Tank.Movement.performed += context => Move(context.ReadValue<float>());
        input.Tank.Movement.canceled += context => Move(context.ReadValue<float>());   //sends value of 0 as button is released
        input.Tank.ChangeWeapon.performed += context => ChangeWeapon((int)context.ReadValue<float>());  //even though type is float possible values can be only 1*scale(weapon index)
        input.Tank.Rotation.performed += context => Rotate(context.ReadValue<float>());
        input.Tank.Rotation.canceled += context => Rotate(context.ReadValue<float>());
        input.Tank.Fire.performed += context => Fire(context.ReadValue<float>());
        input.Tank.Fire.canceled += context => Fire(context.ReadValue<float>());
    }
    void Update()
    {
        if (isFiring)
        {
            entity.Fire();
        }
    }
    void Move(float value)
    {
        entity.SetMovementVector(value);
    }

    void ChangeWeapon(int index)
    {
        entity.ChangeWeapon(index);
    }

    public void Rotate(float value)
    {
        entity.SetRotationVector(value);
    }
    bool isFiring = false;
    void Fire(float value)
    {
        isFiring = value == 1f;
        
    }
    public void OnDestroy()
    {
        
    }

}
