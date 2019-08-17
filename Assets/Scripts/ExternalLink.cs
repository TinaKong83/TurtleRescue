using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalLink : MonoBehaviour
{
    public string LinkName; 

    public void OpenLink()
    {
        Application.OpenURL(LinkName);
    }
}
