using UnityEngine;
using System.Collections;
//TODO
//-write a script to 
public class SuperBounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision c)
    {
        //c.rigidbody.AddForce(Vector3.Reflect(-c.rigidbody.velocity.normalized, c.contacts[0].normal)*10, ForceMode.Impulse);
        //c.rigidbody.AddForce(transform.up*5, ForceMode.Impulse);
        
    }
}
