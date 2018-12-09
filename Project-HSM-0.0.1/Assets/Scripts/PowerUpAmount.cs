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
    private Color grayScale;

    // makes the values of previousPowerUp equal to activePowerUp
    void Start () {
        previousPowerUp = activePowerUp;
        powerUpImage = GetComponent<Image>();
        grayScale = new Color(70, 70, 70, 255);
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
            //sets the sprite and changes colour according to the amount of power ups avaliable
           powerUpImage.sprite = speedBoost;
            if(speedUp <= 0)
            {
                powerUpImage.color = new Color32(70, 70, 70, 255);
            }
            else
            {
                powerUpImage.color = new Color32(255, 255, 255, 255);
            }
        }

        if (activePowerUp == 2)
        {
            //sets the sprite and changes colour according to the amount of power ups avaliable
            powerUpImage.sprite = healthBoost;
            if (healthUp <= 0)
            {
                powerUpImage.color = new Color32(70, 70, 70, 255);
            }
            else
            {
                powerUpImage.color = new Color32(255, 255, 255, 255);
            }
        }
        previousPowerUp = activePowerUp;
    }
}
