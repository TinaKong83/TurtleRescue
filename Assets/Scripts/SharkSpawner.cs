using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkSpawner : MonoBehaviour
{
    public GameObject shark;
    public float maxPos = 2f;
    float delayTimer = 7f;
    float counter;  
    float timer;
    int sharks;
    float[] numbers;
    public UIManagerLevel2 ui;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;

        MakeSharks();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (counter <= 4)
            {
                counter += 1f;
            }
            if (sharks < 16 && !ui.gameOver)
            {
                MakeSharks(); 
            }
            timer = delayTimer - counter;
        }
    }

    void MakeSharks()
    {
        float x = Random.Range(-maxPos, maxPos); 
        Vector3 sharkPos = new Vector3(x, transform.position.y, transform.position.z);
        Instantiate(shark, sharkPos, transform.rotation);
        sharks += 1; 
    }
}
