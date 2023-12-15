using AttackSystem.Attacker;

namespace AttackSystem.Interaction
{
    internal readonly struct AttackerProvisionResponse : IAttackerProvisionResponse
    {
        private readonly IAttacker _attacker;
        public bool Success { get; }

        public AttackerProvisionResponse(IAttacker attacker, bool success)
        {
            _attacker = attacker;
            Success = success;
        }

        public IAttacker GetAttacker() => _attacker;
    }
}