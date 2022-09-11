/*
 * (Gavin Worley)
 * (Challenge 2)
 * (Brief description of the code in the file.
 *  Keeps track of player health and score, also decides game win or lose)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthSystem : MonoBehaviour
{
    public int health;
    public int score;
    public int maxHealth;
    public List<Image> hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public bool gameOver = false;
    public bool gameWin = false;
    public GameObject gameOverText;
    public GameObject gameWinText;


    void Update()
    {
        //If health is somehow more than max health, set health to max health
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        for (int i = 0; i < hearts.Count; i++)
        {
            //Display full or empty heart sprite based on current health
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            //Show the number of hearts equal to current max health
            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if (score >= 5 && health > 0)
        {
            gameWin = true;
            gameWinText.SetActive(true);
            //Press R to restart if game is won
            if (Input.GetKeyDown(KeyCode.R))
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (health <= 0)
        {
            gameOver = true;
            gameOverText.SetActive(true);
            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public void TakeDamage()
    {
        health--;
    }
}
