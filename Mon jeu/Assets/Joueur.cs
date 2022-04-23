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
        JumpForce = 6f;

        Jumping = true;
    }

    private void Awake() {
        controls = new InputMaster();
        controls.Joueur.Saut.performed += context => Saut();
        controls.Joueur.Deplacement.performed += context => Mouvement(context.ReadValue<Vector2>());
    }

    void Mouvement(Vector2 direction) {
        RG2D.velocity = new Vector2(MoveSpeed * direction.x, RG2D.velocity.y);
    }

    void Saut() {
        if(!Jumping) {
            RG2D.velocity = new Vector2(RG2D.velocity.x, JumpForce);
            Jumping = true;
        }
    }

    private void OnEnable() {
        controls.Enable();
    }

    private void OnDisable() {
        controls.Disable();
    }

    void Update()
    {

        // Crounching
        // if(MovY == -1){
        //     transform.localScale = new Vector2(1f, 0.5f);
        // }

        // else{
        //     transform.localScale = new Vector2(1f, 1f);
        // }
    
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Floor") {
            Jumping = false;
        }
        else {
            Jumping = true;
        }
    }
}