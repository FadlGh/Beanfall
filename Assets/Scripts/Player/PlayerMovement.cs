using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 gravityDirection;
    [SerializeField] private float gravityStrength;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(speed * horizontalInput, rb.velocity.y);
        rb.velocity = movement;

        if(rb.velocity.sqrMagnitude < 200f)
        {
            ApplyGravity();
        }
    }

    private void ApplyGravity()
    {
        Vector2 gravity = gravityDirection.normalized * gravityStrength;
        rb.AddForce(gravity, ForceMode2D.Force);
    }
}
