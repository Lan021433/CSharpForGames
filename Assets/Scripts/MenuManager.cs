using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject m_menuPanel;
    [SerializeField] private GameObject m_controlsPanel;
    private bool m_controlsPanelOpen = false;

    //the two play level void will run the first and second respectively
    public void PlayLevel1()
    {
        SceneManager.LoadScene("StudentLevel");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("CatacombsRealLevel");
    }

    //uses booleans in order to toggle on and off an extra panel on the main menu
    public void ToggleControlsPanel()
    {
        if (m_controlsPanelOpen)
        {
            m_menuPanel.SetActive(true);
            m_controlsPanel.SetActive(false);
        }
        else
        {
            m_menuPanel.SetActive(false);
            m_controlsPanel.SetActive(true);
        }
        m_controlsPanelOpen = !m_controlsPanelOpen;
    }

    //only usuable in the build - ends the application
    public void Quit()
    {
        Application.Quit();
    }

    //will load the main menu scene
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
