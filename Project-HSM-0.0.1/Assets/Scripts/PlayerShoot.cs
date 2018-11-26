using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    public GameObject bullet;
    public GameObject ActiveWeapon;
    public GameObject AmmoCount;
    WeaponControl weaponControl;
    PlayerAmmo playerAmmo;

	// Find gameobjects
	void Start () {
        AmmoCount = GameObject.Find("AmmoCount");
        ActiveWeapon = GameObject.Find("ActiveWeapon");
        weaponControl = ActiveWeapon.GetComponent<WeaponControl>();
        playerAmmo = AmmoCount.GetComponent<PlayerAmmo>();
	}
	
	// Checks if the player meets the requirements to use the water gun
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerAmmo.gunAmmoCount > 0)
        {
            if(weaponControl.Weapon == 1)
            {
                playerAmmo.gunAmmoCount -= 1;
                Instantiate(bullet, transform.position, transform.rotation);
            }
        }
	}
}
