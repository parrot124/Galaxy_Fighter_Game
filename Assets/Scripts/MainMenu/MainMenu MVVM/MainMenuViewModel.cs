using System;

/// <summary>
/// The "ViewModel" component of the main menu main section
/// </summary>
public class MainMenuViewModel
{
    public MainMenuViewModel()
    {
        MainMenuStateMachine.OnStateChange += OnStateChange;
    }

    //what to do here? checking specific type of state is gonna be VERY dumb
    private void OnStateChange(IMainMenuState state)
    {
        throw new NotImplementedException();
    }
}
