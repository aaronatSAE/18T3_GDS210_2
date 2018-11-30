using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    [SerializeField] private GameObject bullet;
    private WeaponControl weaponControl;
    private PlayerAmmo playerAmmo;

	// Find gameobjects
	void Start () {
        weaponControl = GameObject.Find("ActiveWeapon").GetComponent<WeaponControl>();
        playerAmmo = GameObject.Find("AmmoCount").GetComponent<PlayerAmmo>();
	}
	
	// Checks if the player meets the requirements to use the water gun
	void Update ()
    {
        //if (Input.GetKeyDown(KeyCode.Space) && playerAmmo.gunAmmoCount > 0)
            if (Input.GetKeyDown(KeyCode.Space))
            {
            //reduce ammo count and spawn a bullet
            if(weaponControl.Weapon == 1)
            {
                //playerAmmo.gunAmmoCount -= 1;
                Instantiate(bullet, transform.position, transform.rotation);
            }
        }
	}
}
