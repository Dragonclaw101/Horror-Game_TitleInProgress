using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {
    private Rigidbody rb;
    private float NULL = 1;
    public float speed; //Puts the variable in the editor to easily manipulate
    public float jump;
    void Update() { }

    void Start(){ //Before anything is called, checks the player object for any compnents listed below
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        Vector3 movement;
        if (Input.GetKey(KeyCode.W)){
            movement = new Vector3(0, 0, 1);
            NULL = 1;
        }
        else if (Input.GetKey(KeyCode.S)){
            movement = new Vector3(0, 0, -1);
            NULL = 1;
        }
        else if (Input.GetKey(KeyCode.D)){
            movement = new Vector3(1, 0, 0);
            NULL = 1;
        }
        else if (Input.GetKey(KeyCode.A)){
            movement = new Vector3(-1, 0, 0);
            NULL = 1;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            movement = new Vector3(0, jump , 0);
        }
        else{
            movement = new Vector3(0, 0, 0);
            NULL = 0;
        }

  
        rb.AddForce(movement * speed); //Changes where the player object is going based on the Vector3 variables
        
    }
}
