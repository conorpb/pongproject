using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    //declare variables
    public Text textObj;
    public int goal;
    public int score = 0;
    public GameObject ball;
    public string winScreen = "insert win screen here";

    // Start is called before the first frame update
    void Start()
    {
       ball = FindObjectOfType<LaunchBall>().gameObject;
    }

    public void updateScore()
    {
        //check if the score is above or below 0
        if (goal > 0)
        {
            if (ball.transform.position.x > goal)
            {
                //increase the score
                score++;
                //change the text to equal the score
                textObj.text = "" + score;
            }
        }
        else
        {
            if (ball.transform.position.x < goal)
            {
                //increase the score
                score++;
                //set the text to equal the score
                textObj.text = "" + score;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        updateScore();

        //if a player's score reaches 10, load the win screen for that player
        if(score == 10)
        {
            SceneManager.LoadScene(winScreen);
        }
    }
}
