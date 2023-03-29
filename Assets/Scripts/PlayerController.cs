using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 25;
    private float inputHorizontal;
    private float inputVertical;
    // public Camera firstPersonCamera;
    // public Camera thridPersonCamera;

    void Start()
    {
        // firstPersonCamera.enabled = false;
        // thridPersonCamera.enabled = true;
    }

    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");
        // transform.Translate(0,0,1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * inputVertical);
        // transform.Translate(Vector3.right * Time.deltaTime*turnSpeed*inputHorizontal);
        transform.Rotate(Vector3.up, turnSpeed * inputHorizontal * Time.deltaTime);
        // if (Input.GetKeyDown(KeyCode.V))
        // {
        //     if (thridPersonCamera.enabled == true)
        //     {
        //         thridPersonCamera.enabled = false;
        //         firstPersonCamera.enabled = true;
        //     }
        //     else if (firstPersonCamera.enabled == true)
        //     {
        //         firstPersonCamera.enabled = false;
        //         thridPersonCamera.enabled = true;
        //     }
        // }
    }
}
