using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Joueur : MonoBehaviour {

    public InputMaster controls;

    private void Awake() {
        controls = new InputMaster();
        controls.Joueur.Saut.performed += context => Saut();
        controls.Joueur.Deplacement.performed += context => Mouvement(context.ReadValue<Vector2>());
    }

    void Mouvement(Vector2 direction) {
        Debug.Log("Déplacement effectué" + direction);
    }

    void Saut() {
        Debug.Log("Saut effectué");
    }

    private void OnEnable() {
        controls.Enable();
    }

    private void OnDisable() {
        controls.Disable();
    }
}