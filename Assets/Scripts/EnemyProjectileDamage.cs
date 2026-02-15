using UnityEngine;

public class EnemyProjectileDamage : MonoBehaviour
{
    [SerializeField] private int m_enemybulletDamage = 5;

    [SerializeField] private AudioSource m_hitSound;

    //when the player is hit by the projectile, the damage code in the health script will be activated
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Health>().Damage(m_enemybulletDamage);
            m_hitSound.Play();
            Destroy(gameObject);
        }

    }
}
