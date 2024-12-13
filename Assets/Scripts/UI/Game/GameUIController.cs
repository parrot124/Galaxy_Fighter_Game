using UnityEngine.UI;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Canvas))]
public class GameUIController : MonoBehaviour
{
    private Canvas UI;

    private VerticalLayoutGroup healthSpriteLayout;
    private TextMeshProUGUI scoreText;
    private Button pauseButton;

    void Awake()
    {
        UI = GetComponent<Canvas>();

        healthSpriteLayout = GetComponentInChildren<VerticalLayoutGroup>();
        scoreText = GetComponentInChildren<TextMeshProUGUI>();
        pauseButton = GetComponentInChildren<Button>();
    }
}