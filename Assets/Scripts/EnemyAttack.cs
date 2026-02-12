using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private int m_collisionDamage = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Health>().Damage(m_collisionDamage);
        }
    }
}
