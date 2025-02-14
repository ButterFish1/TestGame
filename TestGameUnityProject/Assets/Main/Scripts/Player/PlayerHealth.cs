using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public event Action<int> HealthChanged;
    public event Action Died;

    private int _maxHealth;
    private int _health;

    private void Awake()
    {
        Initialize();
    }

    public void Initialize()
    {
        var config = Resources.Load<PlayerConfig>("PlayerConfig");
        _maxHealth = config.MaxHealth;
        _health = _maxHealth;
    }
    public void TakeDamage(int amount)
    {
        _health -= amount;
        HealthChanged?.Invoke(amount);
        if(_health <= 0)
        {
            Died?.Invoke();
            EventBus.GameLose?.Invoke();
        }
    }

    private void Update()
    {

    }
}
