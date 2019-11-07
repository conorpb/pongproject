/*
 By: Liam Binford
 Date: 11/7/19
 Description: Porgram for launching the ball at the beginning of the round
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    public float speed = 10;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y == 0 && transform.position.x == 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Vector2 dir = Random.insideUnitCircle.normalized;
                rb.velocity = speed * dir;
            }
        }
    }
}
