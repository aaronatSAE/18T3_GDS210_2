using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpAmount : MonoBehaviour {
    public float speedUp;
    public float healthUp;
    public float activePowerUp = 1;
    [SerializeField] private float previousPowerUp;

	// makes the values of previousPowerUp equal to activePowerUp
	void Start () {
        previousPowerUp = activePowerUp;
	}
	
	void Update () {
        //alternates between the 2 power ups when the player presses tab
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            print("run");
            if(previousPowerUp != 2 && activePowerUp == 1)
            {
                activePowerUp += 1;
            }
            
            if(previousPowerUp != 1 && activePowerUp == 2)
            {
                activePowerUp -= 1;
            }
        }
        //updates the UI so that player can know what power is being used currently
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
