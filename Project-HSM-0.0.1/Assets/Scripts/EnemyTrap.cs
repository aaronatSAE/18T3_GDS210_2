using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTrap : MonoBehaviour
{
    GameObject player;
    HealthDisplay healthDisplay;
    CapsuleCollider capsuleCollider;
    NavMeshAgent nav;
    PlayerMovement playerMovement;
    float trapLength;
    float trapTimer;
    float respawnLength;
    float respawnTimer;
    bool disabled;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        healthDisplay = GameObject.Find("PlayerHealth").GetComponent<HealthDisplay>();
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
                playerMovement.enabled = false;
                capsuleCollider.enabled = false;
                nav.isStopped = true;
                disabled = true;
            }
            trapTimer -= Time.deltaTime;
            respawnTimer -= Time.deltaTime;
            if (trapTimer <= 0)
            {
                playerMovement.enabled = true;
                trapTimer = trapLength;
                print("run");
            }
            if (respawnTimer <= 0)
            {
                nav.isStopped = false;
                capsuleCollider.enabled = true;
                respawnTimer = respawnLength;
                disabled = false;
            }
        }
    }
}
