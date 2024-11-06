using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    static private int hits;
    static private bool gameEnded = false;
    public EndScreen endScreen;

    public void Start() {
        PrintInstructions();
    }
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
    void PrintInstructions() {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("You can also jump with the spcae bar");
        Debug.Log("Don't hit the walls!");
    }
}
