using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {
    public float startingHealth;
    public float playerHealth;
    public Text healthUI;
    public Vector3 respawnPoint;
    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        respawnPoint = new Vector3(0, 1, 0);
        startingHealth = 10;
        playerHealth = startingHealth;
        healthUI = GameObject.Find("PlayerHealth").GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
        healthUI.text = "Health : " + playerHealth.ToString();
        if(playerHealth <= 0)
        {
            player.transform.position = respawnPoint;
            playerHealth = startingHealth;
        }
	}
}
