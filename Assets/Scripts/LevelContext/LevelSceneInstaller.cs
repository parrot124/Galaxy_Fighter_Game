using GameScripts.Input;
using Zenject;

public class LevelSceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<CustomInput>().AsSingle().NonLazy();
        Container.Bind<LevelManager>().AsSingle();
        Container.Bind<InputReader>().AsSingle();
        Container.Bind<PlayerController>().AsSingle();
    }
}