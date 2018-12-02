using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAmmo : MonoBehaviour
{
    public float gunAmmoCount;
    public float meleeAmmoCount;
    private Text ammoText;
    private GameObject ActiveWeapon;
    private WeaponControl weaponControl;

    // Set default ammo count as well as find certain gameobjects
    void Start () {
        gunAmmoCount = 20;
        meleeAmmoCount = 10;
        ActiveWeapon = GameObject.Find("ActiveWeapon");
        weaponControl = ActiveWeapon.GetComponent<WeaponControl>();
        ammoText = GetComponent<Text>();
    }
	
	// changes UI information
	void Update () {
        if(weaponControl.Weapon == 1)
        {
            //displays the ammo count for the gun
            ammoText.text = gunAmmoCount.ToString();
        }

        if(weaponControl.Weapon == 2)
        {
            //displays the ammo count for the Yo-Yo
            ammoText.text = meleeAmmoCount.ToString();
        }
       // if(weaponControl.Weapon != 2 && meleeAmmoCount < 10)
      //  {
            //if the player is not using the Yo-Yo the ammo for the Yo-Yo recharges
           // meleeAmmoCount = meleeAmmoCount + (Time.deltaTime / 2);
       // }
    }
}
