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

    void Update()
    {
        if(Input.GetKey("w"))
        {
            animator.SetBool("IsMoving", true);
        }
        else if (Input.GetKey("a"))
        {
            animator.SetBool("IsMoving", true);
        }
        else if (Input.GetKey("s"))
        {
            animator.SetBool("IsMoving", true);
        }
        else if (Input.GetKey("d"))
        {
            animator.SetBool("IsMoving", true);
        }
        else
        {
            animator.SetBool("IsMoving", false);            
        }
    }
}
