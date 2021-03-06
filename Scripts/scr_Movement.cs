using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Movement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.8f;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        //controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += (gravity * Time.deltaTime);

        controller.Move(velocity * Time.deltaTime);
    }
}
