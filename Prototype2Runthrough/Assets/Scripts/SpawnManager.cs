using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //set this array of references in the inspector
    public GameObject[] prefabsToSpawn;


    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    public HealthSystem healthSystem;

    void Start()
    {
        //get a reference to the health system script
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        //Using coroutine to randomly spawn prefabs
        StartCoroutine(SpawnRandomPrefabWithCoroutine());

    }
    void SpawnRandomPrefab()
    {
        //Generate Index
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //Generate Spawn Position
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        //Spawn Prefab
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        //This adds a three second delay before first spawning objects
        yield return new WaitForSeconds(3f);

        //Continue to spawn while the game is not over. Make condition true to 
        while (!healthSystem.gameOver)
        {
            //Instead of copy pasting, call the encapsulated method already written
            SpawnRandomPrefab();
            //random delay calculation
            float randomDelay = Random.Range(1.5f, 3.0f);
            //waiting for designated random delay
            yield return new WaitForSeconds(randomDelay);
        }
    }
}
