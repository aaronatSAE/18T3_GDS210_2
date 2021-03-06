﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DefaultEnemyDeath : MonoBehaviour {
    
    public float enemyHealth;
    private Animator anim;
    AudioSource damageAudio;
    [SerializeField] private float starterMelee;
    [SerializeField] private float starterTrapper;
    [SerializeField] private float starterRanged;
    [SerializeField] private bool ifDead;
    [SerializeField] private MonoBehaviour[] scripts;
    [SerializeField] private CapsuleCollider cap;
    private float previousHealth;

    //checks what enemy and sets health
    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        scripts = gameObject.GetComponents<MonoBehaviour>();
        cap = gameObject.GetComponent<CapsuleCollider>();
        damageAudio = gameObject.GetComponent<AudioSource>();
        if (gameObject.tag == "MeleeEnemy")
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
        previousHealth = enemyHealth;
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
        if(enemyHealth <= 0 && enemyHealth >= -1000)
        {
            StartCoroutine("Death");
            enemyHealth = -1000;
        }
        //if the health of the enemy decreased play audio
        if(previousHealth != enemyHealth)
        {
            damageAudio.Play(0);
        }
    }

    IEnumerator Death()
    {
        //disable capsule collider
        cap.enabled = false;
        //finds every script on the gameobject and disables it
        foreach(MonoBehaviour script in scripts)
        {
            script.enabled = false;
        }
        //starts death animation
        anim.SetTrigger("IsDead");
        //wait and then destroy game object
        yield return new WaitForSeconds(6.0f);
        Destroy(gameObject);
    }
}
