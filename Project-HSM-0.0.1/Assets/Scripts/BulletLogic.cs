using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour {
    Rigidbody rb;
    public float bulletspeed = 300;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.forward * bulletspeed);
	}
}
