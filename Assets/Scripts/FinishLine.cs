using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameController gc;

    void OnTriggerEnter(Collider collider){
        gc.endGame();
    }
}
