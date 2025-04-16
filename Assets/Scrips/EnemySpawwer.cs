using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;
    public float spawnInterval = 6f;
    public float spawnDistance = 5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), spawnInterval, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (player == null) return;

        // Random vị trí xung quanh Player
        Vector2 spawnPos = (Vector2)player.position + Random.insideUnitCircle.normalized * spawnDistance;

        // Tạo Enemy
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}