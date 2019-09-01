using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleLevel1 : MonoBehaviour
{
    public float speed = 1f;
    public UIManagerLevel1 ui; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y >= 0.1820 && transform.position.y < 6)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);

        }
       
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Trash")
        {
            print("Hit");
            Destroy(gameObject);
            ui.GameOverActivated();
        }
    }

}
