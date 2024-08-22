using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealthPoints = 3;

    public event UnityAction Changed;

    public float CurrentHealthPoints { get; private set; }
    public float MaxHealthPoints => _maxHealthPoints;

    private void Awake()
    {
        if (CurrentHealthPoints == 0)
            CurrentHealthPoints = _maxHealthPoints;
    }

    public void Decrease(float damage)
    {
        if (damage <= 0)
            return;

        CurrentHealthPoints = Mathf.Clamp(CurrentHealthPoints - damage, 0, _maxHealthPoints);
        Changed?.Invoke();
    }

    public void TryRestore(float health)
    {
        if (health <= 0)
            return;

        CurrentHealthPoints = Mathf.Clamp(CurrentHealthPoints + health, 0, _maxHealthPoints);
        Changed?.Invoke();
    }
}