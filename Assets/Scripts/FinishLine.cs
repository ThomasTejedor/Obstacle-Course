using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    private bool gameEnd;
    // Start is called before the first frame update
    void Start()
    {
        gameEnd = false;
    }

    void OnTriggerEnter(Collider collider){
        gameEnd = true;
    }
}
