/* 
 By: Conor Brennan
 Date: 11/7/19
 Description: Up and down controlls for the left paddle.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleController : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //moves paddle up or down depending on input
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0, -speed * Time.deltaTime, 0);
        }
    }
}
