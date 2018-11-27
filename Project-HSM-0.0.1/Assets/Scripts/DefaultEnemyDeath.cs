﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DefaultEnemyDeath : MonoBehaviour {
    
    public float enemyHealth;
    [SerializeField] private float starterMelee;
    [SerializeField] private float starterTrapper;
    [SerializeField] private float starterRanged;
    //checks what enemy and sets health
    private void Start()
    {
        if(gameObject.tag == "MeleeEnemy")
        {
            starterMelee = 2;
            enemyHealth = starterMelee;
        }

        if (gameObject.tag == "TrapperEnemy")
        {
            starterTrapper = 1;
            enemyHealth = starterTrapper;
        }

        if (gameObject.tag == "RangedEnemy")
        {
            starterRanged = 1;
            enemyHealth = starterRanged;
        }
    }
    //checks if player weapon is colliding with enemy
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            enemyHealth -= 1;
        }
    }

    //destroy the enemy, if the enemy has no health
    private void Update()
    {
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
   
}
