using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
using UnityEngine;

public class sharkLevel2 : MonoBehaviour
{

    private float speed = 5f;

    // Start is called before the first frame update
=======
using UnityEngine;

public class sharkLevel2 : MonoBehaviour
{

    private float speed = 5f; 

     // Start is called before the first frame update
>>>>>>> d5a0d4266e5917c79e0edad56dd33358448d29ee
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
