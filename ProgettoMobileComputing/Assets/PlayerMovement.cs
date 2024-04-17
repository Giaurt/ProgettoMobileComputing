using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera playerCamera;
    public Joystick joystick;

    public Joystick visualJoystick;
    Rigidbody rb;

    public float horSpeed;
    public float verSpeed;
    public float horVisualSpeed;
    public float verVisualSpeed;
    float pitch;
    float yAngle;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 movement = new Vector3(joystick.Horizontal * horSpeed, 0, joystick.Vertical * verSpeed);

        rb.AddForce(transform.TransformDirection(movement) * Time.deltaTime);



        yAngle = transform.localEulerAngles.y + visualJoystick.Horizontal * horVisualSpeed;
        
        pitch -= verVisualSpeed * visualJoystick.Vertical; 

        transform.localEulerAngles = new Vector3(0, yAngle, 0);
        playerCamera.transform.localEulerAngles = new Vector3(pitch, 0, 0);

        
    }
}
