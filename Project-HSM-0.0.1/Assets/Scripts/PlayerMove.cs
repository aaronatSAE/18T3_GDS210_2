using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float x;
    float z;
    Rigidbody rb;
    public bool movement;
    CharacterController chara;
    Vector3 direction;
    float speed;

    private void Start()
    {
        chara = GetComponent<CharacterController>();
        movement = true;
        speed = 5;
    }

    // Basic player movement
    void Update()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        direction = transform.TransformDirection(direction);
        direction = direction * speed;
        print(direction);
        if (movement == true)
        {
            if (direction.x >= 0.1f || direction.y >= 0.1)
            {
                chara.Move(direction * Time.deltaTime);
            }
        }
        if (movement == false)
        {
            z = 0;
            x = 0;
        }
    }
}
