using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenShake : MonoBehaviour {
    Image health;
    GameObject mainCamera;
    CameraFollow camFollow;
    [SerializeField] private float previousHealth;
    [SerializeField] private float shakeAmount;
    [SerializeField] private float timer;

	// Use this for initialization
	void Start () {
        health = GameObject.Find("PlayerHealth").GetComponent<Image>();
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        camFollow = mainCamera.GetComponent<CameraFollow>();
        previousHealth = health.fillAmount;
    }
	
	// Update is called once per frame
	void Update () {
		if(timer > 0)
        {
            mainCamera.transform.localPosition = Random.insideUnitCircle * shakeAmount;
            timer -= Time.deltaTime;
        }
        if(timer <= 0)
        {
            camFollow.enabled = true;
        }
        if(health.fillAmount != previousHealth)
        {
            timer = 0.7f;
            health.fillAmount = previousHealth;
            camFollow.enabled = false;
        }
	}
}
