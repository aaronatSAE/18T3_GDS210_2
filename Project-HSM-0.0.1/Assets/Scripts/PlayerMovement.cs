using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    float x;
    float z;
    public float movespeed = 5;
    public float turnrate;
    public float jumpheight = 10;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        x = Input.GetAxis("Horizontal") * Time.deltaTime * turnrate;
        z = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(0, 0, z);
        transform.Rotate(0, x, 0);
        if(Input.GetKeyDown("space"))
        {
            rb.AddForce(transform.up * jumpheight);
        }
        if( x == 1)
        {
            transform.Rotate(0, 90, 0);
        }
	}
}
