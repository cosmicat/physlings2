using UnityEngine;


public class DirectionalSwitch : MonoBehaviour
{
    public MonoBehaviour Behavior;
    public bool Enables;

    void OnTriggerLeave(Collider other)
    {
        if (Behavior != null)
        {
            // check the direction
            if (Vector3.Dot(other.rigidbody.velocity, transform.right) > 0)
            {
                Behavior.enabled = Enables;
            }
            else
            {
                Behavior.enabled = !Enables;
            }
        }
    }
}
