using System;
using UnityEngine;

public class InputMouse : MonoBehaviour
{
    public static Action<bool> OnCursorRightOfCenter;
    private bool _previousIsRightOfCenter;

    void Update()
    {
        CheckCursorPosition();
    }

    void CheckCursorPosition()
    {
        Vector2 cursorPosition = Input.mousePosition;
        Vector2 screenCenter = new Vector2(Screen.width / 2, Screen.height / 2);
        bool isRightOfCenter = cursorPosition.x > screenCenter.x;

        if (isRightOfCenter != _previousIsRightOfCenter)
        {
            OnCursorRightOfCenter?.Invoke(isRightOfCenter);
            _previousIsRightOfCenter = isRightOfCenter;
        }
    }
}
