using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab2 : MonoBehaviour
{
    float speed = 0.5f;
    float jumpspeed = 2f;

    Rigidbody rb;
    float horizontal;
    float vertical;
    float jump;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        rb.AddForce((transform.right * horizontal) * speed / Time.deltaTime);
        vertical = Input.GetAxis("Vertical");
        rb.AddForce((transform.forward * vertical) * speed / Time.deltaTime);
        jump = Input.GetAxis("Jump");
        rb.AddForce((transform.up * jump) * jumpspeed / Time.deltaTime);
    }
}