using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLevel1 : MonoBehaviour
{
    public AudioClip MusicClip; //holds our music and sound effects
    public AudioSource MusicSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        MusicSource.clip = MusicClip;
        MusicSource.Play();
    }
}
