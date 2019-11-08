using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text textObj;
    public int goal;
    public int score = 0;
    public GameObject ball;

    public void updateScore()
    {
        if (goal > 0)
        {
            if (ball.transform.position.x > goal)
            {
                score++;
                textObj.text = "" + score;
            }
        }
        else
        {
            if (ball.transform.position.x < goal)
            {
                score++;
                //set the text to equal the score
                textObj.text = "" + score;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       ball = FindObjectOfType<LaunchBall>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        updateScore();
    }
}
