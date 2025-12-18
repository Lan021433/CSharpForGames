using UnityEngine;

public class DestroyonLeavingCamera : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
