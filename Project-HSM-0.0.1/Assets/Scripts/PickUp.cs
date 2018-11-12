using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour {

    GameObject powerUp;
    PowerUpAmount powerUpAmount;
    Text speedUpText;

	// Use this for initialization
	void Start () {
        powerUp = GameObject.Find("PowerUp");
        powerUpAmount = powerUp.GetComponent<PowerUpAmount>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if(gameObject.tag == "SpeedUp")
        {
            powerUpAmount.speedUp += 1;
        }

        if (gameObject.tag == "HealthUp")
        {
            powerUpAmount.healthUp += 1;
        }
    }
    
}
