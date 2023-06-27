using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGift : MonoBehaviour
{
     public List<GameObject> listGift;
    public float maxY;
    public float minY;
    public float maxX;
    public float minX;

    public List<float> listPositionY;
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
        int randomYIndex = Random.Range(0, listPositionY.Count);
        int randomIndex = Random.Range(0, listGift.Count);
        GameObject gift = listGift[randomIndex];
        Instantiate(gift, transform.position + new Vector3(randomX, listPositionY[randomYIndex], 0f), transform.rotation);
    }
}
