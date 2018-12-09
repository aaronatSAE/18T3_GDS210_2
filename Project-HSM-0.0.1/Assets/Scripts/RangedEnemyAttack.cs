using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RangedEnemyAttack : MonoBehaviour {
    RaycastHit hit;
    GameObject player;
    NavMeshAgent nav;
    GameObject enemyBullet;
    Animator anim;
    [SerializeField] private float attackDistance = 5f;
    GameObject bulletSpawn;
    [SerializeField] private bool shooting;
    
    // find components as well as setting values
    void Start () {
        anim = gameObject.GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        nav = GetComponent<NavMeshAgent>();
        enemyBullet = Resources.Load<GameObject>("Enemy/EnemyBullet");
        bulletSpawn = GameObject.Find("EnemyBulletSpawn");
        shooting = false;
	}
	
	void Update () {
        //checks if player is in attack range
		if(Vector3.Distance(player.transform.position, transform.position) < attackDistance)
        {
            //creates a ray from the enemy to player
            if(Physics.Raycast(transform.position, player.transform.position - transform.position, out hit, attackDistance, 1))
            {
                //if the ray hits the player
                if (hit.collider.tag == "Player")
                {
                    //if the enemy hasn't recently shot
                    if(shooting == false)
                    {
                        //start shoot coroutine
                        StartCoroutine("Shoot");
                    }
                }
            }
        }
	}

    IEnumerator Shoot()
    {
        shooting = true;
        nav.isStopped = true;
        anim.SetTrigger("IsThrowing");
        yield return new WaitForSeconds(1);
        Instantiate(enemyBullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        nav.isStopped = false;
        yield return new WaitForSeconds(1);
        shooting = false;
    }
}
