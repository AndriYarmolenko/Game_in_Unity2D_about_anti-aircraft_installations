using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGenerator : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float minSpawnX = -7.3f;
    public float maxSpawnX = 7.0f;
    public float spawnY = 7.63f;
    public float spawnInterval = 2.0f;
    public float initialZRotation = -135.5f; // Додайте цей рядок

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            float randomX = Random.Range(minSpawnX, maxSpawnX);
            Vector3 spawnPosition = new Vector3(randomX, spawnY, 0);

            // Зміна орієнтації об'єкту
            Quaternion spawnRotation = Quaternion.Euler(0, 0, initialZRotation);

            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, spawnRotation);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
