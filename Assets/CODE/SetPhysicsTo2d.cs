using UnityEngine;
using System.Collections;

public class SetPhysicsTo2d : MonoBehaviour {

	// Use this for initialization
	void Start () {
        rigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
	}
}
