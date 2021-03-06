using UnityEngine;
using System.Collections;

public class PlatformInvisible : MonoBehaviour {

    void OnEnable()
    {
        if (collider != null)
        {
            collider.enabled = false;
            renderer.enabled = false;
        }
    }

    void OnDisable()
    {
        if (collider != null)
        {
            collider.enabled = true;
            renderer.enabled = true;
        }
    }
}
