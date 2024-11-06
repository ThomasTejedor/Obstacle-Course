using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private GameController gc;
    [SerializeField] Text hitsText;
    public void Setup(int hits) {
        gameObject.SetActive(true);
        hitsText.text = "Hits: " + hits; 
    }

    public void RestartButton() {
        gc.restartGame();
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }
}
