using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementDeNiveau : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col) {
            Debug.Log("test");
            Invoke("NextLevel", 0.3f);
        }

    void NextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}