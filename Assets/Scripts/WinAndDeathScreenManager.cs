using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinAndDeathScreenManager : MonoBehaviour
{
    [SerializeField] private GameObject m_winPanel;
    [SerializeField] private GameObject m_deathPanel;

    //the two play level void will run the first and second respectively
    public void PlayLevel1()
    {
        SceneManager.LoadScene("StudentLevel");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("CatacombsRealLevel");
    }

    //will load the main menu scene
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
