using Zenject;

public class SceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<CustomInput>().AsSingle().NonLazy();
        Container.Bind<InputReader>().AsSingle().NonLazy();
        Container.Bind<PlayerController>().AsSingle();
    }
}