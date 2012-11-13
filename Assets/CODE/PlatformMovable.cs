using UnityEngine;

using System;


public class PlatformMovable : MonoBehaviour
{
    public bool Movable;
    public bool Rotatable;

    class RotationDirection
    {
        public static float CLOCKWISE = 1;
        public static float NONE = 0;
        public static float COUNTER_CW = -1;
    }

    float rotating;
    bool moving;

    void Update()
    {
        if (moving)
        {
            transform.position += getDeltaPosition();
        }
        else if (rotating != RotationDirection.NONE)
        {
            Vector3 direction = (getCurrentPosition() - transform.position) * rotating;
            float angle = (float)(Math.Atan2(direction.y, direction.x) / Math.PI * 180);

            transform.eulerAngles = new Vector3(0, 0, angle);
        }
    }

    void OnMouseDown()
    {
        collider.enabled = false;

        if (Rotatable)
        {
            Vector3 mousePosition = getCurrentPosition();

            double distance = Vector3.Dot(mousePosition - transform.position, transform.right);
            BoxCollider box = (BoxCollider)collider;

            if (Math.Abs(distance) > (box.size.x * box.transform.localScale.x / 4))
            {
                if (distance > 0)
                {
                    rotating = RotationDirection.CLOCKWISE;
                }
                else
                {
                    rotating = RotationDirection.COUNTER_CW;
                }
            }
            else
            {
                rotating = RotationDirection.NONE;
            }
        }

        if (Movable && rotating == RotationDirection.NONE)
        {
            moving = true;
            getDeltaPosition();
        }
    }

    void OnMouseUp()
    {
        collider.enabled = true;
        moving = false;
        rotating = RotationDirection.NONE;
    }

    Vector3 previousPosition;
    Vector3 getDeltaPosition()
    {
        Vector3 currentPosition = getCurrentPosition();
        Vector3 deltaPosition = currentPosition - previousPosition;
        previousPosition = currentPosition;

        return new Vector3(deltaPosition.x, deltaPosition.y);
    }

    Vector3 getCurrentPosition()
    {
        Camera camera = Camera.main;
        Vector3 mousePosition = Input.mousePosition;
        return camera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, camera.nearClipPlane));
    }
}
