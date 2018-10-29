using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    public GameObject bullet;
    public GameObject ActiveWeapon;
    public GameObject AmmoCount;
    WeaponControl weaponControl;
    PlayerAmmo playerAmmo;

	// Use this for initialization
	void Start () {
        AmmoCount = GameObject.Find("AmmoCount");
        ActiveWeapon = GameObject.Find("ActiveWeapon");
        weaponControl = ActiveWeapon.GetComponent<WeaponControl>();
        playerAmmo = AmmoCount.GetComponent<PlayerAmmo>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0) && playerAmmo.gunAmmoCount > 0)
        {
            if(weaponControl.Weapon == 1)
            {
                playerAmmo.gunAmmoCount -= 1;
                Instantiate(bullet, transform.position, transform.rotation);
            }
        }
	}
}
