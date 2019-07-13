using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    public bool isBallHit = false;


    void LateUpdate()
    {
        if (isBallHit)
        {
            transform.position = target.position + offset;
        }
    }
}
