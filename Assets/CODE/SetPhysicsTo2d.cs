using UnityEngine;

using System;

public class SetPhysicsTo2d : MonoBehaviour {

    void Start()
    {
        rigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
    }

    void Update()
    {
        // destroy objects which have gone siginificantly out of bounds
        if (Math.Abs(transform.position.y) > 100 || Math.Abs(transform.position.x) > 100)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
