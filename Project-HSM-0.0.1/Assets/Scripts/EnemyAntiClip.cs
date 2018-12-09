using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAntiClip : MonoBehaviour {

    [SerializeField] private GameObject centre;
    [SerializeField] private float moveSpeed;
	
	// Update is called once per frame
	void Update () {
        centre = GameObject.FindGameObjectWithTag("Centre");
		if(transform.position.y >= 1)
        {
            Vector3 temp = transform.position;
            transform.position.Set(temp.x, 1, temp.z);
        }
	}

    private void OnCollisionStay(Collision collision)
    {
        transform.position = Vector3.MoveTowards(transform.position, centre.transform.position, moveSpeed);
    }
}
