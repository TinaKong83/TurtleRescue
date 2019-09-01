using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UIManagerLevel2 : MonoBehaviour
{
    public Button[] buttons;
    public Button[] nextLevel; 
    float delayTimer = 4.5f;
    float timer;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {

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

