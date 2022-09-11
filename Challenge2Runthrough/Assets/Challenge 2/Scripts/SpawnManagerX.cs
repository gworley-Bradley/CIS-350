/*
 * (Gavin Worley)
 * (Challenge 2)
 * (Brief description of the code in the file.
 *  Controls the spawning of the balls on a random interval using coroutine )
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    public HealthSystem healthSystem;

    // Start is called before the first frame update
    void Start()
    {
        //get a reference to the health system script
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        //Using coroutine to randomly spawn prefabs
        StartCoroutine(SpawnRandomBallWithCoroutine());
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int prefabIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[prefabIndex], spawnPos, ballPrefabs[prefabIndex].transform.rotation);
    }

    IEnumerator SpawnRandomBallWithCoroutine()
    {
        //This adds a three second delay before first spawning objects
        yield return new WaitForSeconds(3f);

        //Continue to spawn while the game is not over or won. Make condition true to 
        while (!healthSystem.gameOver && !healthSystem.gameWin)
        {
            //Instead of copy pasting, call the encapsulated method already written
            SpawnRandomBall();

            float randomDelay = Random.Range(3.0f, 5.0f);

            yield return new WaitForSeconds(randomDelay);
        }
    }

}
