using UnityEngine;

public class ExplodyBomb : MonoBehaviour {
    public float Lifetime = 1;
    
	void Update () {
        Lifetime -= Time.deltaTime;

        if (Lifetime < 0)
        {
           Explode();
        }
	}

    void Explode()
    {
        
        RaycastHit[] rh = Physics.CapsuleCastAll(transform.position, transform.position, 5, Vector3.up);
        foreach (RaycastHit e in rh)
        {
            
            e.rigidbody.AddForce((e.rigidbody.transform.position - transform.position).normalized * 10, ForceMode.Impulse);
        }
        GameObject.Destroy(gameObject);
    }
}
