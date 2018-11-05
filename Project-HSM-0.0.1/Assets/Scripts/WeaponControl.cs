using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponControl : MonoBehaviour {
    public float Weapon;
    public Text WeaponText;
    
    //sets default weapon information to water gun
    private void Start()
    {
        Weapon = 1;
        WeaponText = GetComponent<Text>();
        WeaponText.text = "Water Gun";
    }

    // retrieves player input and changes the active weapon the player is using
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Weapon = 1;
            WeaponText.text = "Water Gun";
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Weapon = 2;
            WeaponText.text = "Yo-Yo";
        }
	}
}
