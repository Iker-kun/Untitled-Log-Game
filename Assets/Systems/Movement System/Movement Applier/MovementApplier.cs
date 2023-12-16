using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementApplier : MonoBehaviour
{
    [SerializeField]
    private MovementPerformer _performer;

    [SerializeField]
    private PlayerMovementInputProvider _movProvider;

    [SerializeField]
    private float _baseSpeed = 1.0f;

    [SerializeField]
    private float _speedMultiplier = 1.0f;

    private void FixedUpdate()
    {
        MovementInput completeMovement = _movProvider.MovementInput;
        if (completeMovement.isSprinting)
        {
            _performer.TryMove(completeMovement.movement * _baseSpeed * _speedMultiplier);
        }
        else
        {
            _performer.TryMove(completeMovement.movement * _baseSpeed);
        }

        

    }

}
