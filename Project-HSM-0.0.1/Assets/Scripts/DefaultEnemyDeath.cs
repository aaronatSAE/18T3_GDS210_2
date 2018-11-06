using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultEnemyDeath : MonoBehaviour {

    public float respawnTimer;
    public float enemyHealth;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Bullet")
        {
            enemyHealth -= 1;
        }
    }

    private void Update()
    {
        if(respawnTimer <= 0)
        {

        }
    }
}
