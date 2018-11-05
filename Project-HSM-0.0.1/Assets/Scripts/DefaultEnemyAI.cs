using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DefaultEnemyAI : MonoBehaviour {
    NavMeshAgent nav;
    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        nav = GetComponent<NavMeshAgent>();

    }
	
	// Update is called once per frame
	void Update () {
        nav.destination = player.transform.position;
    }
}
