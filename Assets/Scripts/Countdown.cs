using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float timeStart = 20;
    public Text textBox;
    [SerializeField]
    private Transform turtlePosition;

    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        if (timeStart >= 0)
        {
            if (turtlePosition.position.y < 0.1820)
            {
                textBox.text = Mathf.Round(timeStart).ToString();
            }
        }
    }
}
