/*
 * (Gavin Worley)
 * (Prototype 3)
 * (Brief description of the code in the file.
 *  Is used to move the background and obstacles left)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float speed = 30f;
    private float leftBound = -15;

    private PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            //move left
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }
            // if the gameObject this is attached to is < leftBound and tagged Obstacle, then the object will be destroyed
            if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
            {
                Destroy(gameObject);
            }
        
    }
}
