using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPerformer : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidbody;

    [SerializeField]
    private float _speed = 1.0f;

    public bool TryMove(Vector2 movementInput)
    {
        Vector2 velocity = _speed * movementInput;

        _rigidbody.velocity = velocity;

        return true;
    }

}