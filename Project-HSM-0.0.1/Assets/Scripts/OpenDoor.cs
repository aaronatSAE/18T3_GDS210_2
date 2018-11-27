using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {
    GameObject player;
    private float distanceFromPlayer;
    [SerializeField] private float openDistance = 3;

	// finds player
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// destory the gameobject if the player is within range and presses the interact button
	void Update () {
        distanceFromPlayer = Vector3.Distance(player.transform.position, transform.position);
		if(distanceFromPlayer <= openDistance && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
        }
	}
}
