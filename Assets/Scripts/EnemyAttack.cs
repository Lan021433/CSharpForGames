using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private int m_collisionDamage = 5;

    //Activates when the player tag enters the collider, and deals int damage with the damage code in the player health script
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Health>().Damage(m_collisionDamage);
        }
    }
}
