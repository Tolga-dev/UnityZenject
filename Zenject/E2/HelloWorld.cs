using UnityEngine;
using Zenject.E1;

namespace Zenject.E2
{
    public class TestInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<string>().FromInstance("Hello World!");
            Container.Bind<Greeter>().AsSingle().NonLazy();
            Container.Bind<Foo>().AsSingle().NonLazy();
        }
        
    }
    public class Foo
    {
        private Greeter _greeter;

        [Inject]
        public void Init(Greeter greeter)
        {
            _greeter = greeter;
        }

        public void SayHello()
        {
            _greeter.SayHi();
        }
    }
    
    public class Greeter
    {
        private string _message;
        public Greeter(string message)
        {
            _message = message;
        }

        public void SayHi()
        {
            Debug.Log(_message);
        }
    }
}