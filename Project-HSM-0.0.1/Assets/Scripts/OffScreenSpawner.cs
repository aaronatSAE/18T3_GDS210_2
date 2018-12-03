using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScreenSpawner : MonoBehaviour {
    [SerializeField] private float timer = 10;
    [SerializeField] private Vector3 spawn;
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private float scriptTimer = 5;
    GameObject player;
    [SerializeField] private Ray ray;

    // makes a array and puts the 3 enemy types into the array as well as finding the player
    void Start () {
        scriptTimer = 5;
        enemies = new GameObject[3];
        enemies[1] = Resources.Load<GameObject>("Enemy/MeleeEnemy");
        enemies[0] = Resources.Load<GameObject>("Enemy/TrapperEnemy");
        enemies[2] = Resources.Load<GameObject>("Enemy/RangedEnemy");
        player = GameObject.Find("Player");
        scriptTimer = timer;
    }
	
    //randomly spawn enemies offscreen
	void Update ()
    {
        //timer for spawning the enemies
        scriptTimer -= Time.deltaTime;
        //when the timer reaches 0 spawn a enemy
        if(scriptTimer <= 0)
        {
            //randomly gets a location offscreen
            float ran = Random.Range(0, 2) * 2 - 1;
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(ran, ran));
            spawn = ray.GetPoint(10);
            if(player.transform.position.x > spawn.x)
            {
                spawn.x -= 5;
            }
            else
            {
                spawn.x += 5;
            }
            if (player.transform.position.z > spawn.z)
            {
                spawn.z -= 5;
            }
            else
            {
                spawn.z += 5;
            }
            //spawn enemy
            Instantiate(enemies[Random.Range(0, 3)], spawn, Quaternion.identity);
            //reset timer
            scriptTimer = timer;
        }
	}
}
