using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleLevel2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float temp = Input.acceleration.x;

        transform.Translate(temp, 0f, 0f);

        if (transform.position.x > 3.3f)
        {
            transform.Translate(3.3f, 0f, 0f);
        }

        if (transform.position.x < -3.3f)

        {
            transform.Translate(-4f, 0f, 0f);

        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "EnemyShark")
        {
            Destroy(gameObject);
        }
    }
}
