using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float movementspeed = 5f;

    Rigidbody rb;
    void Start() {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        // 3D Movement Inputs (A/D or Left/Right for X, W/S or Up/Down for Z)
        float moveInputX = Input.GetAxisRaw("Horizontal");
        float moveInputZ = Input.GetAxisRaw("Vertical");

        rb.linearVelocity = new Vector3(moveInputX * movementspeed, rb.linearVelocity.y, moveInputZ * movementspeed);

        // Jump Input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpForce = 5f; // Adjust jump height as needed
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
