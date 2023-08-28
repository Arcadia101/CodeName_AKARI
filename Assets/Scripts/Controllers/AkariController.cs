using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class AkariController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera Aimcamera;
    [SerializeField] private float JumpForce;
    [SerializeField] private float Speed;
    private Rigidbody RB;
    private PlayerInput playerInput;
    private PlayerInputActions playerInputActions;
    

    private void Awake()
    {
        RB = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Jump.performed += Jump;
    }
    private void FixedUpdate()
    {
        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        RB.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * Speed, ForceMode.Impulse);
    }
    private void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Jump! " + context.phase);
            RB.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
        
    }

    

    
}
