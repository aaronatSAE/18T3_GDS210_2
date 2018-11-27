using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {
    GameObject player;
    private float distanceFromPlayer;
    [SerializeField] private float openDistance = 3;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        distanceFromPlayer = Vector3.Distance(player.transform.position, transform.position);
		if(distanceFromPlayer <= openDistance && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
        }
	}
}
