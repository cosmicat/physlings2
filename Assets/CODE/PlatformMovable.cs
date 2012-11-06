using UnityEngine;


public class PlatformMovable : MonoBehaviour
{
    bool moving;

    void Update()
    {
        if (moving)
        {
            transform.position += getDeltaPosition();
        }
    }

    void OnMouseDown()
    {
        collider.enabled = false;
        moving = true;
        getDeltaPosition();
    }

    void OnMouseUp()
    {
        collider.enabled = true;
        moving = false;
    }

    Vector3 previousPosition;
    Vector3 getDeltaPosition()
    {
        Vector3 currentPosition = getCurrentPosition();
        Vector3 deltaPosition = currentPosition - previousPosition;
        previousPosition = currentPosition;

        return deltaPosition;
    }

    Vector3 getCurrentPosition()
    {
        Camera camera = Camera.main;
        Vector3 mousePosition = Input.mousePosition;
        return camera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, camera.nearClipPlane));
    }
}
