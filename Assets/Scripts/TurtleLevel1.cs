using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleLevel1 : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y >= 0.1820 && transform.position.y < 4)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);

        }
       
    }
}
