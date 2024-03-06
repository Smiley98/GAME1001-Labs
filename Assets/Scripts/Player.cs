using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform target;

    // How to make one object face another:
    void Start()
    {
        // AB = B - A
        // I'm going FROM player TO enemy so enemy = B, player = A
        Vector3 direction = (target.position - transform.position).normalized;
        transform.right = direction;
    }

    float speed = 5.0f;
    float rotationSpeed = 100.0f;

    void Update()
    {
        float dt = Time.deltaTime;

        float rotation = 0.0f;
        if (Input.GetKey(KeyCode.Q))
        {
            rotation += rotationSpeed * dt;
        }
        if (Input.GetKey(KeyCode.E))
        {
            rotation -= rotationSpeed * dt;
        }
        transform.Rotate(new Vector3(0.0f, 0.0f, rotation));

        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction += transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction -= transform.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += transform.up;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction -= transform.up;
        }

        // "normalized" changes from "square to circle"
        transform.position += direction.normalized * speed * dt;
        Debug.DrawLine(transform.position, transform.position + transform.right * 5.0f, Color.red);
        Debug.DrawLine(transform.position, transform.position + transform.up * 5.0f, Color.green);
    }
}
