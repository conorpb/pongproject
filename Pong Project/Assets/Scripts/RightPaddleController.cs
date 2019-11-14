/* 
 By: Conor Brennan
 Date: 11/14/19
 Description: Up and down controlls for the left paddle.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleController : MonoBehaviour
{
    public bool shrinks = false;
    public float speed = 10;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //runs code if shrinks is true
        if (shrinks == true)
        {
            //when colliding with the ball, shrink along the y-axis
            if (collision.gameObject.GetComponent<LaunchBall>())
            {
                transform.localScale -= new Vector3(0, 0.1f, 0);
            }

            //cap the shrinking at 0.8
            if (transform.localScale.y <= 0.8)
            {
                shrinks = false;
            }
        }
    }

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
