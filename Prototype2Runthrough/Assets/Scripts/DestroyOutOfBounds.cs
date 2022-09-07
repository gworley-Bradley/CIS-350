using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 25;
    public float bottomBound = -10;

    private HealthSystem healthSystemScript;

    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {

        //separating the food from the animals going out of bounds
        //food going out of bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //animals going out of bounds
        if (transform.position.z < bottomBound)
        {
            healthSystemScript.TakeDamage();

            Destroy(gameObject);
        }
    }
}
