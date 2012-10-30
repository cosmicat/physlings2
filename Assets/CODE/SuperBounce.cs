using UnityEngine;
using System.Collections;


public class SuperBounce : MonoBehaviour {
    public float Bounciness = 1f;

    void OnCollisionEnter(Collision c)
    {
        // the physics engine calculates bounce after this, so only hadd half of what's needed
        c.rigidbody.velocity += Vector3.Project(c.rigidbody.velocity, transform.up) * (Bounciness - 1) / 2;
    }
}
