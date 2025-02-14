using UnityEngine;

public class Trap : MonoBehaviour
{
    private int _damage;

    public void Initialize()
    {
        GetStatsFromConfig();
    }

    private void Awake()
    {
        Initialize();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter");
        if(other.TryGetComponent<PlayerHealth>(out var playerHealth))
        {
           playerHealth.TakeDamage(_damage);
        }
    }

    private void GetStatsFromConfig()
    {
        var config = Resources.Load<TrapConfig>("TrapConfig");
        _damage = config.Damage;
    }
}

