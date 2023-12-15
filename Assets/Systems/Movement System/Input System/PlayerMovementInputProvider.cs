using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementInputProvider : MonoBehaviour
{
    [SerializeField]
    private InputActionReference _movementAction;

    public Vector2 MovementInput { get; private set; }



    private void OnEnable()
    {
        _movementAction.action.Enable();
    }

    private void OnDisable()
    {
        _movementAction.action.Disable();
    }


    private void Update()
    {
        Vector2 movementInput = _movementAction.action.ReadValue<Vector2>();

        MovementInput = movementInput;
    }

}
