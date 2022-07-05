using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangementDeNiveau : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col) {
            Invoke("NextLevel", 0.3f);
        }

    public void NextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}