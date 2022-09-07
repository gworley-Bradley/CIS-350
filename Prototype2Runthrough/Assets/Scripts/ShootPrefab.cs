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
