/*
 * (Gavin Worley)
 * (Prototype 2)
 * (Brief description of the code in the file.
 *  Allows the player to control their character)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 14;


    // Update is called once per frame
    void Update()
    {
        //Get horizontal input from right and left arrow keys or A and D keys 
        horizontalInput = Input.GetAxis("Horizontal");
        //Player control left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //Keeps the player in the bounds of the game
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
