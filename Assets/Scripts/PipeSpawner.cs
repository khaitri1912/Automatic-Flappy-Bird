using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnInterval = 8f;
    public float pipeGap = 2f;

    private float timeSinceLastSpawn;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnPipe();
            timeSinceLastSpawn = 0;
        }
    }

    void SpawnPipe()
    {
        float randomHeight = Random.Range(-pipeGap, pipeGap);
        Vector3 PipePosition = new Vector3(transform.position.x, randomHeight + pipeGap / 2, 0);

        // Tạo ống trên và ống dưới
        Instantiate(pipePrefab, PipePosition, Quaternion.identity);
    }
}
