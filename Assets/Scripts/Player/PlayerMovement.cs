using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed;
    [HideInInspector] public float defaultSpeed;
    [SerializeField] private float speed;
    [SerializeField] private Vector3 gravityDirection;
    [SerializeField] private float gravityStrength;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultSpeed = maxSpeed;
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(speed * horizontalInput, rb.velocity.y);
        rb.velocity = movement;

        if (rb.velocity.sqrMagnitude > maxSpeed)
        {
            ApplyGravity(-gravityStrength);
        }
        else
        {
            ApplyGravity(gravityStrength);
        }
        print(rb.velocity.sqrMagnitude);
    }

    private void ApplyGravity(float amount)
    {
        Vector2 gravity = gravityDirection.normalized * amount;
        rb.AddForce(gravity, ForceMode2D.Force);
    }

    public void ChangeSpeed(float speed)
    {
        StartCoroutine(ChangeSpeedCoroutine(speed));
    }

    private IEnumerator ChangeSpeedCoroutine(float speed)
    {
        maxSpeed = speed;

        yield return new WaitForSeconds(5f);

        maxSpeed = defaultSpeed;
    }
}
