using Actors.Player;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //Container.InstantiateComponent<PlayerController>(Helpers.GameHelper.PlayerGameObject);
        //Container.InstantiateComponent<GameUIController>(Helpers.GameHelper.CanvasGameObject);
        Container.Bind<Player>().AsSingle().Lazy();
    }
}