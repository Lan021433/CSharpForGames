using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public ScoreSystem m_scoreSystem;

    public TMPro.TextMeshProUGUI m_scoreText;
    void Update()
    {
        m_scoreText.text = "Score" + m_scoreSystem.GetScore();
    }
}
