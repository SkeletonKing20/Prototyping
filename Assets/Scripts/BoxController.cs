﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = Vector3.zero;
        if (Input.GetButtonUp("Jump"))
        {
            GetComponent<FixedJoint2D>().enabled = false;
        }
    }
}