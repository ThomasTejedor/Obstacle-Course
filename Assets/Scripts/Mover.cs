using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] float speed = 20;
    private bool isJumpPressed = false;
    // Start is called before the first frame update
    void Start() {
        PrintInstructions();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        isJumpPressed = Input.GetButtonDown("Jump");
        if(isJumpPressed){
            Jump();
        }
        MovePlayer();
        
    }

    void PrintInstructions() {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
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
