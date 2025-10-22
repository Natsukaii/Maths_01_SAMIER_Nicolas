using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumper : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerCharacter>())
        {
            other.GetComponent<PlayerCharacter>().StartJump();
        }
    }
}

