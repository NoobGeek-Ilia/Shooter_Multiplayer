using UniRx;

public class WeaponSwitcher
{
    private static ReactiveProperty<WeaponScriptable> _currentWeapon = new ReactiveProperty<WeaponScriptable>();
    public static IReadOnlyReactiveProperty<WeaponScriptable> CurrentWeapon => _currentWeapon;

    public static void SetWeapon(WeaponScriptable weapon)
    {
        _currentWeapon.Value = weapon;
    }
}