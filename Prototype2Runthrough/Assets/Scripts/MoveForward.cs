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
