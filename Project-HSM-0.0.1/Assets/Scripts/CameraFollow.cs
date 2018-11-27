using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    GameObject player;
    public float camHeight = 3;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x,player.transform.position.y + camHeight, player.transform.position.z);
	}
}
