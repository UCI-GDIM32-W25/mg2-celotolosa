using Unity.VisualScripting;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float _jumpForce;
    [SerializeField] Transform _playerTransform;
    private bool _isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            Jump();
        }
    }
    private void Jump()
    {
        _isGrounded = false;
        rb.velocity = new Vector2(rb.velocity.x, _jumpForce);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            _isGrounded = true;
        }
    } 
}
