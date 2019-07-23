using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UIManager : MonoBehaviour
{

    public Text scoreText;
    int score; 

    // Start is called before the first frame update
    void Start()
    {
        score = 0; 
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        scoreText.text = "Sharks avoided: " + score; 
=======
        scoreText.text = "Score: " + score; 
>>>>>>> d5a0d4266e5917c79e0edad56dd33358448d29ee
    }

    void scoreUpdate()
    {
        score += 1; 
    }
}
