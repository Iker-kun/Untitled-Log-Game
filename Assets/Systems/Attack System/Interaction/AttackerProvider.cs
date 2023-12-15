using AttackSystem.Attacker;
using InteractionSystem.Interactable;
using UnityEngine;

namespace AttackSystem.Interaction
{
    internal class AttackerProvider : MonoBehaviour, IResponseOnlyInteractable<IAttackerInteractionResponse>
    {
        public IAttackerInteractionResponse TryInteract()
        {
            IAttacker attacker = GetComponent<IAttacker>();
            return new AttackerProvisionResponse(attacker, attacker != null);
        }
    }
}