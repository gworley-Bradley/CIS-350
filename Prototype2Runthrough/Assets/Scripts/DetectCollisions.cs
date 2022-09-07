using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to food projectile prefab

public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScoreScript;
    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }


    private void OnTriggerEnter(Collider other)
    {
        //Calculates score addition when an animal is hit with food
        displayScoreScript.score++;
        //Then destroys all objects
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
