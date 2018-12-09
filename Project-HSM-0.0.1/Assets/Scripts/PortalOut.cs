using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalOut : MonoBehaviour {
    [SerializeField] private string scene;
    //switches scenes when player is inside of the gameobject
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadSceneAsync(scene, LoadSceneMode.Single);
        }
    }
}
