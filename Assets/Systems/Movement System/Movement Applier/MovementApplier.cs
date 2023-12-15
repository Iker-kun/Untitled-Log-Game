using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementApplier : MonoBehaviour
{
    [SerializeField]
    private MovementPerformer _performer;

    [SerializeField]
    private PlayerMovementInputProvider _provider;

    private void FixedUpdate()
    {
        _performer.TryMove(_provider.MovementInput);
    }

}
