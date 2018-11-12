using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpUse : MonoBehaviour
{

    GameObject powerUp;
    GameObject player;
    GameObject playerHealth;
    PlayerMovement playerMovement;
    PowerUpAmount powerUpAmount;
    HealthDisplay healthDisplay;

    // Use this for initialization
    void Start()
    {
        playerHealth = GameObject.Find("PlayerHealth");
        healthDisplay = playerHealth.GetComponent<HealthDisplay>();
        powerUp = GameObject.Find("PowerUp");
        powerUpAmount = powerUp.GetComponent<PowerUpAmount>();
        player = GameObject.Find("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update () {
		if(powerUpAmount.activePowerUp == 1)
        {
            if (Input.GetKeyDown(KeyCode.Return) && powerUpAmount.speedUp >= 1)
            {
                StartCoroutine("SpeedIncrease");
                powerUpAmount.speedUp -= 1;
            }
        }

        if (powerUpAmount.activePowerUp == 2)
        {
            if (Input.GetKeyDown(KeyCode.Return) && powerUpAmount.healthUp >= 1)
            {
                healthDisplay.playerHealth = 10;
                powerUpAmount.healthUp -= 1;
            }
        }
    }


    IEnumerator SpeedIncrease()
    {
        float starterSpeed;
        starterSpeed = playerMovement.movespeed;
        playerMovement.movespeed = 10;
        yield return new WaitForSeconds(15f);
        playerMovement.movespeed = starterSpeed;
    }
}
