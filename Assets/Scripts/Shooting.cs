using UnityEngine;
using UnityEngine.InputSystem;

public class shooting : MonoBehaviour
{
    [SerializeField] private GameObject m_projectile;
    [SerializeField] private Transform m_firePoint;
    [SerializeField] private float m_bulletSpeed = 50;
    [SerializeField] private float m_fireRate;
    private float m_fireTimeout = 0;

    Vector2 lookDirection;
    float lookAngle;

    private InputAction m_attackAction;

    private void Awake()
    {
        m_attackAction = InputSystem.actions.FindAction("Attack");
    }

    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //This math code is calculating the angle that the vector is pointing to
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        //setting the rotation of the firepoint to the lookangle vector
        m_firePoint.rotation = Quaternion.Euler(0, 0, lookAngle);

        //creating the bullet on the attack action and when the fire timeout has ended
        if (m_attackAction.IsPressed() && Time.time > m_fireTimeout)
        {
            m_fireTimeout = Time.time + m_fireRate;
            GameObject bulletClone = Instantiate(m_projectile);
            bulletClone.transform.position = m_firePoint.position;

            //setting the bullet clones to face the look angle position
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            //adding velocity to the bullets
            bulletClone.GetComponent<Rigidbody2D>().linearVelocity = m_firePoint.right * m_bulletSpeed;
        }
    }
}
