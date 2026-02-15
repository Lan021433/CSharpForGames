using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Image m_healthBar;

    [SerializeField] private float m_maxHealth = 100;
    private float m_currentHealth;

    [SerializeField] private GameObject m_deathscreenPanel;

    [SerializeField] private AudioSource m_deathSound;
    [SerializeField] private AudioSource m_healingSound;

    void Start()
    {
        m_currentHealth = m_maxHealth;
        //sets the death screen to be false on startup of level
        m_deathscreenPanel.SetActive(false);
    }

    void Update()
    {
        m_healthBar.fillAmount = m_currentHealth / m_maxHealth;
        if (m_currentHealth <= 0)
        {
            //activates the death screen when the player's health sits zero
            m_deathscreenPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    //a public void that allows me to damage the player through other scripts and play a sound
    public void Damage(int damage)
    {
        m_currentHealth -= damage;
        m_deathSound.Play();
        Debug.Log("Player - OW!");
    }

    //the opposite of dmaage, allowing the player to be healed by other scripts and activating the sound effect
    public void Healing(int healing)
    {
        m_currentHealth += healing;
        m_healingSound.Play();
    }
}
