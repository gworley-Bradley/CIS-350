/*
 * (Gavin Worley)
 * (Prototype 1)
 * (Brief description of the code in the file.
 *  Adds to the score when the player enters the triggerzone)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach this to player
public class PlayerEnterTrigger : MonoBehaviour
{
    //set this reference in the inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;

        }
    }
}
