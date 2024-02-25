using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRange = 9.0f;
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;
    public int enemyCount = 1;
    public int enemiesToSpawn = 1;
    public int powerUpCount;



    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWaves(enemiesToSpawn);

    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        powerUpCount = GameObject.FindGameObjectsWithTag("PowerUp").Length;

        if (enemyCount == 0)
        {
            enemiesToSpawn++;
            SpawnEnemyWaves(enemiesToSpawn);

            if (powerUpCount < 2)
            {
                Instantiate(powerUpPrefab, randomSpawnLoc(), powerUpPrefab.transform.rotation);
            }

        }
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
