using UnityEngine;
using UnityEngine.UI;

public class AttackButton : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _button;
    [SerializeField] private float _damage = 10f;

    private void OnEnable() =>
        _button.onClick.AddListener(Attack);

    private void OnDisable() =>
        _button.onClick.RemoveListener(Attack);

    private void Attack() =>
        _health.Decrease(_damage);
}