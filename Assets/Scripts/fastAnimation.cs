using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fastAnimation : MonoBehaviour
{
    Animator anim;
    private float animSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.speed = animSpeed;
    }
}
