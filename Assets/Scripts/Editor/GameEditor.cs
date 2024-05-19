using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(WeaponTesting))]
public class GameEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        WeaponTesting script = target as WeaponTesting;

        if (GUILayout.Button("Select random weapon"))
        {
            script.SetRandomWeapon();
        }

        EditorGUI.BeginChangeCheck(); // Начало проверки на изменения

        WeaponType selectedWeapon = (WeaponType)EditorGUILayout.EnumPopup("Select Weapon", script.CurrentWeaponType);

        if (EditorGUI.EndChangeCheck())
        {
            script.SetNewWeapon(selectedWeapon);
        }
    }
}