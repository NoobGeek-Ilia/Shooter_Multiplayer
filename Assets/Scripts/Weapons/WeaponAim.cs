using UnityEngine;

public class WeaponAim : MonoBehaviour
{
    private SpriteRenderer weaponSpriteRenderer;

    void Awake()
    {
        weaponSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        AimAtMouse(mousePosition);
    }

    void AimAtMouse(Vector3 mousePosition)
    {
        mousePosition.z = transform.position.z;
        Vector3 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if (weaponSpriteRenderer.flipX)
            angle -= 180f;

        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
