using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public List<GameObject> listObstacle;
    public float maxY;
    public float minY;
    public float maxX;
    public float minX;
    public float timeBetweenSpawn;
    private float spawnTime;

    void Start()
    {
        spawnTime = Time.time + timeBetweenSpawn;
    }

    void Update()
    {
        if (Time.time >= spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        int randomIndex = Random.Range(0, listObstacle.Count);
        GameObject obstacle = listObstacle[randomIndex];
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0f), transform.rotation);
    }
}
