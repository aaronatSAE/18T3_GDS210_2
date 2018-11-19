using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
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
    void Update()
    {
        z = Input.GetAxis("Vertical");
        if (z > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (z < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        x = Input.GetAxis("Horizontal");
        if (x < 0)
        {
            transform.eulerAngles = new Vector3(0, -90, 0);
        }
        if (x > 0)
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
        }
        if (movement == true)
        {
            if (z >= 0.5f || z <= -0.5f || x >= 0.5f || x <= -0.5f)
            {
                transform.Translate(0, 0, 0.1f);
            }
            //if (z != 0 || x != 0)
            //{
            //    transform.Translate(0, 0, 0.1f);
            //}
        }
        if (movement == false)
        {
            z = 0;
            x = 0;
        }
        if (x == 1)
        {
        }
    }
}
