using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TrapEnemy : MonoBehaviour
{
    GameObject player;
    CapsuleCollider capsuleCollider;
    NavMeshAgent nav;
    PlayerMovement playerMovement;
    Rigidbody rigidPlayer;
    Animator animator;
    AudioSource trapMusic;
    [SerializeField] private float trapLength;
    [SerializeField] private float trapTimer;
    [SerializeField] private float respawnLength;
    [SerializeField] private float respawnTimer;
    [SerializeField] private bool disabled;

    // Find component required for the script and sets some default values
    void Start()
    {
        animator = GameObject.Find("PlayerGraphics").GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        capsuleCollider = GetComponent<CapsuleCollider>();
        playerMovement = player.GetComponent<PlayerMovement>();
        nav = GetComponent<NavMeshAgent>();
        trapMusic = GetComponent<AudioSource>();
        trapLength = 5f;
        trapTimer = trapLength;
        respawnLength = 10f;
        respawnTimer = respawnLength;
        disabled = false;
    }

    void Update()
    {
        //checks if player is within range of enemy
        if (Vector3.Distance(player.transform.position, transform.position) <= 1.5f)
        {
            //checks if the enemy recently trapped the player
            if (disabled == false)
            {
                //if not trap the player and make the player dance
                trapTimer = trapLength;
                playerMovement.movement = false;
                capsuleCollider.enabled = false;
                nav.isStopped = true;
                disabled = true;
                animator.SetBool("IsDancing", true);
                trapMusic.Play(0);
            }
            //when the time reaches zero enable movement for the player and end the dancing
            if (trapTimer <= 0 && disabled == true)
            {
                playerMovement.movement = true;
                animator.SetBool("IsDancing", false);
            }
        }

        //if the player some how leaves trapping range
        if (Vector3.Distance(player.transform.position, transform.position) >= 2.5f)
        {
            //check if the respawn timer for the trapper enemy is at 0
            if (respawnTimer <= 0)
            {
                //enable trapper enemy
                capsuleCollider.enabled = true;
                nav.isStopped = false;
            }
            //enable player movement
            playerMovement.movement = true;
            disabled = false;
            animator.SetBool("IsDancing", false);
        }

        //countdown for timer
        respawnTimer -= Time.deltaTime;
        trapTimer -= Time.deltaTime;

        //check if respawn timer is at 0 and if the player has recently been trapped
        if (respawnTimer <= 0 && disabled == true)
        {
            //enable the trapper
            nav.isStopped = false;
            capsuleCollider.enabled = true;
            respawnTimer = respawnLength;
            trapTimer = trapLength;
            disabled = false;
            animator.SetBool("IsDancing", false);
        }
    }
}
