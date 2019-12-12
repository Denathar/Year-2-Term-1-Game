using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float timeToStart = 1f;

    public float timeToRepeat = 5.0f;

    public Transform[] SpawnPoints;

    private void Start()
    {
        InvokeRepeating("SpawnEnemies", timeToStart, timeToRepeat);
    }
    private void SpawnEnemies()
    {
        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            Instantiate(enemyPrefab, SpawnPoints[i].position, SpawnPoints[i].rotation);
        }
        
    }
}
