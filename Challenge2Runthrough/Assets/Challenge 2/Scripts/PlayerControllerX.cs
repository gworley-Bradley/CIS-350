using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public HealthSystem healthSystem;

    private float dogCooldown;

    private void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //Creating cooldown for the spawn of dogs to 1/sec
        dogCooldown -= Time.deltaTime;
        if (dogCooldown <= 0)
        {

            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnDogPrefab();
            }
        }
    }

    private void SpawnDogPrefab()
    {
        //Limits the player to only spawn dogs while the game is active
        if (!healthSystem.gameOver && !healthSystem.gameWin)
        { 
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        dogCooldown = 1;
        }
    }
}
