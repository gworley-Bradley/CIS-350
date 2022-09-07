using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScore displayScoreScript;
    private HealthSystem healthSystemScript;
    private void Start()
    {
        //Used to update the game values
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }


    private void OnTriggerEnter(Collider other)
    {
        //Used to update the game values
        displayScoreScript.score++;
        healthSystemScript.score++;
        //Destroy the ball after it hits dog
        Destroy(gameObject);
    }
}
