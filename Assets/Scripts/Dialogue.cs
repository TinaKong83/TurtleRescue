using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue 
{
    //minimum and max number of lines used in a diag box
    [TextArea(3, 10)]
    public string[] sentences;
}
