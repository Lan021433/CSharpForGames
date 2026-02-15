using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimeManager : MonoBehaviour
{
    [SerializeField] private float m_timer;
    [SerializeField] private TMPro.TextMeshProUGUI m_timerText;

    [SerializeField] private GameObject m_winscreenPanel;

    [SerializeField] private AudioSource m_winSound;

    //sets the win screen to false at the start of the level
    private void Start()
    {
        m_winscreenPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if statement to prevent the countdown timer going negative
        if (m_timer > 0)
        {
            m_timer -= Time.deltaTime;
        }
        else if (m_timer < 0)
        {
            m_timer = 0;
            //plays the wins ound and activates the win screen
            m_winSound.Play();
            m_winscreenPanel.SetActive(true);
            Time.timeScale = 0f;
        }

        //used to set the visual layout of the timer
        int Minutes = Mathf.FloorToInt(m_timer / 60);
        int Seconds = Mathf.FloorToInt(m_timer % 60);
        m_timerText.text = string.Format("{00:00}:{1:00}", Minutes, Seconds);
    }
}
