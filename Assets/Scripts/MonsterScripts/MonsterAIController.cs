using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAIController : MonoBehaviour
{
    public MonsterEntity entity;
    public GameObject target;

    void Update()
    {
        if(target)
        entity.SetDestination(target.transform.position);
    }
}
