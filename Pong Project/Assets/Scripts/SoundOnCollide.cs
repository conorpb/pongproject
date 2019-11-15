/*
 By: Conor Brennan 
 Date: 11/14/19
 Description: Tells soundmanager to play contact sound if the ball collides with the object that this script is connected to.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollide : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<LaunchBall>())
        {
            SoundManagerScript.PlaySound("ContactSound(complete)");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
