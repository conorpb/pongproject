/*
 By: Conor Brennan
 Date: 11/14/19
 Description: Controlls when sound effects play
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip BallContactSound;
    static AudioSource AudioSrc;

    // Start is called before the first frame update
    void Start()
    {
        BallContactSound = Resources.Load<AudioClip>("ContactSound");
        AudioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "ContactSound":
                AudioSrc.PlayOneShot(BallContactSound);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
