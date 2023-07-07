using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay;
    private float spawnInterval;
    // Start is called before the first frame update
    void Start()
    {
        startDelay = 2f;
        spawnInterval = 1.5f;

        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-18, 18), 0, 20), animalPrefabs[animalIndex].transform.rotation);
    }
}
