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
        if(Input.GetKey(KeyCode.Space) && playerAmmo.meleeAmmoCount > 0 && weaponControl.Weapon == 2)
        {
            //removes ammo
          //  playerAmmo.meleeAmmoCount = playerAmmo.meleeAmmoCount - Time.deltaTime;
            //checks if there is a existing Yo-Yo
            if (meleeSpawn == false)
            {
                //spawn Yo-Yo as child as parent
                Melee = Instantiate(YoYo, gameObject.transform.position, gameObject.transform.rotation);
                Melee.transform.parent = gameObject.transform;
                meleeSpawn = true;
            }
        }
        //remove Yo-Yo when the player stops holding the attack button
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Destroy(Melee);
            meleeSpawn = false;
        }
        //if the player doesnt have ammo for the Yo-Yo, destroy the Yo-Yo
        if(playerAmmo.meleeAmmoCount < 0)
        {
            Destroy(Melee);
            meleeSpawn = false;
        }
    }
}
