using UnityEngine;

public class TeleportPlatform : MonoBehaviour
{
    public GameObject Destination;

    void OnCollisionEnter(Collision c)
    {
        if (Destination == null)
        {
            return;
        }

        // Transform position and velocity to new platform
        //c.transform.position = Destination.transform.TransformPoint(transform.InverseTransformPoint(c.transform.position));
        //c.rigidbody.velocity = Destination.transform.TransformDirection(transform.InverseTransformDirection(c.rigidbody.velocity));

        c.transform.position = Destination.transform.position;
        c.rigidbody.velocity = c.rigidbody.velocity.magnitude * Destination.transform.up;
    }
}
