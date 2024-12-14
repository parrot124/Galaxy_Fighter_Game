using ScriptableObjects;
using UnityEngine;
using System;
using TMPro;

public class LevelDataDisplay : MonoBehaviour
{
    public event Action<Level> ClickedEvent;

    [Header("Set in inspector")]
    [SerializeField] private TextMeshProUGUI Header;
    [SerializeField] private TextMeshProUGUI Description;

    private Level level;

    private void Start()
    {
        SetupUIComponent();
    }

    private void SetupUIComponent()
    {
        level = transform.parent.GetComponent<LevelListDisplay>().GetLevel(this);

        Header.text = level.Name;
        Description.text = level.Description;

        LevelSelector.Instance.RegisterButton(this);

        GetComponentInChildren<UnityEngine.UI.Button>().onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        ClickedEvent?.Invoke(level);
    }
}
