using UnityEngine;


public class PlatformSwitch : MonoBehaviour {
    public MonoBehaviour Behavior;

    void OnCollisionEnter()
    {
        if (Behavior != null)
        {
            Behavior.enabled = !Behavior.enabled;
        }
    }
}
