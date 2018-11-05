using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {

    public float playerHealth;
    public Text healthUI;

	// Use this for initialization
	void Start () {
        playerHealth = 10;
        healthUI = GameObject.Find("PlayerHealth").GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
        healthUI.text = "Health : " + playerHealth.ToString();
        if(playerHealth <= 0)
        {
            print("player dead");
        }
	}
}
