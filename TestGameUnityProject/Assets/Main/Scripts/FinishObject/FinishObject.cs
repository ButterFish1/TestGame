using UnityEngine;

public class FinishObject : MonoBehaviour
{
    [SerializeField] private MenuPanelBehaviour _menuPanel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<PlayerHealth>(out var health))
        {
            _menuPanel.Show();
        }
    }
}
