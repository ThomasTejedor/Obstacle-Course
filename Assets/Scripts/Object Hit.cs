using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material.color = Color.red;
            transform.gameObject.tag = "Hit";
            
            Renderer[] children;
            children = GetComponentsInChildren<Renderer>();
            foreach(Renderer child in children) {
                child.material.color = Color.red;
            }
        }

    }

}
