/*
 * (Gavin Worley)
 * (Prototype 3)
 * (Brief description of the code in the file.
 *  Used to spawn obstacles at a dedicated rate)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        //start the repeating spawn of obstacles for the player to jump over
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);

        }
    }
}
