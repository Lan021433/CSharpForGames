using UnityEngine;

public class HealingItem : MonoBehaviour
{
    [SerializeField] private int m_restoredHealth = 100;

    //the opposite of the enemy atack script, using the public code of the health script to heal the player
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Health>().Healing(m_restoredHealth);
            Destroy(gameObject);
        }
    }
}
