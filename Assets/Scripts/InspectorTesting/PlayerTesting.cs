using UnityEngine;
using UniRx;

public class PlayerTesting : MonoBehaviour
{
    [SerializeField]
    private WeaponType _weaponType;
    [SerializeField]
    private WeaponsContainer _weaponsContainer;
    private CompositeDisposable _disposables = new CompositeDisposable();

    private void Awake()
    {
        Observable.EveryUpdate()
            .Select(_ => _weaponType)
            .DistinctUntilChanged()
            .Subscribe(type =>
            {
                var newWeapon = _weaponsContainer.GetWeaponByType(type);
                WeaponSwitcher.SetWeapon(newWeapon);
            }).AddTo(_disposables);
    }

    private void OnDestroy()
    {
        _disposables.Dispose();
    }
}
