using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Image m_healthBar;

    [SerializeField] private float m_maxHealth = 100;
    private float m_currentHealth;

    void Start()
    {
        m_currentHealth = m_maxHealth;
    }

    void Update()
    {
        m_healthBar.fillAmount = m_currentHealth / m_maxHealth;
    }
}
