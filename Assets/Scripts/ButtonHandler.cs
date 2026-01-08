using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public ScoreSystem m_scoreSystem;
    private int m_score;

    public void AddScore()
    {
        m_score += 10;
    }
}
