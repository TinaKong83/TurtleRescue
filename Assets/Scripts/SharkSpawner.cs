using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkSpawner : MonoBehaviour
{
    public GameObject shark;
    public float maxPos = 2f;
    float delayTimer = 8f;
    float counter = 0f;  
    float timer; 

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;

        Vector3 sharkPos = new Vector3(Random.Range(-maxPos, maxPos), transform.position.y, transform.position.z);

        Instantiate(shark, sharkPos, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (counter <= 5)
            {
                counter += 1f;
            }

            Vector3 sharkPos = new Vector3(Random.Range(-maxPos, maxPos), transform.position.y, transform.position.z);

            Instantiate(shark, sharkPos, transform.rotation);
            
            timer = delayTimer - counter; 
        }

    }
}
