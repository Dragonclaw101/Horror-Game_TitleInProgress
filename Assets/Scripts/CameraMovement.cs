using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour{
    public GameObject tempPlayer;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - tempPlayer.transform.position;
    }

    void LateUpdate()
    {
        transform.position = tempPlayer.transform.position + offset;
    }
}
