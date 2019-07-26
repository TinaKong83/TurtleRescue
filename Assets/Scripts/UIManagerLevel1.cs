using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerLevel1 : MonoBehaviour
{

    public Button[] buttons;
    public Button[] nextLevel;
    public float timeStart = 20;
    public Text textBox;
    [SerializeField]
    private Transform turtlePosition;

    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeStart > 0)
        {
            if (turtlePosition.position.y > 4)
            {
                GameWon();
            }
            if (turtlePosition.position.y < 0.1820)
            {
                timeStart -= Time.deltaTime;
                textBox.text = Mathf.Round(timeStart).ToString();
            }
        }
        if (timeStart <= 0)
        {
            GameOverActivated();
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void GameOverActivated()
    {
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    public void GameWon()
    {
        foreach (Button next in nextLevel)
        {
            next.gameObject.SetActive(true);
        }
    }
}