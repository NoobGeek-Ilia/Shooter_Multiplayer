using UniRx;
using UnityEngine;

class WeaponRenderer : MonoBehaviour
{
    private SpriteRenderer _currentSpriteRenderer;
    private CompositeDisposable _disposables = new CompositeDisposable();

    private void Awake()
    {
        InputController.OnLastButtPressed += Flip;
        _currentSpriteRenderer = GetComponent<SpriteRenderer>();
        WeaponSwitcher.CurrentWeapon.Subscribe(weapon =>
        {
            if (weapon != null)
            {
                _currentSpriteRenderer.sprite = weapon.Sprite;
            }
        }).AddTo(_disposables);
    }

    private void OnDestroy()
    {
        _disposables.Dispose();
    }

    public void Flip(KeyCode key)
    {
        _currentSpriteRenderer.flipX = (key != KeyCode.D);
    }
}