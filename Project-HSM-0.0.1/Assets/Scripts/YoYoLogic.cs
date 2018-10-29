using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoYoLogic : MonoBehaviour {
    public GameObject player;
    public Vector3 yoyoPosition;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}

    private void Update()
    {
        if(Vector3.Distance(player.transform.position, transform.position) < 1.5)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Wall")
        {
            transform.position = Vector3.Lerp(transform.position, player.transform.position, 0.01f);
        }
    }
}
