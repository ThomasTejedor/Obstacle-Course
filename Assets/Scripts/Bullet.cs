using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody rb;
    private bool isDestroyable = false;
    
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        
        if(isDestroyable)
            Destroy(gameObject);

    }

    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
        StartCoroutine(setDestroyable());

    }

    IEnumerator setDestroyable() {
        float timer = .02f;
        while(timer > 0){
            timer -= Time.deltaTime;
            yield return null;
        }
        isDestroyable = true;
        
    }
    void Update() {
        rb.velocity = transform.forward*speed;
    }
}
