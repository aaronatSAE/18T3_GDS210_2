using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicPickUp : MonoBehaviour {

    GameObject relicLeft;
    RelicCount relicCount;

	// Use this for initialization
	void Start () {
        relicLeft = GameObject.Find("RelicLeft");
        relicCount = relicLeft.GetComponent<RelicCount>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        relicCount.relicLeft -= 1;
        relicCount.relicLeftImage.fillAmount -= 0.345f;
    }
}
