using UniRx;

public class WeaponSetter
{
    private static ReactiveProperty<WeaponScriptable> _currentWeapon = new ReactiveProperty<WeaponScriptable>();
    public static IReadOnlyReactiveProperty<WeaponScriptable> CurrentWeapon => _currentWeapon;

    public static void SetWeapon(WeaponScriptable weapon)
    {
        _currentWeapon.Value = weapon;
    }
}