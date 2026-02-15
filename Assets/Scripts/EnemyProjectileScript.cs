using UnityEngine;

public class EnemyProjectileScript : MonoBehaviour
{
    [SerializeField] private GameObject m_enemyProjectile;
    [SerializeField] private Transform m_firePoint;
    [SerializeField] private float m_bulletSpeed = 30f;

    public Animator m_animator;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //creates the bullet at the fire poitn location and add velocity for movement
            GameObject enemyBullet = Instantiate(m_enemyProjectile);
            enemyBullet.transform.position = m_firePoint.position;
            enemyBullet.GetComponent<Rigidbody2D>().linearVelocity = m_firePoint.right * m_bulletSpeed;
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
    }
}
