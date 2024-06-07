using UnityEngine;

[CreateAssetMenu(fileName = "New weapon", menuName = "Weapon")]
public class WeaponScriptable : ScriptableObject
{
    public WeaponType Type;
    public BulletsScriptable Bullet;
    public Sprite Sprite;
    public float ShootSpeed;
}
