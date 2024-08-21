using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;

    private void Start()
    {
        _slider.maxValue = _health.MaxHealthPoints;
        Change();
    }

    private void OnEnable() =>
        _health.Changed += Change;

    private void OnDisable() =>
        _health.Changed -= Change;

    private void Change() =>
        _slider.value = _health.CurrentHealthPoints;
}
