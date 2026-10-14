using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float movementspeed = 5f;

    Rigidbody2D rb; // Changed from Rigidbody to Rigidbody2D

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Changed to Rigidbody2D
    }

    void Update()
    {
        // 2D Movement Inputs (A/D or Left/Right for X)
        float moveInputX = Input.GetAxisRaw("Horizontal");

        // Set 2D velocity along X and preserve Y
        rb.linearVelocity = new Vector2(moveInputX * movementspeed, rb.linearVelocity.y);

        // Jump Input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpForce = 5f;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // Changed to Vector2 and ForceMode2D
        }
    }
}