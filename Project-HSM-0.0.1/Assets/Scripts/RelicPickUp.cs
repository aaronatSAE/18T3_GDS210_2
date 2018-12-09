using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicPickUp : MonoBehaviour {

    GameObject relicLeft;
    RelicCount relicCount;

    //retrieves components needed
	void Start () {
        relicLeft = GameObject.Find("RelicLeft");
        relicCount = relicLeft.GetComponent<RelicCount>();
	}

    //checks if the player collided with the gameobject
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    //when the relic is destroyed remove 1 from the relic count
    private void OnDestroy()
    {
        relicCount.relicLeft -= 1;
        relicCount.relicLeftImage.fillAmount -= 0.345f;
    }
}
