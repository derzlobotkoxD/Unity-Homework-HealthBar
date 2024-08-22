using UnityEngine;
using UnityEngine.UI;

public class HealthBar : HealthIndicator
{
    [SerializeField] protected Slider _slider;

    protected override void Change() =>
        _slider.value = Health.CurrentHealthPoints / Health.MaxHealthPoints;
}
