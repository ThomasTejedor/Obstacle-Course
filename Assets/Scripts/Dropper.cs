using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float resetTime;
    new MeshRenderer renderer;
    new Rigidbody rigidbody;
    private Vector3 startPos;
    private Quaternion startRotation;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;

        startPos = gameObject.transform.position;
        startRotation = gameObject.transform.rotation;
        InvokeRepeating("Drop", 0, resetTime);
    }

    void Drop(){
        transform.position = startPos;
        rigidbody.velocity = new Vector3(0,0,0);
        transform.rotation = startRotation;
    }
    // Update is called once per frame
    void Update()
    {

        if (Time.time > resetTime) {

            renderer.enabled = true;
            rigidbody.useGravity = true;
            
        }
    }
}
