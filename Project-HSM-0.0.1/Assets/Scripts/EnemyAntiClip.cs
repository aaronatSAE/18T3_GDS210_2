using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAntiClip : MonoBehaviour {

    [SerializeField] private GameObject centre;
    [SerializeField] private float moveSpeed;
	
    //sets a location as the centre which the enemy will be pushed towards
	void Update () {
        centre = GameObject.FindGameObjectWithTag("Centre");
        //if the enemy is floating push the enemy down
		if(transform.position.y >= 1)
        {
            Vector3 temp = transform.position;
            transform.position.Set(temp.x, 1, temp.z);
        }
	}
    //push enemies to the centre
    private void OnCollisionStay(Collision collision)
    {
        transform.position = Vector3.MoveTowards(transform.position, centre.transform.position, moveSpeed);
    }
}
