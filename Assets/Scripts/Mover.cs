using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] GameController gc; 
    public Rigidbody rb;
    [SerializeField] float speed = 20;
    private bool grounded = false;
    private bool isJumpPressed = false;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if(gc.isEnded()) return;
        isJumpPressed = Input.GetButtonDown("Jump");
        if(isJumpPressed && grounded){
            grounded = false;
            Jump();
        }
        MovePlayer();
        
    }

    private void OnCollisionStay(Collision collision) {
        if(collision.gameObject.tag == "Ground") {
            grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision) {
        if(collision.gameObject.tag == "Ground") {
            grounded = false;
        }
    }

    void Jump() {
        rb.velocity = new Vector3(0,3,0);
    }
    void MovePlayer() {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xValue, 0, zValue); 
    }
}
