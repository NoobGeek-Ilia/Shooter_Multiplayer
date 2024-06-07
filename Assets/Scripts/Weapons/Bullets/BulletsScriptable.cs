using UnityEngine;

[CreateAssetMenu(fileName = "New bullet", menuName = "Bullets")]
public class BulletsScriptable : ScriptableObject
{
    public Sprite Sprite;
    public int Damage;
    public float Speed;
}