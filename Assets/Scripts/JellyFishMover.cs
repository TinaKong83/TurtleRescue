using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyFishMover : MonoBehaviour
{
    private float speed = 5f;
    private float timer;
    public UIManagerLevel2 ui; 

    // Start is called before the first frame update
    void Start()
    {
        timer = 55f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            transform.Translate(new Vector3(0, 1, 0) * -speed * Time.deltaTime);

            if (transform.position.y < -10)
            {
                Destroy(gameObject);
            }
        }
    }


}
