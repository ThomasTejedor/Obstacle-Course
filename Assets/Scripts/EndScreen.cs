using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public Text hitsText;
    public void Setup(int hits) {
        gameObject.SetActive(true);
        hitsText.text = "Hits: " + hits; 
    }
}
