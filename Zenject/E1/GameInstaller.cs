namespace Zenject.E1
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            // Bind the IWeapon interface to the Sword implementation
            Container.Bind<IWeapon>().To<Sword>().AsTransient();

            // Bind the Player class
            Container.Bind<Player>().FromComponentInHierarchy().AsTransient();
        }
    }
}