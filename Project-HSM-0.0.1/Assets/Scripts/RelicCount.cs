﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelicCount : MonoBehaviour {

    public float relicLeft;
    GameObject portal;
    GameObject player;
    public Image relicLeftImage;

	// Use this for initialization
	void Start () {
        relicLeft = 3;
        portal = Resources.Load<GameObject>("EndGame/PortalOut");
        player = GameObject.Find("Player");
        relicLeftImage = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        //relicLeftCount.text = "Relic Left : " + relicLeft.ToString();
       
		if(relicLeft <= 0)
        {
            relicLeftImage.enabled = false;
            Instantiate(portal, player.transform.position, player.transform.rotation);
            relicLeft = 1000;
        }
	}
}
