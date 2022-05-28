using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CompteurPatates : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int scoreValue = 0;
    bool patateAjoutee = false; 
    
    void OnTriggerEnter2D(Collider2D coll) {
        if(!patateAjoutee)
        {
            CompteurPatates.scoreValue += 1;
            scoreText.text = "" + scoreValue;
            patateAjoutee = true;
        }
    }
}