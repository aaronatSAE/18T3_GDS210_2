using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScreenSpawner : MonoBehaviour {
    public float timer = 10;
    public Vector3 spawn;
    public GameObject[] enemies;
    GameObject player;
    public Ray ray;

    // Use this for initialization
    void Start () {
        enemies = new GameObject[3];
        enemies[0] = Resources.Load<GameObject>("Enemy/MeleeEnemy");
        enemies[1] = Resources.Load<GameObject>("Enemy/TrapperEnemy");
        enemies[2] = Resources.Load<GameObject>("Enemy/RangedEnemy");
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
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
            Instantiate(enemies[Random.Range(0, 3)], spawn, Quaternion.identity);
            timer = 10;
        }
	}
}
