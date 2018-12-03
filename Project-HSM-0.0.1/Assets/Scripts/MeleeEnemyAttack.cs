using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeEnemyAttack : MonoBehaviour
{
    private GameObject player;
    private HealthDisplay healthDisplay;
    private Animator anim;
    [SerializeField] private float attackDelay = 2.5f;
    [SerializeField] private float attackRange = 1.4f;
    [SerializeField] private float attackDamage = 1f;
    [SerializeField] private float animationDelay = 0.9f;

    // finds the player and the health display which is where the player health is stored
    void Start () {
        anim = gameObject.GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        healthDisplay = GameObject.Find("PlayerHealth").GetComponent<HealthDisplay>();
    }
	
	// damages player if the player stays in range for a set amount of time
	void Update () {
        if(Vector3.Distance(player.transform.position, transform.position) <= attackRange)
        {
            if(attackDelay <= animationDelay)
            {
                anim.SetTrigger("IsAttacking");
            }
            //countdown before attacking
            attackDelay -= Time.deltaTime;
            if(attackDelay < 0)
            {
                //once timer is over the player takes damage
                healthDisplay.healthUIImage.fillAmount -= 0.3f;
                attackDelay = 1.4f;
            }
        }
        //when the player leaves the attack range of the enemy then reset attack timer
        else
        {
            attackDelay = 1.4f;
        }
	}
}
