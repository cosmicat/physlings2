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

        c.transform.position = Destination.transform.TransformPoint(transform.InverseTransformPoint(c.transform.position));
        c.rigidbody.velocity = Destination.transform.TransformDirection(transform.InverseTransformDirection(c.rigidbody.velocity));
    }
}
