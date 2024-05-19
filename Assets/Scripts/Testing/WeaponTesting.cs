using UnityEngine;
using UniRx;

public class WeaponTesting : MonoBehaviour
{
    [SerializeField]
    private WeaponsContainer _weaponsContainer;
    [HideInInspector]
    public WeaponType CurrentWeaponType;
    private CompositeDisposable _disposables = new CompositeDisposable();

    public void SetNewWeapon(WeaponType type)
    {
        var newWeapon = _weaponsContainer.GetWeaponByType(type);
        WeaponSetter.SetWeapon(newWeapon);
        CurrentWeaponType = type;
    }
    public void SetRandomWeapon()
    {
        var weapon = _weaponsContainer.GetRandomWeapon();
        WeaponSetter.SetWeapon(weapon);
        CurrentWeaponType = weapon.Type;
    }

    private void OnDestroy()
    {
        _disposables.Dispose();
    }
}
