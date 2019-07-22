using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour
{

    public float turtleSpeed;
    public float maxPos = 2.15f; 

    Vector3 position; 

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * turtleSpeed * Time.deltaTime;

        position.x = Mathf.Clamp(position.x, -maxPos, maxPos);

        transform.position = position;
    }
}
