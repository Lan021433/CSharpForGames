using UnityEngine;
using UnityEngine.InputSystem;

public class MeleeAttack : MonoBehaviour
{
    private InputAction m_Melee;

    [SerializeField] private Transform m_meleeOrigin;
    [SerializeField] private float m_attackRange;
    [SerializeField] private LayerMask m_attackLayer;

    [SerializeField] private int m_attackDamage = 50;

    [SerializeField] private float m_cooldownTime = 0.5f;
    [SerializeField] private float m_cooldownTimer = 0;

    public Animator m_Animator;

    private void Awake()
    {
        m_Melee = InputSystem.actions.FindAction("Melee");
    }

    // Update is called once per frame
    void Update()
    {
        if (m_cooldownTimer <= 0)
        {
            if (m_Melee.IsPressed())
            {
                Debug.Log("MeleePressed");
                Collider2D[] enemiesInRange = Physics2D.OverlapCircleAll(m_meleeOrigin.position, m_attackRange, m_attackLayer);
                foreach (var enemy in enemiesInRange)
                {
                    enemy.GetComponent<EnemyHealth>().Damage(m_attackDamage);
                }
                m_cooldownTimer = m_cooldownTime;
            }
        }
        else
        {
            m_cooldownTimer -= Time.deltaTime;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(m_meleeOrigin.position, m_attackRange);
    }

    public void AnimateAttack()
    {
        m_Animator.SetTrigger("Attacking");
    }
}
