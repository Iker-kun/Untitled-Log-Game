using AttackSystem.Attacker;
using InteractionSystem.Data;

namespace AttackSystem.Interaction
{
    internal interface IAttackerInteractionResponse : IInteractionResponse
    {
        IAttacker GetAttacker();
    }
}
