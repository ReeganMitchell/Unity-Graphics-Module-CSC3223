using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_SensorTowerMovement : MonoBehaviour
{
    public Transform upper, inner, outer;
    public float speed = 1.0f;

    private Vector3 pos1 = new Vector3(0f, -0.4f, 0f); //bounds for up and down movement
    private Vector3 pos2 = new Vector3(0f, 0.4f, 0f);

    void Start()
    {
        
    }


    void Update() //move upper half and rotate circles
    {
        upper.localPosition = Vector3.Lerp(pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
        inner.Rotate(0f, 50f * (float)Time.deltaTime, 0f);
        outer.Rotate(0f,-50f * (float)Time.deltaTime, 0f);
    }
}
