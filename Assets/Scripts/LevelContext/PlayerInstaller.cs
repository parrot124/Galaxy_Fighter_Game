using Actors.Player;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Player>().AsSingle().Lazy();
    }
}