using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;
    [SerializeField] private float _speedChanging;

    private Coroutine _coroutine;

    private void Start()
    {
        _slider.maxValue = _health.MaxHealthPoints;
        _slider.value = _health.CurrentHealthPoints;
    }

    private void OnEnable() =>
        _health.Changed += Change;

    private void OnDisable() =>
        _health.Changed -= Change;

    private void Change()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(SmoothChange());
    }

    private IEnumerator SmoothChange()
    {
        while(_slider.value != _health.CurrentHealthPoints)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health.CurrentHealthPoints, _speedChanging * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
    }
}
