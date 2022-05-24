using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab1 : MonoBehaviour
{
    public float invoke_delay = 0.15f;
    private void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0, 4f) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, 0, -4f) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(4f, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-4f, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space)) Jump();
    }
    void Jump()
    {
        transform.position = transform.position + new Vector3(0, 4f, 0);
        Invoke("Jump2", invoke_delay);
    }
    void Jump2()
    {
        transform.position = transform.position + new Vector3(0, -4f, 0);
    }
}