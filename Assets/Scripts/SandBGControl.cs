using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandBGControl : MonoBehaviour
{
    public AudioClip MusicClip; //holds our music and sound effects
    public AudioSource MusicSource;

    void Start()
    {
        MusicSource.clip = MusicClip;
        MusicSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        //offset = new Vector2(0, Time.time * speed);
        //GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
