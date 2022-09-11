/*
 * (Gavin Worley)
 * (Challenge 2)
 * (Brief description of the code in the file.
 *  Used to move the dog prefab at a set speed)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Moves the dog forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
