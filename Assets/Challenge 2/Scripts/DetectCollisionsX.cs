using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    //detects collisions and destroys the collided objects
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
       
    }
}

