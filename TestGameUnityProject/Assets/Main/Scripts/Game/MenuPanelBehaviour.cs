using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPanelBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;

    private void Awake()
    {
        Hide();
    }

    public void Show()
    {
        _menuPanel.SetActive(true);
    }
    public void Hide()
    {
        _menuPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
