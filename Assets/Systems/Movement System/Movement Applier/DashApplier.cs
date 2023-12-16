using UnityEngine;


public class DashApplier : MonoBehaviour
{
    [SerializeField]
    private MovementPerformer _performer;

    [SerializeField]
    private PlayerDashInputProvider _dashProvider;

    [SerializeField]
    private PlayerMovementInputProvider _movProvider;

    [SerializeField]
    private float _speedIncrease = 1.0f;
    [SerializeField]
    private float _speedIncreaseTime = 1.0f;

    private Vector2 _lastValidDirection = Vector2.right;

    private void Awake()
    {
        _dashProvider.DashPerformed.AddListener(OnDashPerformed);
    }

    private void OnDestroy()
    {
        _dashProvider.DashPerformed.RemoveListener(OnDashPerformed);
    }

    private void Update()
    {
        if (_movProvider.MovementInput.movement != Vector2.zero)
        {
            _lastValidDirection = _movProvider.MovementInput.movement;

        }
    }

    private void OnDashPerformed()
    {
        //m * dv = f * dt
        // f = m * dv/dt
        Vector2 dashAcceleration = (_speedIncrease/ _speedIncreaseTime)  * _lastValidDirection;
        _performer.TryDash(dashAcceleration);
    }
}