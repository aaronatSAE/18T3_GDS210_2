using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeEnemyAttack : MonoBehaviour
{
    GameObject player;
    float attackDelay;
    HealthDisplay healthDisplay;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        healthDisplay = GameObject.Find("PlayerHealth").GetComponent<HealthDisplay>();
        attackDelay = 2f;
    }
	
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(player.transform.position, transform.position) <= 1.5f)
        {
            attackDelay -= Time.deltaTime;
            if(attackDelay < 0)
            {
                healthDisplay.playerHealth -= 1;
                attackDelay = 2f;
            }
        }
        if (Vector3.Distance(player.transform.position, transform.position) > 1.5f)
        {
            attackDelay = 2f;
        }
	}
}
