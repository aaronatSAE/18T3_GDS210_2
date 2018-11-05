using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMelee : MonoBehaviour
{
    public GameObject YoYo;
    public GameObject ActiveWeapon;
    private GameObject Melee;
    public GameObject AmmoCount;
    bool meleeSpawn;
    WeaponControl weaponControl;
    PlayerAmmo playerAmmo;

    // finds gameobjects and set booleans
    void Start ()
    {
        AmmoCount = GameObject.Find("AmmoCount");
        ActiveWeapon = GameObject.Find("ActiveWeapon");
        weaponControl = ActiveWeapon.GetComponent<WeaponControl>();
        playerAmmo = AmmoCount.GetComponent<PlayerAmmo>();
        meleeSpawn = false;
    }
	
	// checks if player has meet the requirements to use the Yo-Yo weapon
	void Update () {
        if(Input.GetMouseButton(0) && playerAmmo.meleeAmmoCount > 0 && weaponControl.Weapon == 2)
        {
            playerAmmo.meleeAmmoCount = playerAmmo.meleeAmmoCount - Time.deltaTime;
            if (meleeSpawn == false)
            {
                Melee = Instantiate(YoYo, gameObject.transform.position, gameObject.transform.rotation);
                Melee.transform.parent = gameObject.transform;
                meleeSpawn = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            Destroy(Melee);
            meleeSpawn = false;
        }

        if(playerAmmo.meleeAmmoCount < 0)
        {
            Destroy(Melee);
            meleeSpawn = false;
        }
    }
}
