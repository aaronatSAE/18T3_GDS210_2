using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDamage : MonoBehaviour
{
    HealthDisplay healthDisplay;
    [SerializeField] private float bulletDamage = 1;

    // finds the health of the player
    void Start () {
        healthDisplay = GameObject.Find("PlayerHealth").GetComponent<HealthDisplay>();
    }

    // if the gameobject collides with the player remove health from the player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            healthDisplay.playerHealth -= bulletDamage;
            healthDisplay.healthUIImage.fillAmount -= 0.1f;
        }
    }
}
