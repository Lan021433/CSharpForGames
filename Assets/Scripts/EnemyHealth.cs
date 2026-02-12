using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float m_maxHealth = 100;
    private float m_currentHealth;

    void Start()
    {
        m_currentHealth = m_maxHealth;
    }

    void Update()
    {
        if (m_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Damage(int damage)
    {
        m_currentHealth -= damage;
        Debug.Log("Enemy - OW!");
    }
}
