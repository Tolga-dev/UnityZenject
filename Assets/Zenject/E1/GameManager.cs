using UnityEngine;

namespace Zenject.E1
{
    public class GameManager : MonoBehaviour
    {
        [Inject] private Player _player;

        private void Start()
        {
            _player.PerformAttack();
        }
    }
}