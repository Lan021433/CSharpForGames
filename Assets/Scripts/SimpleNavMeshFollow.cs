using UnityEngine;
using UnityEngine.AI;

public class SimpleNavMeshFollow : MonoBehaviour
{
    public Transform m_target;
    NavMeshAgent m_agent;
        
    // Start sets what the m_angent actually is to the engine
    void Start()
    {
        m_agent = GetComponent<NavMeshAgent>();
    }

    // Update will constantly make the enemy target the player's position
    void Update()
    {
        m_agent.SetDestination(m_target.position);
    }
}
