using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DefaultEnemyDeath : MonoBehaviour {
    
    public float enemyHealth;
    public float starterMelee;
    public float starterTrapper;
    public float starterRanged;

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            enemyHealth -= 1;
        }
    }
    

    private void Update()
    {
        if(enemyHealth <= 0)
        {
            if (gameObject.tag == "MeleeEnemy")
            {
                StartCoroutine("Melee");
                enemyHealth = starterMelee;
            }

            if (gameObject.tag == "RangedEnemy")
            {
                StartCoroutine("Range");
                enemyHealth = starterRanged;
            }

            if (gameObject.tag == "TrapperEnemy")
            {
                StartCoroutine("Trap");
                enemyHealth = starterTrapper;
            }
        }
    }

    IEnumerator Melee()
    {
        MeleeEnemyAttack meleeComponent;
        CapsuleCollider colide;
        NavMeshAgent nav;
        DefaultEnemyAI defaultEnemyAI;
        nav = GetComponent<NavMeshAgent>();
        meleeComponent = GetComponent<MeleeEnemyAttack>();
        colide = GetComponent<CapsuleCollider>();
        defaultEnemyAI = GetComponent<DefaultEnemyAI>();
        meleeComponent.enabled = false;
        colide.enabled = false;
        nav.enabled = false;
        defaultEnemyAI.enabled = false;
        yield return new WaitForSeconds(10f);
        meleeComponent.enabled = true;
        colide.enabled = true;
        nav.enabled = true;
        defaultEnemyAI.enabled = true;
    }

    IEnumerator Range()
    {
        RangedEnemyAttack rangedComponent;
        CapsuleCollider colide;
        NavMeshAgent nav;
        DefaultEnemyAI defaultEnemyAI;
        nav = GetComponent<NavMeshAgent>();
        rangedComponent = GetComponent<RangedEnemyAttack>();
        colide = GetComponent<CapsuleCollider>();
        defaultEnemyAI = GetComponent<DefaultEnemyAI>();
        rangedComponent.enabled = false;
        colide.enabled = false;
        nav.enabled = false;
        defaultEnemyAI.enabled = false;
        yield return new WaitForSeconds(10f);
        rangedComponent.enabled = true;
        colide.enabled = true;
        nav.enabled = true;
        defaultEnemyAI.enabled = true;
    }

    IEnumerator Trap()
    {
        TrapEnemy trapComponent;
        CapsuleCollider colide;
        NavMeshAgent nav;
        DefaultEnemyAI defaultEnemyAI;
        nav = GetComponent<NavMeshAgent>();
        trapComponent = GetComponent<TrapEnemy>();
        colide = GetComponent<CapsuleCollider>();
        defaultEnemyAI = GetComponent<DefaultEnemyAI>();
        trapComponent.enabled = false;
        colide.enabled = false;
        nav.enabled = false;
        defaultEnemyAI.enabled = false;
        yield return new WaitForSeconds(10f);
        trapComponent.enabled = true;
        colide.enabled = true;
        nav.enabled = true;
        defaultEnemyAI.enabled = true;
    }
}
