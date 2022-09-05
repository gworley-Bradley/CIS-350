/*
 * (Gavin Worley)
 * (Challenge 1)
 * (Brief description of the code in the file.
 *  Script to rotate the prop to look as if its flying the plane)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 25;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed);
    }
}
