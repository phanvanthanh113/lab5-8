﻿using UnityEngine;

public class GoldenCircle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.CollectGoldenCircle();
            Destroy(gameObject);
        }
    }
}
