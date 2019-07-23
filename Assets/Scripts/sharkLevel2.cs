using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkLevel2 : MonoBehaviour
{

    private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,1,0) * -speed * Time.deltaTime);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
