using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DefaultEnemyAI : MonoBehaviour {
    NavMeshAgent nav;
    GameObject player;

	// finds the player and the NavMeshAgent attached to the gameobject
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        nav = GetComponent<NavMeshAgent>();

    }
	
	// Sets the destination of the NavMeshAgent to the player's location
	void Update () {
        nav.destination = player.transform.position;
    }
}
