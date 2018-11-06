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
    public float trapLength;
    public float trapTimer;
    public float respawnLength;
    public float respawnTimer;
    public bool disabled;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        capsuleCollider = GetComponent<CapsuleCollider>();
        playerMovement = player.GetComponent<PlayerMovement>();
        nav = GetComponent<NavMeshAgent>();
        trapLength = 5f;
        trapTimer = trapLength;
        respawnLength = 10f;
        respawnTimer = respawnLength;
        disabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) <= 1.5f)
        {
            if (disabled == false)
            {
                playerMovement.movement = false;
                capsuleCollider.enabled = false;
                nav.isStopped = true;
                disabled = true;
            }
            if (trapTimer <= 0 && disabled == true)
            {
                playerMovement.movement = true;
            }
        }
        
        respawnTimer -= Time.deltaTime;
        trapTimer -= Time.deltaTime;

        if (respawnTimer <= 0 && disabled == true)
        {
            nav.isStopped = false;
            capsuleCollider.enabled = true;
            respawnTimer = respawnLength;
            trapTimer = trapLength;
            disabled = false;
        }
    }
}
