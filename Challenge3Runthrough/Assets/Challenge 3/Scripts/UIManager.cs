/*
 * (Gavin Worley)
 * (Challenge 3)
 * (Brief description of the code in the file.
 *  Used to show player the score and game decisions)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public Text scoreText;
    public int score = 0;

    public PlayerControllerX playerControllerScript;

    public bool won = false;


    // Start is called before the first frame update
    void Start()
    {

        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
        }

        scoreText.text = "Score: 0";

    }

    // Update is called once per frame
    void Update()
    {
        //If the game is not over display the score
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }
        //If the game is over and the player has not won
        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!" + "\n" + "Press R to Try Again";
        }
        //if the player score is >=20 player wins
        if (score >= 20)
        {
            playerControllerScript.gameOver = true;
            won = true;

           // playerControllerScript.StopRunning();

            scoreText.text = "You Win!" + "\n" + "Press R to Try Again!";
        }
        //Allows the player to restart the game
        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

