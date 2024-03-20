using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponPack;

public class Namespaces_Weapon : MonoBehaviour
{
    private WeaponPack.Namespaces_Weapon _weapon;

    private void Start()
    {
        _weapon = GameObject.Find("WeaponPack").GetComponent<WeaponPack.Namespaces_Weapon>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _weapon.CreateNewWeapon();
        }
    }
}