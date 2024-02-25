using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRange = 9.0f;

    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWaves(3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnEnemyWaves(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, randomSpawnLoc(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 randomSpawnLoc()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomSpawnLoc = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomSpawnLoc;
    }
}
