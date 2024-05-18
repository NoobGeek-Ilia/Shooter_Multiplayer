using System;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private static KeyCode LastButtPressed;
    private static KeyCode CurrentButtPressed;

    public static float InputInfoX { get; private set; }
    public static Action<KeyCode> OnLastButtPressed;

    private readonly KeyCode[] keys = { KeyCode.A, KeyCode.W, KeyCode.S, KeyCode.D, };

    private void Update()
    {
        InputInfoX = Input.GetAxis("Horizontal");
        CheckLastButton();
    }

    private void CheckLastButton()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            if (Input.GetKeyDown(keys[i]))
            {
                CurrentButtPressed = keys[i];
                if (CurrentButtPressed != LastButtPressed)
                    OnLastButtPressed?.Invoke(CurrentButtPressed);
                LastButtPressed = CurrentButtPressed;
            }
        }
    }
}
