using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_DayNightCycle : MonoBehaviour
{

    public bool cycleOn;
    public Transform parent;
    public Light dayLight;
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cycleOn)
        {
            parent.Rotate(0f, 0f, -speed * (float)Time.deltaTime);//rotates parent object to make day night cycle work
        }
    }
}
