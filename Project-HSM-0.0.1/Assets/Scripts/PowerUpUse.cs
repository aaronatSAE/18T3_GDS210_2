using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpUse : MonoBehaviour
{
    [SerializeField] private float moveSpeedUp = 2f;
    [SerializeField] private float speedUpDuration = 15f;
    PlayerMovement playerMovement;
    PowerUpAmount powerUpAmount;
    HealthDisplay healthDisplay;

    // find components needed
    void Start()
    {
        healthDisplay = GameObject.Find("PlayerHealth").GetComponent<HealthDisplay>();
        powerUpAmount = GameObject.Find("PowerUp").GetComponent<PowerUpAmount>();
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }
    
    void Update () {
        //checks what the active power up is
		if(powerUpAmount.activePowerUp == 1)
        {
            Debug.Log("powerup");
            //when the player presses the enter key and there is ammo for the correponding power up use it
            if (Input.GetKeyDown(KeyCode.Return) && powerUpAmount.speedUp >= 1)
            {
                //run a coroutine which increase the speed of the player before removing 1 ammo of the power up
                StartCoroutine("SpeedIncrease");
                powerUpAmount.speedUp -= 1;
            }
        }

        if (powerUpAmount.activePowerUp == 2)
        {
            if (Input.GetKeyDown(KeyCode.Return) && powerUpAmount.healthUp >= 1)
            {
                //sets the player's health to full and then remove 1 ammo of the power up
                healthDisplay.playerHealth = 10;
                powerUpAmount.healthUp -= 1;
            }
        }
    }


    IEnumerator SpeedIncrease()
    {
        //retrieves the movespeed value
        float starterSpeed;
        starterSpeed = playerMovement.movespeed;
        //increase the movespeed
        playerMovement.movespeed = moveSpeedUp;
        //after a set amount of time reset the speed
        yield return new WaitForSeconds(speedUpDuration);
        playerMovement.movespeed = starterSpeed;
    }
}
