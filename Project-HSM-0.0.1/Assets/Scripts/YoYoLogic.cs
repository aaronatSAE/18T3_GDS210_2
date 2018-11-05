using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoYoLogic : MonoBehaviour {
    public GameObject player;
    public Vector3 yoyoPosition;

	// searches for gameobjects
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}

    //checks distance Yo-Yo is from player
    private void Update()
    {
        if(Vector3.Distance(player.transform.position, transform.position) < 1.5)
        {
            Destroy(gameObject);
        }
    }

    // checks if the Yo-Yo is colliding with a wall, if it is the Yo-Yo will slow move towards the player
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Wall")
        {
            transform.position = Vector3.Lerp(transform.position, player.transform.position, 0.01f);
        }
    }
}
