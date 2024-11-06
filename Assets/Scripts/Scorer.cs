using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] GameController gc;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "Hit" && other.gameObject.tag != "Ground") {

            gc.increaseHits();
            Debug.Log("You bumped into " + gc.getHits() + " obstacles!"); 
        }

    }

}
