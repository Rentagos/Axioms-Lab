using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtCameraMover : MonoBehaviour
{

    public float speed;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.localPosition += transform.forward * speed;
        if (Input.GetKey(KeyCode.S))
            transform.localPosition -= transform.forward * speed;
        if (Input.GetKey(KeyCode.A))
            transform.localPosition -= transform.right * speed;
        if (Input.GetKey(KeyCode.D))
            transform.localPosition += transform.right * speed;
    }
}
