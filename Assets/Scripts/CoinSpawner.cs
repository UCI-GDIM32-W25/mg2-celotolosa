using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    private float minSpawnRate = 0.5f;
    private float maxSpawnRate = 1.8f;

    private float spawnTimer;
    void Start()
    {
        SetNextSpawnTime();
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
            SetNextSpawnTime();
        }
    }
    private void SetNextSpawnTime()
    {
        spawnTimer = Random.Range(minSpawnRate, maxSpawnRate);
    }
}
