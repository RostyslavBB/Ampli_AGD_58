using System;

[Serializable]
public class Weapon
{
    public string weaponName;
    public int weaponDamage;

    public WeaponType weaponType;
    public WeaponRare WeaponRare;
}

public enum WeaponType
{
    None,
    Melee,
    Ranged
}

public enum WeaponRare
{
    None,
    Common,
    Rare,
    Legendary
}
