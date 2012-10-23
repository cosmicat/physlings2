using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {
    float BombDelay = 1;
    float nextBomb = 0;

    public GameObject bombPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        nextBomb -= Time.deltaTime;

        if (nextBomb < 0)
        {
            LaunchBomb();

            nextBomb = BombDelay;
        }
	}

    void LaunchBomb()
    {
        GameObject bomb = (GameObject)GameObject.Instantiate(bombPrefab);

        bomb.transform.position = transform.position;

        bomb.AddComponent<Rigidbody>();
        bomb.rigidbody.AddForce(transform.up * 12.2f, ForceMode.Impulse);
    }
}
