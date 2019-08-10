using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UIManagerP : MonoBehaviour
{
    public Button[] buttons;
    public Button[] nextLevel;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
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
