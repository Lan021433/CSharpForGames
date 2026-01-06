using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public int m_score;

    public void AddScore(int ScoreToAdd)
    {
        m_score += ScoreToAdd;
    }

    public int GetScore()
    {
        return m_score;
    }
}
