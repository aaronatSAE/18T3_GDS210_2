﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {
    public Image healthUIImage;
    [SerializeField] private GameObject respawnPoint;
    private GameObject player;

	// sets starting health and find co
	void Start () {
        player = GameObject.Find("Player");
        healthUIImage = GameObject.Find("PlayerHealth").GetComponent<Image>();
	}
	
	// updates the health values on the UI
	void Update () {
        //checks if the player's health is less then or equal to 0,
        //if it is then send the player back to spawn and reset health
        if (healthUIImage.fillAmount <= 0)
        {
            if (respawnPoint == null)
                return;
            player.transform.position = respawnPoint.transform.position;
            healthUIImage.fillAmount = 1f;
        }
	}
}
