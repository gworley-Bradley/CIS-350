/*
 * (Gavin Worley)
 * (Challenge 1)
 * (Brief description of the code in the file.
 *  If the player goes out of bounds then the game is over)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnStray : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -51 || transform.position.y > 80)
        {
            ScoreManager.gameOver = true;
        }

    }
}
