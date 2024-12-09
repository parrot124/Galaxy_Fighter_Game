using Zenject;
using Input;

public class LevelSceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<CustomInput>().AsSingle().NonLazy();
        Container.Bind<InputReader>().AsSingle();
        Container.Bind<PlayerController>().AsSingle();
    }
}