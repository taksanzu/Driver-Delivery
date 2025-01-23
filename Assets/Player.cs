using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed;
    private float normalSpeed = 20.0f;
    private float turnSpeed = 100.0f; 
    private float speedUp = 30.0f;
    private float slowDown = 10.0f;
    private float slowDuration = 2.0f;
    private bool isSlowed = false;

    void Start()
    {
        speed = normalSpeed;
    }
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.up);
        transform.Rotate(-turnSpeed * turnInput * Time.deltaTime * Vector3.forward);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("WorldObject") && !isSlowed)
        {
            StartCoroutine(SlowDown());
        }
        
    }

    IEnumerator SlowDown()
    {
        isSlowed = true;
        speed = slowDown;

        yield return new WaitForSeconds(slowDuration);

        speed = normalSpeed;
        isSlowed = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SpeedUp"))
        {
            speed = speedUp;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("SlowDown"))
        {
            speed = slowDown;
            Destroy(other.gameObject);
        }
    }
}
