using UnityEngine;
using System.Collections;

public class CameraPanning : MonoBehaviour {
    const float SPEED = 10;

    void Update ()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = addY(transform.position, SPEED * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = addY(transform.position, -SPEED * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = addX(transform.position, SPEED * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = addX(transform.position, -SPEED * Time.deltaTime);
        }

    }

    static Vector3 addY(Vector3 start, float amount)
    {
        return new Vector3(start.x, start.y + amount, start.z);
    }

    static Vector3 addX(Vector3 start, float amount)
    {
        return new Vector3(start.x + amount, start.y, start.z);
    }
}
