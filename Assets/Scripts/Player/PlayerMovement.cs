using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] 
    JumpDetection jumpDetection;
    private Rigidbody2D rb; 

    private float _moveSpeed = 10;

    private float _jumpForce = 20;
    private int _jumpCount = 2;

    public void Init()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpDetection.SensorIsActivated += () =>
        {
            _jumpCount = 2;
        };
    }

    private void Update()
    {
        Jump(_jumpForce);
    }
    private void FixedUpdate()
    {
        Move(_moveSpeed);
    }

    void Move(float moveSpeed)
    {
        rb.velocity = new Vector2(InputKeyboard.InputInfoX * moveSpeed, rb.velocity.y);
    }

    void Jump(float force)
    {
        if (Input.GetKeyDown(KeyCode.Space) && _jumpCount > 0)
        {
            rb.velocity = new Vector2(rb.velocity.y, force);
            _jumpCount--;
        }
    }
}
