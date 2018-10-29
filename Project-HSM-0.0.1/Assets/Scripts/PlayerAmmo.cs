using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAmmo : MonoBehaviour
{
    public float gunAmmoCount;
    public float meleeAmmoCount;
    public Text ammoText;
    public GameObject ActiveWeapon;
    WeaponControl weaponControl;

    // Use this for initialization
    void Start () {
        gunAmmoCount = 20;
        meleeAmmoCount = 10;
        ActiveWeapon = GameObject.Find("ActiveWeapon");
        weaponControl = ActiveWeapon.GetComponent<WeaponControl>();
        ammoText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if(weaponControl.Weapon == 1)
        {
            ammoText.text = gunAmmoCount.ToString();
        }

        if(weaponControl.Weapon == 2)
        {
            ammoText.text = meleeAmmoCount.ToString();
        }
        if(weaponControl.Weapon != 2 && meleeAmmoCount < 10)
        {
            meleeAmmoCount = meleeAmmoCount + (Time.deltaTime / 2);
        }
    }
}
