using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    public float rotationSpeed = 100f; // Tốc độ quay
    private Vector3 startPosition; // Lưu trữ vị trí ban đầu của cánh quạt
    private Quaternion startRotation; // Lưu trữ rotation ban đầu của cánh quạt

    void Start()
    {
        // Lưu trữ vị trí và rotation ban đầu của cánh quạt
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    void Update()
    {
        // Cánh quạt vẫn quay bình thường
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Khi va chạm với player
        {
            // Đưa cánh quạt về vị trí ban đầu và quay về hướng ban đầu
            transform.position = startPosition;
            transform.rotation = startRotation;
        }
    }
}
