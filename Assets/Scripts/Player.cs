using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5.0f;
    float rotationSpeed = 100.0f;

    void Update()
    {
        float dt = Time.deltaTime;

        float rotation = 0.0f;
        if (Input.GetKey(KeyCode.Q))    // left
        {
            rotation += rotationSpeed * dt;
        }
        if (Input.GetKey(KeyCode.E))    // right
        {
            rotation -= rotationSpeed * dt;
        }

        // Internally when we do transform.Rotate(), Unity does vector-quaternion multiplication
        // A quaternion stores a rotation, and a vector stores the axis of rotation
        // Hence, if we want to rotate 20 degrees from the right vector (default cartesian plane)
        // we multiply the two together to obtain the resultant direction!
        //transform.right = Quaternion.Euler(0.0f, 0.0f, 20.0f) * Vector3.up;
        transform.Rotate(new Vector3(0.0f, 0.0f, rotation));

        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.A))    // left
        {
            direction += transform.up;
        }
        if (Input.GetKey(KeyCode.D))    // right
        {
            direction -= transform.up;
        }
        if (Input.GetKey(KeyCode.W))    // up
        {
            direction += transform.right;
        }
        if (Input.GetKey(KeyCode.S))    // down
        {
            direction -= transform.right;
        }

        transform.position += direction.normalized * speed * dt;
        Debug.DrawLine(transform.position, transform.position + transform.right * 10.0f, Color.red);
    }
}
