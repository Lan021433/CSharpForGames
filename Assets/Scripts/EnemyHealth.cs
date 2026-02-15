using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float m_maxHealth = 100;
    private float m_currentHealth;

    public Animator m_animator;

    [SerializeField] private AudioSource m_enemydeathSound;

    void Start()
    {
        m_currentHealth = m_maxHealth;
    }

    void Update()
    {
        if (m_currentHealth <= 0)
        {
            m_animator.SetTrigger("Dead");
            StartCoroutine(Death());
        }
    }

    //A damage void that can be called by other scripts to deal damage to the enemy's health
    public void Damage(int damage)
    {
        m_currentHealth -= damage;
        m_enemydeathSound.Play();
        Debug.Log("Enemy - OW!");

        m_animator.SetTrigger("Hurt");
    }

    //This Enum is used to give the death animation time to play out
    IEnumerator Death()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject, 1);
    }
}
