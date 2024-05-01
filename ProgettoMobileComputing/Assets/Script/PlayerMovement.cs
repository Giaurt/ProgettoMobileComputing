using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera playerCamera;
    public Joystick mJoystick;
    public float movSpeed;
    public float vHorSpeed;
    public float vVerSpeed;
    public Joystick vJoystick;
    Rigidbody rb;

    float joystickX;
    float joystickY;
    float yRotation;
    float xRotation;
    Vector3 movement;
    Vector3 movementKB;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //PlayerMovement
        movement = playerCamera.transform.forward * mJoystick.Vertical + playerCamera.transform.right * mJoystick.Horizontal;

        rb.AddForce(movement * movSpeed * Time.deltaTime, ForceMode.Force);
        

        //VisualMovement
        joystickX = vJoystick.Horizontal * vHorSpeed * Time.deltaTime;
        joystickY = vJoystick.Vertical * vVerSpeed * Time.deltaTime;
        
        yRotation += joystickX;

        xRotation -= joystickY;
        playerCamera.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        

    }
    
}
