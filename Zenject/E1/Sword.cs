using UnityEngine;

namespace Zenject.E1
{
    public interface IWeapon
    {
        void Attack();
    }

    public class Sword : IWeapon
    {
        public void Attack()
        {
            Debug.Log("Sword Attack!");
        }
    }

}