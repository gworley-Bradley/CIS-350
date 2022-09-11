/*
 * (Gavin Worley)
 * (Prototype 2)
 * (Brief description of the code in the file.
 *  Dedicated for prefabs to move at a certain speed)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 20;

    // Update is called once per frame
    void Update()
    {
        //Moves the prefabs forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
