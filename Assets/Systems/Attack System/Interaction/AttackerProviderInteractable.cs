using AttackSystem.Attacker;
using InteractionSystem.Interactable;
using UnityEngine;

namespace AttackSystem.Interaction
{
    internal class AttackerProviderInteractable : MonoBehaviour, IResponseOnlyInteractable<IAttackerProvisionResponse>
    {
        public IAttackerProvisionResponse TryInteract()
        {
            IAttacker attacker = GetComponent<IAttacker>();
            return new AttackerProvisionResponse(attacker, attacker != null);
        }
    }
}