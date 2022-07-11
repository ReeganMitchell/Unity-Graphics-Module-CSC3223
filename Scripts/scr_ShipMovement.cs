using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_ShipMovement : MonoBehaviour
{
    public Transform body, innerLight, outerLight;
    public Transform[] points;
    public float speed;
    private int startPoint, endPoint;
    private float startTime;
    private float journeyLength;


    void Start()
    {
        startPoint = 0;
        endPoint = 1;
        body.position = points[startPoint].position;
        StartMovement(startPoint, endPoint);
    }


    void Update()
    {
        RotateLights();

        if (body.position == points[endPoint].position) { //checks if ship has reached end point
            startPoint++;
            if (startPoint >= points.Length)
            {
                startPoint = 0;
            }
            endPoint++;
            if (endPoint >= points.Length)
            {
                endPoint = 0;
            }
            StartMovement(startPoint, endPoint);
        }
        else
        {
            float distCovered = (Time.time - startTime) * speed ;
            float fractionOfJourney = distCovered / journeyLength;

            body.position = Vector3.Lerp(points[startPoint].position, points[endPoint].position, fractionOfJourney); //moves ship towards target point
        }
    }

    void StartMovement(int p1, int p2) //starts the movement between next 2 points
    {
        journeyLength = Vector3.Distance(points[p1].position, points[p2].position);
        startTime = Time.time;

        body.LookAt(points[p2]);
        Debug.Log("length: " + journeyLength);
    }

    void RotateLights() //rotates the spot lights
    {
        innerLight.Rotate(0f,40f * (float)Time.deltaTime,0f);
        outerLight.Rotate(0f,-40f * (float)Time.deltaTime, 0f);
    }
}
