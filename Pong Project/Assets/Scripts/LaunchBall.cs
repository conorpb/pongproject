/*
 By: Liam Binford
 Date: 11/13/19
 Description: Porgram for launching the ball at the beginning of the round
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    public float speed = 10;
    Rigidbody2D rb;
    public bool launched = false;
    public Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //checks if ball is in starting position so that it can't be reset during gameplay
        if(!launched)
        {
            //chooses random direction to launch the ball in when you press space
            if (Input.GetKey(KeyCode.Space))
            {
                Vector2 dir = Random.insideUnitCircle.normalized;
                if (dir.x < 0)
                {
                    dir.x -= 10;
                }
                else if (dir.x > 0)
                {
                    dir.x += 10;
                }
                rb.velocity = speed * dir.normalized;
                launched = true;
            }
        }
        
        
    }

    public void reset()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = startPos;
        launched = false;

        if (FindObjectOfType<RightPaddleController>().shrinked == true)
        {
            FindObjectOfType<RightPaddleController>().transform.localScale = new Vector3(0.3f, 2, 0);
            FindObjectOfType<RightPaddleController>().shrinks = true;
        }
        if (FindObjectOfType<LeftPaddleController>().shrinked == true)
        {
            FindObjectOfType<LeftPaddleController>().transform.localScale = new Vector3(0.3f, 2, 0);
            FindObjectOfType<LeftPaddleController>().shrinks = true;
        }
    }
}
