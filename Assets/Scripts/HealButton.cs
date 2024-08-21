using UnityEngine;
using UnityEngine.UI;

public class HealButton : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _button;
    [SerializeField] private float _amountHealing = 10f;

    private void OnEnable() =>
        _button.onClick.AddListener(Heal);

    private void OnDisable() =>
        _button.onClick.RemoveListener(Heal);

    private void Heal() =>
        _health.TryRestore(_amountHealing);
}