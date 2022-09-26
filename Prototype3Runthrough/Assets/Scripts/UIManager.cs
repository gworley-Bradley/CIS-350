/*
 * (Gavin Worley)
 * (Prototype 3)
 * (Brief description of the code in the file.
 *  Manages the UI for the player to see score and updates)
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

    public PlayerController playerControllerScript;

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
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        scoreText.text = "Score: 0";

    }

    // Update is called once per frame
    void Update()
    {

        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!" + "\n" + "Press R to Try Again";
        }
        //if the player reaches 10 score they win
        if (score >= 10)
        {
            playerControllerScript.gameOver = true;
            won = true;

           // playerControllerScript.StopRunning();

            scoreText.text = "You Win!" + "\n" + "Press R to Try Again!";
        }
        //Allows the player to restart the game whether they won or lost
        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
