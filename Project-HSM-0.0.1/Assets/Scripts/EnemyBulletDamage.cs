using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDamage : MonoBehaviour
{
    HealthDisplay healthDisplay;

    // Use this for initialization
    void Start () {
        healthDisplay = GameObject.Find("PlayerHealth").GetComponent<HealthDisplay>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            healthDisplay.playerHealth -= 1;
        }
    }
}
