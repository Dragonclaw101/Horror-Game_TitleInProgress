using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {
    private Rigidbody rb;
    public GameObject Player;
    private float NULL = 1;
    public float speed; //Puts the variable in the editor to easily manipulate

    private float jump = 0.5f;
    private float jumpcontrol = 0.25f;
    private float jumpTime = 0f;
    void Update() { }

    void Start(){ //Before anything is called, checks the player object for any compnents listed below
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {/*
        Vector3 movement;
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0, speed);
            movement = new Vector3(0, 0, 1);
            NULL = 2;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, 0, -speed);
            movement = new Vector3(0, 0, -1);
            NULL = 1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed, 0, 0);
            movement = new Vector3(1, 0, 0);
            NULL = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-speed, 0, 0);
            movement = new Vector3(-1, 0, 0);
            NULL = 1;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            if (transform.position.y <= 3)
                transform.position = transform.position + new Vector3(0, jump, 0);
                transform.position = transform.position - new Vector3(0, jumpcontrol, 0);
                jumpTime++;
        }
        else
        {
            jumpTime = 0;
        }
        

  
        //rb.AddForce(movement * (speed * NULL)); //Changes where the player object is going based on the Vector3 variables
        */
    }
}
