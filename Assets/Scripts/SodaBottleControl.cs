using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SodaBottleControl : MonoBehaviour
{
    [SerializeField]
    private Transform turtlePosition;
    [SerializeField]
    private Transform garbageCanPlace;

    //AudioLevel1 aud; 
    public AudioClip TrashClip;
    public AudioSource TrashSource;

    private Vector2 initialPosition;
    private float deltaX, deltaY;
    private bool isLocked;
    private GameObject turtle;

    public UIManagerLevel1 ui;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        turtle = GameObject.Find("leftMoved");
       
    }

    // Touch phase documentation: https://docs.unity3d.com/ScriptReference/TouchPhase.html
    // Update is called once per frame
    void Update()
    {
        /*
        if (GetComponent<Renderer>().bounds.Intersects(turtle.GetComponent<Renderer>().bounds))
        {
            ui.GameOverActivated();
            //Destroy(turtle);
            return;
        } */

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
                    if (GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(touchPosition))
                    {
                        //an offset between touch position and the center of our soda bottle object
                        deltaX = touchPosition.x - transform.position.x;
                        deltaY = touchPosition.y - transform.position.y;
                    }
                    break;
                case TouchPhase.Moved:
                    if (GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(touchPosition))
                    {
                        transform.position = new Vector2(touchPosition.x - deltaX, touchPosition.y - deltaY);
                    }
                    break;
                case TouchPhase.Ended:
                    if (Mathf.Abs(turtlePosition.position.x - transform.position.x) <= 1f 
                        && Mathf.Abs(turtlePosition.position.y - transform.position.y) <= 1f)
                    {
                        ui.GameOverActivated();
                        return;
                    }
                    if (Mathf.Abs(transform.position.x - garbageCanPlace.position.x) <= 1.8f
                        && Mathf.Abs(transform.position.y - garbageCanPlace.position.y) <= 1.8f)
                    {
                        transform.position = new Vector2(garbageCanPlace.position.x, garbageCanPlace.position.y);
                        turtlePosition.Translate(0.0f, 0.5f, 0.0f);
                        TrashSource.clip = TrashClip;
                        TrashSource.Play();
                        //aud.Play(); 
                        isLocked = true;
                        //Destroy(gameObject);
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

