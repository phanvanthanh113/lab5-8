using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float knockbackForce = 5f; // Lực đẩy lùi khi va vào quạt
    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 startPosition; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position; // Lưu trữ vị trí ban đầu của player
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement.normalized * moveSpeed; // Thay linearVelocity bằng velocity
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fan")) // Đặt Tag cho quạt là "Fan"
        {
            Vector2 knockbackDirection = (transform.position - collision.transform.position).normalized;
            rb.linearVelocity = knockbackDirection * knockbackForce;
            transform.position = startPosition;
        }
        else if (collision.CompareTag("Enemy")) // Đặt Tag cho enemy là "Enemy"
        {
            // Khi va chạm với enemy, đưa player quay lại vị trí ban đầu
            transform.position = startPosition;

        }
    }
}
