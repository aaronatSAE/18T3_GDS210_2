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
    public bool movement;

    private void Start()
    {
        movement = true;
    }

    // Basic player movement
    void Update () {
        x = Input.GetAxis("Horizontal") * Time.deltaTime * turnrate;
        if (movement == true)
        {
            z = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        }
        if(movement == false)
        {
            z = 0;
        }
        transform.Translate(0, 0, z);
        transform.Rotate(0, x, 0);
        if(x == 1)
        {
            transform.Rotate(0, 90, 0);
        }
	}
}
