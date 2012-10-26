using UnityEngine;
using System.Collections;

public class SpikedPlatform : MonoBehaviour
{
    void OnCollisionEnter(Collision c)
    {
        GameObject.Destroy(c.gameObject);
    }
}
