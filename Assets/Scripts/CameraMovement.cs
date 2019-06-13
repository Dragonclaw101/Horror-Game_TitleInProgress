using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour{
    public GameObject tempPlayer;
    public float speed;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - tempPlayer.transform.position;
        
    }

    void LateUpdate()
    {
        //Camera mycam = GetComponent<Camera>();
        transform.position = tempPlayer.transform.position + offset;
        //transform.LookAt(mycam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane)), Vector3.up);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(-Vector3.right * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(-Vector3.up * speed * Time.deltaTime);

       
    }
}
