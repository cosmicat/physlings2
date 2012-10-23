using UnityEngine;
using System.Collections.Generic;

public class Cannon : MonoBehaviour {
    const float BOMB_INTERVAL = 1;
    float nextBomb;
    bool paused;

    public GameObject bombPrefab;

    List<GameObject> bombs;

	// Use this for initialization
	void Start () {
        nextBomb = 0;
        paused = false;

        bombs = new List<GameObject>();

        SphereCollider collider = gameObject.AddComponent<SphereCollider>();
        collider.isTrigger = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (!paused)
        {
            nextBomb -= Time.deltaTime;
        }

        if (nextBomb < 0)
        {
            LaunchBomb();

            nextBomb = BOMB_INTERVAL;
        }
	}

    void OnMouseUpAsButton()
    {
        paused = !paused;
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 50, 50), "KILL"))
        {
            foreach (GameObject bomb in bombs)
            {
                GameObject.Destroy(bomb);
            }
            bombs.Clear();
        }
    }

    void LaunchBomb()
    {
        GameObject bomb = (GameObject)GameObject.Instantiate(bombPrefab);

        bomb.transform.position = transform.position;

        bomb.AddComponent<Rigidbody>();
        bomb.rigidbody.AddForce(transform.up * 12.2f, ForceMode.Impulse);
        bomb.AddComponent<SetPhysicsTo2d>();

        bombs.Add(bomb);
    }
}
