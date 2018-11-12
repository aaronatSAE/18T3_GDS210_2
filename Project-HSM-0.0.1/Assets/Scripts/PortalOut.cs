using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalOut : MonoBehaviour {
    public string scene;

	// Use this for initialization
	void Start () {
	}

    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            print("run");
            SceneManager.LoadSceneAsync(scene, LoadSceneMode.Single);
        }
    }
}
