using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour {
    public GameObject BrokenWall;
    // checks if a bullet collided with wall, if it did destroy the wall and create a broken wall
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Instantiate(BrokenWall,transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
