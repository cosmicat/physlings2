using UnityEngine;
using System.Collections;

public class Goal2 : MonoBehaviour {
    float mTimer = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (mTimer <= 0)
            renderer.enabled = true;
        else
        {
            mTimer -= Time.deltaTime;
            renderer.enabled = false;
        }

	}

    void OnTriggerEnter(Collider other)
    {
        mTimer = 2;
    }
}
