using System.Numerics;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float _jumpForce;
    [SerializeField] Transform _playerTransform;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");

        _playerTransform.Translate(0, vertical, 0);
        


    }
}
