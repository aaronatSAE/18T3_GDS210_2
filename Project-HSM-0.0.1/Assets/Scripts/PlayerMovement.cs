using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public float gravityMulti;
    public bool movement;
    public float movespeed;
    Vector3 gravity;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    void Start()
    {
        movespeed = 1;
        movement = true; 
        controller = GetComponent<CharacterController>();
        speed = 6;
        gravityMulti = 20;
       
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            transform.rotation = Quaternion.LookRotation(moveDirection);
            moveDirection = moveDirection * speed;
            if(movement == true)
            {
                transform.Translate(moveDirection * Time.deltaTime * movespeed, Space.World);
            }
        }
        
        gravity.y = gravity.y - (gravityMulti * Time.deltaTime);
        controller.Move(gravity * Time.deltaTime);
    }
}