using UnityEngine;

public class StartExplodingPlatform : MonoBehaviour
{
    public float Lifetime = 1;
    void OnCollisionEnter(Collision c)
    {
        ExplodyBomb explodable = c.gameObject.AddComponent<ExplodyBomb>();
        explodable.Lifetime = Lifetime;
    }
}
