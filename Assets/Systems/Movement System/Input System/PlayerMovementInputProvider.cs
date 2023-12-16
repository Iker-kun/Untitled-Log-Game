using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementInputProvider : MonoBehaviour
{
    [SerializeField]
    private InputActionReference _movementAction;

    [SerializeField]
    private InputActionReference _sprintAction;

    private bool _isSprinting = false;

    public MovementInput MovementInput { get; private set; }

    private void Awake()
    {
        _sprintAction.action.performed += OnSprintActionPerformed;
    }

    private void OnDestroy()
    {
        _sprintAction.action.performed-= OnSprintActionPerformed;
    }


    private void OnEnable()
    {
        _movementAction.action.Enable();
        _sprintAction.action.Enable();
    }

    private void OnDisable()
    {
        _movementAction.action.Disable();
        _sprintAction.action.Disable();
    }


    private void Update()
    {
        Vector2 movementInput = _movementAction.action.ReadValue<Vector2>();

        MovementInput completeMovement;
        completeMovement.isSprinting = _isSprinting;
        completeMovement.movement = movementInput;

        MovementInput = completeMovement;
    }

    private void OnSprintActionPerformed(InputAction.CallbackContext obj)
    {
        _isSprinting = !_isSprinting;

    }

}
