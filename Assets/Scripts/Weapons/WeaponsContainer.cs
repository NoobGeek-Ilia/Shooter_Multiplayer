using System.Collections.Generic;
using UnityEngine;

public class WeaponsContainer : MonoBehaviour
{
    [SerializeField]
    private WeaponScriptable[] WeaponsScriptable;
    private List<WeaponScriptable> weaponsList = new List<WeaponScriptable>();

    private void Awake()
    {
        foreach (var weapon in WeaponsScriptable)
        {
            weaponsList.Add(weapon);
        }
    }

    public WeaponScriptable GetRandomWeapon()
    {
        var randomIndex = Random.Range(0, weaponsList.Count);
        return weaponsList[randomIndex];
    }

    public WeaponScriptable GetWeaponByType(WeaponType type)
    {
        return weaponsList.Find(weapon => weapon.Type == type);
    }
}