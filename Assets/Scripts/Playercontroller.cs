using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {
    private Rigidbody rb;

    public float speed; //Puts the variable in the editor to easily manipulate

    void Update() { }

    void Start(){ //Before anything is called, checks the player object for any compnents listed below
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal"); //Gets the horizontal change from the keyboard
        float moveVertical = Input.GetAxis("Vertical"); //Gets the vertical change from the keyboard

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //Vector3 needs to have three variable, xyz

        rb.AddForce(movement * speed); //Changes where the player object is going based on the Vector3 variables
    }
}
