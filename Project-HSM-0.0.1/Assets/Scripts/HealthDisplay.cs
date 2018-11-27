using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {
    [SerializeField] private float startingHealth;
    public float playerHealth;
    private Text healthUI;
    [SerializeField] private GameObject respawnPoint;
    private GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        startingHealth = 10;
        playerHealth = startingHealth;
        healthUI = GameObject.Find("PlayerHealth").GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
        healthUI.text = "Health : " + playerHealth.ToString();
        if(playerHealth <= 0)
        {
            player.transform.position = respawnPoint.transform.position;
            playerHealth = startingHealth;
        }
	}
}
