using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{
    private Dictionary<string, int> bulletInventory = new Dictionary<string, int>{
        { "Rifle", 10},
        { "Pistol", 10},
        { "Minigun", 10}
    };
    [SerializeField] private string weapon;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Shoot(weapon);
        }
        if (Input.GetKeyDown("1"))
        {
            SwitchWeapon("Rifle");
        }
        if (Input.GetKeyDown("2"))
        {
            SwitchWeapon("Pistol");
        }
        if (Input.GetKeyDown("3"))
        {
            SwitchWeapon("Minigun");
        }
    }

    void SwitchWeapon(string inWeapon)
    {
        weapon = inWeapon;
        Debug.Log(" Weapon has been switched to " + weapon);
        Debug.Log(bulletInventory[weapon] + " amount of ammo left for " + weapon);
    }
    void Shoot(string weapon)
    {
        if (bulletInventory[weapon] <= 0)
        {
            Debug.Log("Out of Ammo!");
            return;
        }
        bulletInventory[weapon] -= 1;
        Debug.Log("Shoots");
        Debug.Log(bulletInventory[weapon] + " amount of ammo left for " + weapon);
    }
}
