using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Joueur : MonoBehaviour {

    public InputMaster controls;
    public float JumpForce, MoveSpeed;
    public bool Jumping;
    public Rigidbody2D RG2D;

    void Start() {
        RG2D = GetComponent<Rigidbody2D>();

        MoveSpeed = 6f;
        JumpForce = 8f;

        Jumping = true;
    }

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
        RG2D.velocity = new Vector2(RG2D.velocity.x, JumpForce);
    }

    private void OnEnable() {
        controls.Enable();
    }

    private void OnDisable() {
        controls.Disable();
    }
}