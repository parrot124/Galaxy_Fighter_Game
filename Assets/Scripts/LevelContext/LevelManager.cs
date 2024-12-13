using LevelContext.Factories;

public class LevelManager
{
    private EnemyCreator enemyCreator;

    public LevelManager()
    {
        enemyCreator = new();
    }
}