using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponControl : MonoBehaviour {
    public float Weapon;
    public Text WeaponText;

    private void Start()
    {
        Weapon = 1;
        WeaponText = GetComponent<Text>();
        WeaponText.text = "Water Gun";
    }

    // Update is called once per frame
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
