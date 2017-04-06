using UnityEngine;

public class CarSpawner : MonoBehaviour 
{
    public GameObject carPrefab;
    public float spawnDelay = 2f;
    public Transform[] spawnPositions;

    float spawnTimer = 0f;

    private void Start()
    {
        InvokeRepeating("SpawnCar", 0f, spawnDelay);
    }

    void SpawnCar()
    {
        int index = Random.Range(0, spawnPositions.Length);
        Transform spawnPoint = spawnPositions[index];
        Instantiate(carPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
