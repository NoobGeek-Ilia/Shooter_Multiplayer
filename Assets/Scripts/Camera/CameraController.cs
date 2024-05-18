using UnityEngine;

public class CameraController : BaseTargetFollow
{
    [SerializeField]
    private Transform _player;

    private void FixedUpdate()
    {
        MoveTo(_player);
    }
}
