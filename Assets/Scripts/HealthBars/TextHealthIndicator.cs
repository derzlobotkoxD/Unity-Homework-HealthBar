using TMPro;
using UnityEngine;

public class TextHealthIndicator : HealthIndicator
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void Change() =>
        _text.text = $"{Health.CurrentHealthPoints}/{Health.MaxHealthPoints}";
}