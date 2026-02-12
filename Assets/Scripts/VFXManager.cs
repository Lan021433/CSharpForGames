using UnityEngine;
using UnityEngine.InputSystem;

public class VFXManager : MonoBehaviour
{
    public static VFXManager s_instance;
    [SerializeField] private GameObject m_explosionPrefab;

    private void Awake()
    {
        if (s_instance == null)
            s_instance = this;
    }

    public static GameObject CreateExplosion(Vector3 position, float destroyAfter = 0.6f)
    {
        if (s_instance == null)
        {
            Debug.LogError("Tried to spawn an explosion but the instance hasn't been set");
            return null;
        }
        GameObject explosion = Instantiate(s_instance.m_explosionPrefab, position, Quaternion.identity);
        Destroy(explosion, destroyAfter);
        return explosion;
    }   
}
