using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCanvas : MonoBehaviour
{
    public GameObject canvas;
    public bool canvasStart;

    public void DisableCanvas()
    {
        canvas.SetActive(false);
    }

    public void EnableCanvas()
    {
        canvas.SetActive(true);
    }

    void Start() 
    {
        if (canvasStart == true)
        {
            EnableCanvas();
        }
        else
        {
            DisableCanvas();
        }
    }
}
