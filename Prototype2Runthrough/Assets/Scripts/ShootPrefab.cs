/*
 * (Gavin Worley)
 * (Prototype 2)
 * (Brief description of the code in the file.
 *  Allows the player to shoot their food prefab at the animals)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{

    public GameObject prefabToShoot;

    public HealthSystem healthSystem;


    private void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !healthSystem.gameOver)
        {
            //shoots the prefab
            Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
        }
        
    }
}
