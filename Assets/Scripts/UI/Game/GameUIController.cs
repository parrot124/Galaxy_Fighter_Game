using Actors.Player;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Zenject;

[RequireComponent(typeof(Canvas))]
public class GameUIController : MonoBehaviour
{
    private Canvas UI;

    private VerticalLayoutGroup healthSpriteLayout;
    private TextMeshProUGUI scoreText;
    private Button pauseButton;

    [Inject]
    private void Construct(Player player)
    {
        player.StatsChangedEvent += OnStatsChange;
    }

    void Awake()
    {
        UI = GetComponent<Canvas>();

        healthSpriteLayout = GetComponentInChildren<VerticalLayoutGroup>();
        scoreText = GetComponentInChildren<TextMeshProUGUI>();
        pauseButton = GetComponentInChildren<Button>();

        
    }

    private void OnStatsChange(PlayerStats stats)
    {

    }
}