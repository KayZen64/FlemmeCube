using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareBoss : MonoBehaviour
{
    int impactsNumber;
    public Joueur joueurScript;
    //GameObject patate = GameObject.Find("patate");
    public GameObject patate;


    void Start() {
        patate.transform.localScale = new Vector3(0,0,0);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("test");
        if(other.gameObject.tag == "Player") {
            Debug.Log("Collision à vélocité " + joueurScript.lastVelocity_Y);
            if(joueurScript.lastVelocity_Y < -18) { 
                Debug.Log("Collision effectuée avec" + other.gameObject.tag);
                impactsNumber = impactsNumber +1;
                Debug.Log("Impact Numéro " + impactsNumber);
                if(impactsNumber == 3) {
                    transform.Translate(0,-50,0);
                    patate.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
                }
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
