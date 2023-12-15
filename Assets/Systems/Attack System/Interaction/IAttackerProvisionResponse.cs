using AttackSystem.Attacker;
using InteractionSystem.Data;

namespace AttackSystem.Interaction
{
    internal interface IAttackerProvisionResponse : IInteractionResponse
    {
        IAttacker GetAttacker();
    }
}
