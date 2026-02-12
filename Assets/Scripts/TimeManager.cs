using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimeManager : MonoBehaviour
{
    [SerializeField] private float m_timer;
    [SerializeField] private TMPro.TextMeshProUGUI m_timerText;

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
        }

        //used to set the visual layout of the timer
        int Minutes = Mathf.FloorToInt(m_timer / 60);
        int Seconds = Mathf.FloorToInt(m_timer % 60);
        m_timerText.text = string.Format("{00:00}:{1:00}", Minutes, Seconds);
    }
}
