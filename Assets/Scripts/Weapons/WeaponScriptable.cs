using UnityEngine;

[CreateAssetMenu(fileName = "New weapon", menuName = "Weapon")]
public class WeaponScriptable : ScriptableObject
{
    public WeaponType Type;
    public string Name;
    public string Description;
    public Sprite Sprite;
}
