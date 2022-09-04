/*
 * (Gavin Worley)
 * (Prototype 1)
 * (Brief description of the code in the file.
 *  Adds to the score when the player enters the triggerzone)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}

