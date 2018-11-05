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
	
	// constantly moving the bullet forward
	void Update () {
        rb.AddForce(transform.forward * bulletspeed);
	}
    //destory bullet on collision
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
