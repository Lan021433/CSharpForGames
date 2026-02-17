using UnityEngine;

public class DetectionArea : MonoBehaviour
{
    [SerializeField] private int m_enemyDamage = 25;

    [SerializeField] private AudioSource m_attackSound;

    public Animator m_animator;
    // Uses the code from the player health to deal damage when the player is detected in the attack range
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Health>().Damage(m_enemyDamage);
            m_attackSound.Play();
            AnimateAttackAnim();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        m_animator.SetBool("CanAttack", false);
    }

    public void AnimateAttackAnim()
    {
        m_animator.SetTrigger("Attack");
        m_animator.SetBool("CanAttack", true);
    }
}
