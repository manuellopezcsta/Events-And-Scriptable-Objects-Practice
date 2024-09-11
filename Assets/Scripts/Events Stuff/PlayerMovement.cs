using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] float movementSpeed;
    public float runSpeed = 40f;
    float dirX;

    void Start()
    {
        // Obtén el componente Rigidbody del bloque
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        // Move our character
        rb.velocity = new Vector2(dirX * movementSpeed, rb.velocity.y); // Right and left movement.
    }
}
