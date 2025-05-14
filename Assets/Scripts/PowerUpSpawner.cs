using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject PowerUpPrefab;

[SerializeField]
    Transform PowerSpawn;
  

    protected float timeBetweenSpawnP = 4.2f;
    protected float timeSinceLastSpawnP = 0;

     void Update()
    {
        timeSinceLastSpawnP += Time.deltaTime;

        if (timeSinceLastSpawnP > timeBetweenSpawnP)
        {
            Instantiate(PowerUpPrefab, PowerSpawn.position, Quaternion.identity);
            timeSinceLastSpawnP = 0;
        }
    }
}
