using UnityEngine;

public class ProjectileDamage : MonoBehaviour
{
    [SerializeField] private int m_bulletDamage = 50;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealth>().Damage(m_bulletDamage);
            Destroy(gameObject);
        }
    }
}
