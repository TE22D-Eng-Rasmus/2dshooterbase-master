using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;

    float timeBetweenSpawn = 1f;
    float timeSinceLastSpawn = 0;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn > timeBetweenSpawn)
        {
            Instantiate(enemyPrefab);
            timeSinceLastSpawn = 0;
        }
    }
}
