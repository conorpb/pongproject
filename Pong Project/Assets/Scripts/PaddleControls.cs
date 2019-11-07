/* 
 By: Conor Brennan
 Date: 11/7/19
 Description: Up and down controlls for the paddles
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControls : MonoBehaviour
{
    public float speed = 10;
    Rigidbody2D myRB;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movement = new Vector2(0, 0);

        if(Input.GetKey(KeyCode.W))
        {
            movement += speed * new Vector2(transform.up.x, transform.up.y).normalized;
        }
        if(Input.GetKey(KeyCode.S))
        {
            movement -= speed * new Vector2(transform.up.x, transform.up.y).normalized;
        }
        myRB.AddForce(movement * Time.deltaTime);
    }
}
