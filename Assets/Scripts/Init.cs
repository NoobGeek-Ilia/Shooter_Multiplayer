using UnityEngine;

public class Init : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement _playerMovement;
    private void Awake()
    {
        _playerMovement.Init();
    }
}
