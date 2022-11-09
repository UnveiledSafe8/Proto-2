using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float prefabRangeX = 20;
    private float prefabRangeZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        int prefabIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 prefabSpawn = new Vector3(Random.Range(-prefabRangeX, prefabRangeX), 0, prefabRangeZ);
        Instantiate(animalPrefabs[prefabIndex], prefabSpawn, animalPrefabs[prefabIndex].transform.rotation);
    }
}
