/*
 * (Gavin Worley)
 * (Challenge 2)
 * (Brief description of the code in the file.
 *  Used to detect the colisions of the dog and ball, also used for score/lives)
 */
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
