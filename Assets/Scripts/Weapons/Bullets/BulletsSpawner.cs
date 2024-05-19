using UniRx;
using UnityEngine;

class BulletsSpawner : MonoBehaviour
{
    [SerializeField]
    private BulletsPointer _bulletsPointer;
    private CompositeDisposable _disposables = new CompositeDisposable();
    private void Awake()
    {
        WeaponSetter.CurrentWeapon.Subscribe(weapon =>
        {
            if (weapon != null)
            {
                SetNewBulletPosition(weapon.Type);
            }
        }).AddTo(_disposables);

       // PlayerRenderer.IsLookingAtRight.Subscribe(SetNewBulletPosition_X).AddTo(_disposables);
    }

    private void OnDestroy()
    {
        _disposables.Dispose();
    }

    private void SetNewBulletPosition(WeaponType weapon)
    {
        var index = (int)weapon;
        var newPosition = _bulletsPointer._spawnPoints[index].position;
        transform.position = newPosition;
    }


    //отражает неверно
    public void SetNewBulletPosition_X(bool isRight)
    {
        Vector2 pos = transform.position;
        float newX = Mathf.Abs(pos.x);
        if (!isRight)
        {
            newX = -newX;
        }
        transform.position = new Vector2(newX, pos.y);
    }
}