using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject PlusHealthPrefab;

    [SerializeField]
    Transform HealthSpawn;

    private float timeBetweenSpawn = 2.8f;
    private float timeSinceLastSpawn = 0;

    void Start() { }
    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn > timeBetweenSpawn)
        {
            Instantiate(PlusHealthPrefab, HealthSpawn.position, Quaternion.identity);
            timeSinceLastSpawn = 0;
        }
    }
}
