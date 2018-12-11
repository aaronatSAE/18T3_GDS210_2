using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {
    public Image healthUIImage;
    [SerializeField] private GameObject respawnPoint;
    private GameObject player;
    PlayerMovement move;
    [SerializeField] private bool ran;

	// sets starting health and find co
	void Start () {
        player = GameObject.Find("Player");
        move = player.GetComponent<PlayerMovement>();
        healthUIImage = GameObject.Find("PlayerHealth").GetComponent<Image>();
	}
	
	// updates the health values on the UI
	void LateUpdate () {
        //checks if the player's health is less then or equal to 0,
        //if it is then send the player back to spawn and reset health
        if (healthUIImage.fillAmount <= 0)
        {
            if (respawnPoint == null)
                return;
            if(ran == false)
            {
                StartCoroutine("Respawn");
                ran = true;
            }
        }
	}

    IEnumerator Respawn()
    {
        foreach(Transform child in player.transform)
        {
            if(child.name != "PlayerGraphics")
            {
                child.gameObject.SetActive(false);
            }
        }
        move.enabled = false;
        yield return new WaitForSeconds(6);
        healthUIImage.fillAmount = 1f;
        foreach (Transform child in player.transform)
        {
            child.gameObject.SetActive(true);
        }
        player.transform.position = respawnPoint.transform.position;
        move.enabled = true;
        ran = false;
    }
}