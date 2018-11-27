using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject player;
    [SerializeField] private float camHeight = 3;

    // finds player
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // constantly have the camera above the player
    void Update()
    {
        transform.position = new Vector3(
            player.transform.position.x,
            player.transform.position.y + camHeight,
            player.transform.position.z);
    }
}
