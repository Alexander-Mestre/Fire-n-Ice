using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewaysForce = 2000f;

    // For block movement
    public float waitTime = 0.15f;
    public float blockSize = 2.4f;
    public float rightStop = 0f;
    public float leftStop = 0f;

    // For block movement
    private float lastPressed = 0f;

    // Block movement
    /*
    void FixedUpdate()
    {
        lastPressed += Time.deltaTime;

        if (Input.GetKey("d") && lastPressed > waitTime)
        {
            moveRight();
            lastPressed = 0f;
        }

        if (Input.GetKey("a") && lastPressed > waitTime)
        {
            moveLeft();
            lastPressed = 0f;
        }

    }
  
    void moveRight()
    {
        if (!(rb.position.x >= rightStop))
        {
            rb.position = new Vector3(rb.position.x + blockSize, rb.position.y, rb.position.z);
        }
    }

    void moveLeft()
    {
        if (!(rb.position.x <= leftStop))
        {
            rb.position = new Vector3(rb.position.x - blockSize, rb.position.y, rb.position.z);
        }
    }
    */
    // Smooth movement

    void FixedUpdate()
    {

        if (Input.GetKey("d"))
        {
            moveRight();
        }

        if (Input.GetKey("a"))
        {
            moveLeft();
        }

    }
    void moveRight()
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
    }

    void moveLeft()
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
    }
}
    
