using Actors.Player;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Zenject;
using System;

[RequireComponent(typeof(Canvas))]
public class GameUIController : MonoBehaviour
{
    private Canvas UI;

    private VerticalLayoutGroup healthSpriteLayout;
    private TextMeshProUGUI scoreText;
    private Button pauseButton;

    private Player player;

    [Inject]
    private void SubscribeToPlayerStatsChange(LazyInject<Player> playerObject)
    {
        player = playerObject.Value;
        player.StatsChangedEvent += OnStatsChange;
    }

    private void Start()
    {
        UI = GetComponent<Canvas>();

        healthSpriteLayout = GetComponentInChildren<VerticalLayoutGroup>();
        scoreText = GetComponentInChildren<TextMeshProUGUI>();
        pauseButton = GetComponentInChildren<Button>();

        OnStatsChange(player.Stats);
    }

    private void OnStatsChange(PlayerStats stats)
    {
        scoreText.text = player.Stats.Score.ToString();
               
        //throw new NotImplementedException("OnStatsChange isn't implemented");
    }
}