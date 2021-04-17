using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TankData : MonoBehaviour
{
    public float Health;
    public float Armor;
    [Tooltip("In m/s")]
    public float Speed;
    [Tooltip("In deg/s")]
    public float AngularSpeed;
}
