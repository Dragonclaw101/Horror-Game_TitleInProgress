using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour{
    public GameObject tempPlayer;
    public float speed;
    private Vector3 offset;
    private Vector3 offsetY;

    private float jump = 0.5f;
    private float jumpcontrol = 0.25f;
    private float jumpTime = 0f;

    private float x;
    private float Rx;

    private float y;
    private float Ry;

    private float z;
    private float Rz;

    void Start()
    {
        offset = transform.position - tempPlayer.transform.position;
        offsetY = new Vector3(0, 4, 0);
        
    }

    void FixedUpdate(){
        Camera mycam = GetComponent<Camera>();
        if (mycam.transform.rotation.z != 180)
        {
            //mycam.transform.Rotate(mycam.transform.rotation.x, mycam.transform.rotation.y, 180);
        }
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position = transform.position + new Vector3(0, 0, speed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.position = transform.position + new Vector3(0, 0, -speed);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.position = transform.position + new Vector3(speed, 0, 0);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.position = transform.position + new Vector3(-speed, 0, 0);
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

        }
    }

    void LateUpdate()
    {
        Camera mycam = GetComponent<Camera>();
        //transform.position = tempPlayer.transform.position + offsetY;
        //transform.LookAt(mycam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane)), Vector3.up);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(-Vector3.right * 45 * Time.deltaTime);

        else if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.right * 45 * Time.deltaTime);

        else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * 45 * Time.deltaTime);

        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(-Vector3.up * 45 * Time.deltaTime);

       
    }
}
