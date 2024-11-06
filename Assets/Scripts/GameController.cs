using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    static private int hits;
    static private bool gameEnded = false;
    public EndScreen endScreen;
    public void endGame() {
        gameEnded = true;
        endScreen.Setup(hits);

    }
    public void increaseHits(){
        if(gameEnded) return;
        hits++;
    }

    public int getHits(){
        return hits;
    }

    public bool isEnded(){
        return gameEnded;
    }

    public void restartGame() {
        hits = 0; 
        gameEnded = false;
    }
}
