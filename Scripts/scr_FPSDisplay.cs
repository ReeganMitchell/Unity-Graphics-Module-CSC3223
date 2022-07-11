using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_FPSDisplay : MonoBehaviour
{

    public float timer, refresh, fps;
    private Text textObject;
    private float delay = 1f; //update every 1 second


    void Start()
    {
        textObject = GetComponent<Text>();
    }


    void Update()
    {
        if (Time.unscaledTime > timer) //
        {
            int fps = (int)(1f / Time.unscaledDeltaTime); //calculate fps
            textObject.text = "FPS: " + fps;
            timer = Time.unscaledTime + delay;
        }
    }
}
