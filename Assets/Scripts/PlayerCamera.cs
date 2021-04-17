using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    Vector3 cameraOffset;
    public GameObject followedGameOjbect;
    void Awake()
    {
        if(followedGameOjbect)
        CalculateOffset();
    }

    void Update()
    {
        if (followedGameOjbect) {
            transform.position = followedGameOjbect.transform.position + cameraOffset;
        } 
    }

    public void CalculateOffset()
    {
        cameraOffset = transform.position - followedGameOjbect.transform.position;
    }

}
