using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{

    Vector3 inputDirection = Vector3.zero;

    [SerializeField]
    public MovementController MovementController;

    public void OnMove(InputAction.CallbackContext context) { 
        inputDirection = context.ReadValue<Vector2>();
        
        MovementController.direction = inputDirection;
    }
}
