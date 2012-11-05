using UnityEngine;


public class Goal : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(other.gameObject);
    }
}
