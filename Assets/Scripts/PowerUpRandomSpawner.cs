using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpRandomSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject PowerUpPrefab;

    private float radius = 5f;
    private float minY = -2f;
    private float maxY = 3f;

    void Start()
    {
        Randomer();
    }

    void Update()
    {
        // You can add any update logic here if needed
    }

    void Randomer()
    {
        Vector2 randomPoss = Random.insideUnitCircle * radius;
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPos = new Vector3(randomPoss.x, randomY, 0f);

        Instantiate(PowerUpPrefab, spawnPos, Quaternion.identity);
    }
}
