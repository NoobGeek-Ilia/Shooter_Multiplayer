using UnityEngine;

public class PlayerRenderer : MonoBehaviour
{
    private SpriteRenderer _playerSprite;
    private void Awake()
    {
        _playerSprite = GetComponent<SpriteRenderer>();
        InputController.OnLastButtPressed += Flip;
    }

    public void Flip(KeyCode key)
    {
        _playerSprite.flipX = (key == KeyCode.D);
    }
}