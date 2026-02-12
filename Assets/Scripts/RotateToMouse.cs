using UnityEngine;

public class RotateToMouse : MonoBehaviour
{    
    // Update function is used to find the mouse postion and create a vector from the objects postion
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x, mousePosition.y - transform.position.y);
        transform.up = direction;
    }
}
