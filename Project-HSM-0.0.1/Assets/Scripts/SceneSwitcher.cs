using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

    [SerializeField] private string sceneWanted;

    public void SwitchScene()
    {
        SceneManager.LoadScene(sceneWanted, LoadSceneMode.Single);
    }
}
