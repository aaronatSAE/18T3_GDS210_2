using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpAmount : MonoBehaviour {
    public float speedUp;
    public float healthUp;
    public float activePowerUp;
    public float previousPowerUp;

	// Use this for initialization
	void Start () {
        speedUp = 0;
        healthUp = 0;
        activePowerUp = 1;
        previousPowerUp = activePowerUp;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if(previousPowerUp != 2 && activePowerUp == 1)
            {
                activePowerUp += 1;
            }
            
            if(previousPowerUp != 1 && activePowerUp == 2)
            {
                activePowerUp -= 1;
            }
        }

		if(activePowerUp == 1)
        {
            Text speedText;
            speedText = gameObject.GetComponent<Text>();
            speedText.text = "Speed : " + speedUp.ToString();
        }

        if (activePowerUp == 2)
        {
            Text healthText;
            healthText = gameObject.GetComponent<Text>();
            healthText.text = "Health : " + healthUp.ToString();
        }
        previousPowerUp = activePowerUp;
    }
}
