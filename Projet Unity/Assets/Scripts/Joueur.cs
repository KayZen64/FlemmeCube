    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Joueur : MonoBehaviour {

    public InputMaster controls;
    public float JumpForce, MoveSpeed;
    public Transform groundCheck;
    public LayerMask groundlayer;
    bool isGrounded;
    public Rigidbody2D RG2D;
    public Vector2 moveVal;
    float AxisX;

    // Invisibility ability
    public float invTime = 5.0f;
    public float invCooldown = 5.0f;
    bool isInvEnabled;
    public Texture2D invTexture;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    private Sprite oldSprite;

    private void Start() {
        RG2D = GetComponent<Rigidbody2D>();

        MoveSpeed = 10f;
        JumpForce = 11f;
    }

    private void Awake() {
        controls = new InputMaster();
        controls.Joueur.Jump.performed += context => Jump();
        controls.Joueur.Invisibility.performed += context => Invisibility();
    }

    void OnMove(InputValue value) {
        moveVal = value.Get<Vector2>();
    }

    void Mouvement(Vector2 direction) {
        RG2D.velocity = new Vector2(MoveSpeed * direction.x, RG2D.velocity.y);
    }

    void Jump() {
        if(isGrounded) {
            RG2D.velocity = new Vector2(RG2D.velocity.x, JumpForce);
        }
    }

    void Invisibility() {
        if(!isInvEnabled) {
            Debug.Log("startinvisibility");
            isInvEnabled = true;
            oldSprite = spriteRenderer.sprite;
            spriteRenderer.sprite = newSprite;
            StartCoroutine(InvCoroutine());
        }
        else {
            Debug.Log("Invisibilité déjà activée");
        }
    }

    IEnumerator InvCoroutine() {
        Debug.Log("Coroutine démarrée " + Time.time);
        yield return new WaitForSeconds(invTime);
        spriteRenderer.sprite = oldSprite; 
        Debug.Log("Coroutine finie " + Time.time);

        yield return new WaitForSeconds(invCooldown);
        isInvEnabled = false;
    }


    private void OnEnable() {
        controls.Enable();
    }

    private void OnDisable() {
        controls.Disable();
    }

    private void Update()
    {
        // transform.position += new Vector3(moveVal.x, 0 , 0) * Time.deltaTime * MoveSpeed;
        Mouvement(moveVal);
        // transform.Translate(new Vector3(moveVal.x, 0 , 0) * MoveSpeed * Time.deltaTime);

        // Crounching
        // if(MovY == -1){
        //     transform.localScale = new Vector2(1f, 0.5f);
        // }

        // else{
        //     transform.localScale = new Vector2(1f, 1f);
        // }
    
    isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
    }
    
}