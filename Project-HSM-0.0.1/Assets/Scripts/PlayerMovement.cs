using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed= 6;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float gravityMulti = 20;
    public bool movement = true;
    public float movespeed = 1;
    private Vector3 gravity;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    //finds the player controller attached to the gameobject
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //make sure the player is on the ground at all times
        gravity.y = gravity.y - (gravityMulti * Time.deltaTime);
        controller.Move(gravity * Time.deltaTime);
        //checks if the player is on the ground
        if (controller.isGrounded)
        {
            //rotate the player according to how the player is moving
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            if (moveDirection != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(moveDirection);
            }
            moveDirection = moveDirection * speed;
            //move the player
            if(movement == true)
            {
                transform.Translate(moveDirection * Time.deltaTime * movespeed, Space.World);
            }
        }
    }
}