using UnityEngine;

public class CarSpawner : MonoBehaviour 
{
    public GameObject[] carPrefabs;
    public float spawnDelay = 2f;
    public Transform[] spawnPositions;

    private void Start()
    {
        InvokeRepeating("SpawnCar", 0f, spawnDelay);
    }

    void SpawnCar()
    {
        int index = Random.Range(0, spawnPositions.Length);
        Transform spawnPoint = spawnPositions[index];
        int spriteIndex = Random.Range(0, carPrefabs.Length);
        GameObject carPrefab = carPrefabs[spriteIndex];
        Instantiate(carPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
