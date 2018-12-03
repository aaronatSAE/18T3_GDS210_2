using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpAmount : MonoBehaviour {
    public float speedUp;
    public float healthUp;
    public float activePowerUp = 1;
    [SerializeField] private float previousPowerUp;
    public Sprite speedBoost;
    public Sprite healthBoost;
    public Image powerUpImage;
    private Color gray;

    // makes the values of previousPowerUp equal to activePowerUp
    void Start () {
        previousPowerUp = activePowerUp;
        powerUpImage = GetComponent<Image>();
    }
	
	void Update () {
        //alternates between the 2 power ups when the player presses tab
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
        //updates the UI so that player can know what power is being used currently
		if(activePowerUp == 1)
        {
           powerUpImage.sprite = speedBoost;
            if(speedUp <= 0)
            {
            }
        }

        if (activePowerUp == 2)
        {
            powerUpImage.sprite = healthBoost;
        }
        previousPowerUp = activePowerUp;
    }
}
