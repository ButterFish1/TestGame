using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<PlayerHealth>(out var health))
        {
            EventBus.GameLose?.Invoke();
        }
    }
}
