using UnityEngine;
using System.Collections;

public class ExplodyBomb : MonoBehaviour {
    float lifetime;
    
    // Use this for initialization
	void Start () {
        //lifetime = (float)Random.Range(1.5f, 5);
        lifetime = (float)Random.Range(6,6);
	}
	
	// Update is called once per frame
	void Update () {
        
        lifetime -= Time.deltaTime;

        if (lifetime < 0)
        {
           // Explode();
        }
	}

    void Explode()
    {
        
        RaycastHit[] rh = Physics.CapsuleCastAll(transform.position, transform.position, 10, Vector3.up);
        Debug.Log(rh.Length);
        foreach (RaycastHit e in rh)
        {
            
            e.rigidbody.AddForce((e.rigidbody.transform.position - transform.position).normalized * 10, ForceMode.Impulse);
        }
        GameObject.Destroy(gameObject);
    }
}
