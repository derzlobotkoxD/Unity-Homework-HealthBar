using TMPro;
using UnityEngine;

public class TextHealthIndicator : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Health _health;

    private void Start() =>
        Change();

    private void OnEnable() =>
        _health.Changed += Change;

    private void OnDisable() =>
        _health.Changed -= Change;

    private void Change() =>
        _text.text = $"{_health.CurrentHealthPoints}/{_health.MaxHealthPoints}";
}