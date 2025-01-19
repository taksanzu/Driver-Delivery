using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 75.0f; 
    void Start()
    {
        
    }

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");


        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.up);
        transform.Rotate(-turnSpeed * turnInput * Time.deltaTime * Vector3.forward);
    }
}
