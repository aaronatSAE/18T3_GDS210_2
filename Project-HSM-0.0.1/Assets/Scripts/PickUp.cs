using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour {
    
    private PowerUpAmount powerUpAmount;

	// find the power-up component
	void Start () {
        powerUpAmount = GameObject.Find("PowerUp").GetComponent<PowerUpAmount>();
	}
    //checks when the gameobject collides with the player
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //when the gameobject collides with the player destroy the gameobject
            Destroy(gameObject);
        }
    }
    //when the gameobject is destroy add power-up ammo corresponding to the power-up picked up
    private void OnDestroy()
    {
        //checks the tag of the gameobject so ammo can be correctly allocated
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
