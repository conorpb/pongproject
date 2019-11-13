﻿/* 
 By: Conor Brennan
 Date: 11/7/19
 Description: Up and down controlls for the left paddle.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeftPaddleController : MonoBehaviour
{
    //boolean deciding whether or not the paddle will use the shrinking code
    public bool shrinks = false;


    private void Shrinking(Collision2D collision)
    {
        //runs code if shrinks is true
        if (shrinks == true)
        {
            if(collision.gameObject.GetComponent<LaunchBall>())
            {
                transform.localScale -= new Vector3(0, 1, 0);
            }
        }
    }

    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
          //moves paddle up or down depending on input
        if(Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, speed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, -speed * Time.deltaTime, 0);
        }

    }
}
