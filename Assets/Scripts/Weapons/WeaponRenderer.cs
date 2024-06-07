using UniRx;
using UnityEngine;

public class WeaponRenderer : MonoBehaviour
{
    private SpriteRenderer _weaponSprite;
    private CompositeDisposable _disposables = new CompositeDisposable();

    private void Awake()
    {
        _weaponSprite = GetComponent<SpriteRenderer>();
        InputMouse.OnCursorRightOfCenter += FlipWeapon;
        WeaponSetter.CurrentWeapon.Subscribe(weapon =>
        {
            if (weapon != null)
            {
                SetNewSprite(weapon);
            }
        }).AddTo(_disposables);
    }

    private void OnDestroy()
    {
        _disposables.Dispose();
        InputMouse.OnCursorRightOfCenter -= FlipWeapon;
    }

    private void SetNewSprite(WeaponScriptable weapon)
    {
        _weaponSprite.sprite = weapon.Sprite;
    }

    private void FlipWeapon(bool isRight)
    {
        _weaponSprite.flipX = !isRight;
        UpdateAim(isRight);
    }

    private void UpdateAim(bool isRight)
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z;
        Vector3 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (!isRight)
            angle -= 180f;

        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}