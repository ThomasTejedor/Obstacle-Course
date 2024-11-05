using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreer : MonoBehaviour
{
    [SerializeField] float hit = 0;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "Hit") {
            hit++;
            Debug.Log("You bumped into " + hit + " obstacles!"); 
        }

    }
}
