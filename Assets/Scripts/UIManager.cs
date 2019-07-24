using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UIManager : MonoBehaviour
{

    public Text scoreText;
    int score;
    float delayTimer = 4.5f;
    float timer;
    int counter; 

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        counter = 0; 
        timer = delayTimer; 
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        timer -= Time.deltaTime;
        if (timer <= 0 && score < 16)
        {
            scoreUpdate();
            if (score == 1)
            {
                delayTimer = 8f; 
            }
            if (score < 4)
            {
                delayTimer -= 0.5f;
                timer = delayTimer;
            }
            if (score == 4)
            {
                delayTimer -= 1;
                timer = delayTimer; 
            }
            if (score > 4 && score < 7)
            {
                delayTimer = 2.5f;
                timer = delayTimer; 
            } 
            if (score >= 7 && score < 16)
            {
                delayTimer = 2.2f;
                timer = delayTimer; 
            }
        }
    }

    void scoreUpdate()
    {
        score += 1; 
    }
}
