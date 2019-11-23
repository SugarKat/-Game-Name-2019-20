﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{


    private Transform playerTransform;


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void LateUpdate()
    {
        // we store current camera´s position in variable temp - temporary position
        Vector3 temp = transform.position;


        // we set the cameras position x to be equal to the players position x
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;


        // we set back the cameras temo position to the cameras current position
        transform.position = temp;
    }
}