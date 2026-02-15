using UnityEngine;
using UnityEngine.InputSystem;

public class Newshooting : MonoBehaviour
{
    private Camera m_camera;
    private Vector3 m_mousePosition;

    void Start()
    {
        m_camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
    private void Update()
    {
        m_mousePosition = m_camera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = m_mousePosition - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
