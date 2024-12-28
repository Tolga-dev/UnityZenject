using UnityEngine;

namespace Zenject.E1
{
    public class Player : MonoBehaviour
    {
        private IWeapon _weapon;

        // The weapon is injected via the constructor
        [Inject]
        public void Construct(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void PerformAttack()
        {
            _weapon.Attack();
        }
    }

}