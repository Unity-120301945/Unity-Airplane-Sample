﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 摄像头跟随脚本
 */
public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(20,2,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
