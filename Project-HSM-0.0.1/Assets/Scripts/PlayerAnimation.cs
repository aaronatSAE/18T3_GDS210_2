using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

    //Step Variable for animator
    private Animator animator;

    //Use this for Initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    //changes inputs from the player to animations
    void Update()
    {
        if(Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("IsMoving", true);
        }
        else if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("IsMoving", true);
        }
        else if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("IsMoving", true);
        }
        else if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("IsMoving", true);
        }
        else
        {
            animator.SetBool("IsMoving", false);            
        }
    }
}
