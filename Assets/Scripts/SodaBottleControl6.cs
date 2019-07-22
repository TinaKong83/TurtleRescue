using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SodaBottleControl6 : MonoBehaviour
{
    [SerializeField]
    private Transform turtlePosition;
    [SerializeField]
    private Transform garbageCanPlace;
    public AudioClip MusicClip; //holds our music and sound effects
    public AudioSource MusicSource;
    private Vector2 initialPosition;
    private float deltaX, deltaY;
    public static bool isLocked;
    //public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        //transform.Translate(0, -speed * Time.deltaTime, 0);
    }

    // Touch phase documentation: https://docs.unity3d.com/ScriptReference/TouchPhase.html
    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, -speed * Time.deltaTime, 0);

        if (Input.touchCount > 0 && !isLocked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            // Handle finger movements based on TouchPhase
            switch (touch.phase)
            {
                //When a touch has first been detected
                case TouchPhase.Began:
                    //check if the soda bottle's position overlaps with the position of our touch
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPosition))
                    {
                        //an offset between touch position and the center of our soda bottle object
                        deltaX = touchPosition.x - transform.position.x;
                        deltaY = touchPosition.y - transform.position.y;
                    }
                    break;
                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPosition))
                    {
                        transform.position = new Vector2(touchPosition.x - deltaX, touchPosition.y - deltaY);
                    }
                    break;
                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - garbageCanPlace.position.x) <= 2f
                        && Mathf.Abs(transform.position.y - garbageCanPlace.position.y) <= 2f)
                    {
                        transform.position = new Vector2(garbageCanPlace.position.x, garbageCanPlace.position.y);
                        turtlePosition.Translate(0.0f, 0.5f, 0.0f);
                        MusicSource.clip = MusicClip;
                        MusicSource.Play();
                        isLocked = true;
                    }
                    else
                    {
                        transform.position = new Vector2(initialPosition.x, initialPosition.y);
                    }
                    break;
            }
        }

    }
}

