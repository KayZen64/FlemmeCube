using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public PlayerMovement m_PlayerMovement;

    public void OnMove(InputAction.CallbackContext context)
    {
        float newMoveInput = context.ReadValue<float>();
        m_PlayerMovement.SetMoveInput(newMoveInput);
    }
}