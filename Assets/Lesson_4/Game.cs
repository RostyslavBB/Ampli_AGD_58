using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private List<Weapon> _weapons;

    private void Start()
    {
        foreach (Weapon weapon in _weapons)
        {
            PrintInfo(weapon);
        }
    }

    private void PrintInfo(Weapon weapon)
    {
        Debug.Log("\nName: " + weapon.weaponName + 
            "\nDamage: " + weapon.weaponDamage + 
            "\nType: " + weapon.weaponType +
            "\nRare: " + weapon.WeaponRare);
    }
}
