using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAnimation : MonoBehaviour {
    private Animator animator;
    Image health;
    public bool trigger;
    
    //retrieves components
    void Start()
    {
        health = GameObject.Find("PlayerHealth").GetComponent<Image>();
        animator = GetComponent<Animator>();
    }

    //changes inputs from the player to animations
    void Update()
    {
        if(health.fillAmount <= 0 && trigger == false)
        {
            animator.SetTrigger("IsDead");
            animator.SetBool("Respawn", false);
            trigger = true;
        }
        if(health.fillAmount == 1f)
        {
            animator.SetBool("Respawn", true);
            trigger = false;
        }
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
