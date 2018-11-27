using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RangedEnemyAttack : MonoBehaviour {
    RaycastHit hit;
    GameObject player;
    NavMeshAgent nav;
    GameObject enemyBullet;
    [SerializeField] private float attackDistance = 5f;
    GameObject bulletSpawn;
    public bool shooting;
    
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        nav = GetComponent<NavMeshAgent>();
        enemyBullet = Resources.Load<GameObject>("Enemy/EnemyBullet");
        bulletSpawn = GameObject.Find("EnemyBulletSpawn");
        shooting = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(player.transform.position, transform.position) < attackDistance)
        {
            if(Physics.Raycast(transform.position, player.transform.position - transform.position, out hit, attackDistance, 1))
            {
                Debug.DrawRay(transform.position, player.transform.position - transform.position * attackDistance, Color.black);

                if (hit.collider.tag == "Player")
                {
                    if(shooting == false)
                    {
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
        yield return new WaitForSeconds(1);
        Instantiate(enemyBullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        nav.isStopped = false;
        yield return new WaitForSeconds(1);
        shooting = false;
    }
}
