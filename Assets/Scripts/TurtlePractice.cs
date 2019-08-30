using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtlePractice : MonoBehaviour
{
    public UIManagerP ui;
    private bool isColliding; 
     // Start is called before the first frame update
    void Start()
    {
        isColliding = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (!isColliding)
        {
            float temp = Input.acceleration.x;

            transform.Translate(temp, 0f, 0f);

            Vector3 minScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
            Vector3 maxScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minScreenBounds.x + 1, maxScreenBounds.x - 1), Mathf.Clamp(transform.position.y, minScreenBounds.y + 1, maxScreenBounds.y - 1), transform.position.z);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "PlasticBag")
        {
            Destroy(gameObject);
            ui.GameOverActivated();
        }
        else if (col.gameObject.tag == "Jellyfish")
        {
            isColliding = true;
            Destroy(col.gameObject);
            ui.GameWon();
        }

    }
}
