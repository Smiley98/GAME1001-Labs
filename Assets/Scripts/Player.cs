using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5.0f;

    void Update()
    {
        float dt = Time.deltaTime;
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += new Vector3(0.0f, 1.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += new Vector3(0.0f, -1.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += new Vector3(-1.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += new Vector3(1.0f, 0.0f);
        }

        // "normalized" changes from "square to circle"
        transform.position += direction.normalized * speed * dt;
    }
}
