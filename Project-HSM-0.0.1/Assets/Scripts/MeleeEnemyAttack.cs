using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeEnemyAttack : MonoBehaviour
{
    private GameObject player;
    private HealthDisplay healthDisplay;
    [SerializeField] private float attackDelay = 2f;
    [SerializeField] private float attackRange = 2.5f;
    [SerializeField] private float attackDamage = 1f;

    // finds the player and the health display which is where the player health is stored
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        healthDisplay = GameObject.Find("PlayerHealth").GetComponent<HealthDisplay>();
    }
	
	// damages player if the player stays in range for a set amount of time
	void Update () {
        if(Vector3.Distance(player.transform.position, transform.position) <= attackRange)
        {
            //countdown before attacking
            attackDelay -= Time.deltaTime;
            if(attackDelay < 0)
            {
                //once timer is over the player takes damage
                healthDisplay.playerHealth -= attackDamage;
                attackDelay = 2f;
            }
        }
        //when the player leaves the attack range of the enemy then reset attack timer
        else
        {
            attackDelay = 2f;
        }
	}
}
