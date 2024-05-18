using System;
using UnityEngine;

public class JumpDetection : MonoBehaviour
{
    public Action SensorIsActivated;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TileMap"))
            SensorIsActivated?.Invoke();
    }
}
