using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CompteurPatates : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreValue = 0;

    void OnTriggerEnter2D(Collider2D coll) {
        CompteurPatates.scoreValue += 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + scoreValue;
    }
}
