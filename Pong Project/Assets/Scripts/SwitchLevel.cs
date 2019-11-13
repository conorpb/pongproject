/*
 By: Liam Binford
 Date: 11/7/19
 Description: Script applied to things that change the scene
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevel : MonoBehaviour
{
    //find the scene of this name
    public string NextScene = "Level1";

    public void ChangeScene()
    {
        if (NextScene == "End")
        {
            //if the scene loaded is "End", quit the game
            Application.Quit();
        }
        else
        {
            //load that scene
            SceneManager.LoadScene(NextScene);
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
