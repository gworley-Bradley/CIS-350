/*
 * (Gavin Worley)
 * (Prototype 1)
 * (Brief description of the code in the file.
 *  If the player falls off the platform the game is over)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnFall : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
        
    }
}
