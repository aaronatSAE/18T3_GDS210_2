﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {
    [SerializeField] private float startingHealth = 10;
    public float playerHealth;
    private Text healthUI;
    [SerializeField] private GameObject respawnPoint;
    private GameObject player;

	// sets starting health and find co
	void Start () {
        player = GameObject.Find("Player");
        playerHealth = startingHealth;
        healthUI = GameObject.Find("PlayerHealth").GetComponent<Text>();

	}
	
	// updates the health values on the UI
	void Update () {
        healthUI.text = "Health : " + playerHealth.ToString();
        //checks if the player's health is less then or equal to 0,
        //if it is then send the player back to spawn and reset health
        if(playerHealth <= 0)
        {
            if (respawnPoint == null)
                return;
            player.transform.position = respawnPoint.transform.position;
            playerHealth = startingHealth;
        }
	}
}
