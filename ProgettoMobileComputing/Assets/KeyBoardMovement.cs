using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class KeyBoardMovement : MonoBehaviour
{
    //Movement
    Rigidbody rb;
    float horInput;
    float verInput;
    public float movSpeed;
    Vector3 moveDirection;


    //Camera
    float xRotation;
    float yRotation;
    public float mouseSens;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Camera
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * mouseSens;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * mouseSens;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);

        //Movement
        MyInput();
        MovePlayer();
    }
    void MyInput(){
        horInput = Input.GetAxisRaw("Horizontal");
        verInput = Input.GetAxisRaw("Vertical");
    }

    void MovePlayer(){
        moveDirection = transform.forward * verInput + transform.right * horInput;
        rb.AddForce(moveDirection.normalized * movSpeed, ForceMode.Force);
    }
}
