using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSea : MonoBehaviour
{

    float speed = -3f;
    Vector2 startPos; 

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * speed, 13.5f);
        transform.position = startPos + Vector2.up * newPos;
    }

}
