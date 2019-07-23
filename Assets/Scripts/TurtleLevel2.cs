using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleLevel2 : MonoBehaviour
{

    public float turtleSpeed = 2;
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

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "EnemyShark")
        {
            Destroy(gameObject);
        }
    }
}
