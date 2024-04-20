using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera playerCamera;
    public Joystick mJoystick;
    public float horSpeed;
    public float verSpeed;
    public float vHorSpeed;
    public float vVerSpeed;
    public Joystick vJoystick;
    Rigidbody rb;
    float pitch;
    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(mJoystick.Horizontal * horSpeed, 0, mJoystick.Vertical * verSpeed);

        rb.AddForce(movement * Time.deltaTime, ForceMode.Force);

        
        angle += vJoystick.Horizontal * vHorSpeed;
        pitch += vVerSpeed * vJoystick.Vertical; 
        pitch = Mathf.Clamp(pitch, -40, 40);
        gameObject.transform.localEulerAngles = new Vector3(0, angle, 0);
        playerCamera.transform.localEulerAngles = new Vector3(-pitch, 0, 0);
        

    }
}
