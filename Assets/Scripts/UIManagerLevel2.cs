﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UIManagerLevel2 : MonoBehaviour
{
    public Button[] buttons;
    public Button[] nextLevel; 
    public Text scoreText;
    int score;
    float delayTimer = 4.5f;
    float timer;
    bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        timer = delayTimer;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        timer -= Time.deltaTime;
        if (timer <= 0 && score < 16)
        {
            ScoreUpdate();
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

    void ScoreUpdate()
    {
        if (gameOver == false)
        {
            score += 1;
        }
    }


    public void GameOverActivated()
    {
        gameOver = true;

        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    public void GameWon()
    {
        gameOver = true;

        foreach (Button next in nextLevel)
        {
            next.gameObject.SetActive(true);
        }
    }
}
