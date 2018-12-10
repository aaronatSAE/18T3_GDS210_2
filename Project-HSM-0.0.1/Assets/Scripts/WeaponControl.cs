using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponControl : MonoBehaviour {
    public float Weapon;
    public Image WeaponImage;
    public Sprite waterGun;
    public Sprite yoYo;
    GameObject gun;

    //sets default weapon information to water gun
    private void Start()
    {
        Weapon = 1;
        WeaponImage = GetComponent<Image>();
        gun = GameObject.FindGameObjectWithTag("Gun");
    }

    // retrieves player input and changes the active weapon the player is using
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Weapon = 1;
            WeaponImage.sprite = waterGun;
            gun.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Weapon = 2;
            WeaponImage.sprite = yoYo;
            gun.SetActive(false);
        }
	}
}
