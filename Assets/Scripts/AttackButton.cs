using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttackButton : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _button;
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _damage = 10f;

    private float _maxDamage = 120f;

    private void Awake()
    {
        _slider.minValue = 0;
        _slider.maxValue = _maxDamage;
        _slider.value = _damage;
        UpdateDamageText(_damage);
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(Attack);
        _slider.onValueChanged.AddListener(UpdateDamageText);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Attack);
        _slider.onValueChanged.RemoveListener(UpdateDamageText);
    }

    private void Attack() =>
        _health.Decrease(_slider.value);

    private void UpdateDamageText(float damage) =>
        _text.text = damage.ToString();
}