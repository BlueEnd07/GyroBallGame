﻿using System.Collections;
using UnityEngine;

public class followplayer : MonoBehaviour
{

    //getting transform of ball
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;



    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPos = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = smoothPos;

        transform.LookAt(target);


    }       
}
