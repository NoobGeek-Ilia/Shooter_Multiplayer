using UniRx;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PlayerRenderer : MonoBehaviour
{
    private SpriteRenderer _playerSprite;

    private void Awake()
    {
        _playerSprite = GetComponent<SpriteRenderer>();
        InputMouse.OnCursorRightOfCenter += Flip;
    }

    private void OnDestroy()
    {
        InputMouse.OnCursorRightOfCenter -= Flip;
    }

    public void Flip(bool flip)
    {
        _playerSprite.flipX = flip;
    }
}