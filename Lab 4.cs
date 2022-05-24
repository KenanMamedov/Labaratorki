using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4 : MonoBehaviour
{
    [SerializeField]
    private Canvas _canvas;

    [SerializeField]
    private GameObject _mainText;

    [SerializeField]
    private GameObject _description1;

    [SerializeField]
    private GameObject _description2;

    [SerializeField]
    private GameObject _description3;

    public bool isTriggered1 = false;
    public bool isTriggered2 = false;
    public bool isTriggered3 = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trigger1")
        {
            _mainText.SetActive(true);
            isTriggered1 = true;
        }
        if (other.gameObject.tag == "Trigger2")
        {
            _mainText.SetActive(true);
            isTriggered2 = true;
        }
        if (other.gameObject.tag == "Trigger3")
        {
            _mainText.SetActive(true);
            isTriggered3 = true;
        }
    }

    private void Update()
    {
        if (isTriggered1 == true)
            if (Input.GetKeyDown(KeyCode.E))
            {
                _description1.SetActive(true);
                _mainText.SetActive(false);
            }
        if (isTriggered2 == true)
            if (Input.GetKeyDown(KeyCode.E))
            {
                _description2.SetActive(true);
                _mainText.SetActive(false);
            }
        if (isTriggered3 == true)
            if (Input.GetKeyDown(KeyCode.E))
            {
                _description3.SetActive(true);
                _mainText.SetActive(false);
            }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Trigger1")
        {
            _description1.SetActive(false);
            _mainText.SetActive(false);
            isTriggered1 = false;
        }
        if (other.gameObject.tag == "Trigger2")
        {
            _description2.SetActive(false);
            _mainText.SetActive(false);
            isTriggered2 = false;
        }
        if (other.gameObject.tag == "Trigger3")
        {
            _description3.SetActive(false);
            _mainText.SetActive(false);
            isTriggered3 = false;
        }
    }
}