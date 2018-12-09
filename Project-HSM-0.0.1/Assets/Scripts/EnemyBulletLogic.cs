using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletLogic : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float bulletspeed = 300;

    // finds rigidbody component attached to the gameobject
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // constantly moving the bullet forward
    void Update()
    {
        rb.AddForce(transform.forward * bulletspeed);
    }
    //destory bullet on collision
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
