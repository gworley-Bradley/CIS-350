/*
 * (Gavin Worley)
 * (Prototype 2)
 * (Brief description of the code in the file.
 *  Destroys the prefabs that go outside of the set bounds)
 */
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
        //Used to find the component we are interacting with
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {

        //separating the food from the animals going out of bounds
        //food going out of bounds
        if (transform.position.z > topBound)
        {
            //destroying the food object if it gets to bounds
            Destroy(gameObject);
        }
        //animals going out of bounds
        if (transform.position.z < bottomBound)
        {
            //invoking take damage function in health system
            healthSystemScript.TakeDamage();
            //destroying the animal object if it gets to bounds
            Destroy(gameObject);
        }
    }
}
