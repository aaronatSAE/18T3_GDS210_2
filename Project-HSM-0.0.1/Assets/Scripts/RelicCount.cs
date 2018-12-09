using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelicCount : MonoBehaviour {

    public float relicLeft;
    GameObject portal;
    GameObject player;
    public Image relicLeftImage;

	// finds components and sets default values
	void Start () {
        relicLeft = 3;
        portal = Resources.Load<GameObject>("EndGame/PortalOut");
        player = GameObject.Find("Player");
        relicLeftImage = GetComponent<Image>();
	}
	
	void Update () {
        //checks if player has collected 3 relics
		if(relicLeft <= 0)
        {
            //spawn a portal and sure that the game doesnt infintely spawn portals
            relicLeftImage.enabled = false;
            Instantiate(portal, player.transform.position, player.transform.rotation);
            relicLeft = 1000;
        }
	}
}
