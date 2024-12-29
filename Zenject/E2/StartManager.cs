using System;
using UnityEngine;

namespace Zenject.E2
{
    public class StartManager : MonoBehaviour
    {
        [Inject]
        private Foo _foo;
        
        private void Start()
        {
            _foo.SayHello();
        }
    }
}