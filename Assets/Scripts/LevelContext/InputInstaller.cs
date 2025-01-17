using GameScripts.Input;
using GameScripts.Static;
using Zenject;

public class InputInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<InputReader>().AsSingle().Lazy();
        Container.Bind<CustomInput>().AsSingle().Lazy();
    }
}