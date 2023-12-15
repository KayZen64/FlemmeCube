using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveInput;
   
    [Header("References")]
    public Rigidbody2D rb;

    [Header("RunParams")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float decceleration;
    [SerializeField] private float acceleration;
    [SerializeField] private float velPower;

    private void FixedUpdate()
    { 
    
        #region Run
        float targetSpeed = moveInput * moveSpeed;
        float speedDif = targetSpeed - rb.velocity.x;
        float accelRate = (Mathf.Abs(targetSpeed) > 0.01f) ? acceleration : decceleration;
        float movement = Mathf.Pow(Mathf.Abs(speedDif) * accelRate, velPower) * Mathf.Sign(speedDif);

        rb.AddForce(movement * Vector2.right);

        #endregion

    }

    public void SetMoveInput(float newMoveInput)
    {
        moveInput = newMoveInput;
    }
}