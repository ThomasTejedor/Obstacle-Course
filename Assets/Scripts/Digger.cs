using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digger : MonoBehaviour
{
    [SerializeField] float digAmount = 5f;
    [SerializeField] float digSpeed = 10f;
    [SerializeField] float startPosition = 0f; 
    private float startY;
    private float goingDown;

    // Start is called before the first frame update
    void Start()
    {
        goingDown = -1;
        startY = transform.position.y;
        transform.position = new Vector3(transform.position.x, startY - startPosition, transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        float yAxis = goingDown * Time.deltaTime * digSpeed; 
        transform.Translate(0, yAxis, 0);
        if(transform.position.y > startY || transform.position.y < startY - digAmount){
            goingDown *= -1;
        }
    }
}
