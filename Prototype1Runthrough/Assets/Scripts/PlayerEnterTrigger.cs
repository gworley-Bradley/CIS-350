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
