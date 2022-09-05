/*
 * (Gavin Worley)
 * (Challenge 1)
 * (Brief description of the code in the file.
 *  Follows the player at a dedicated distance and angle for visual aid)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
