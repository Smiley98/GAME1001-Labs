using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject enemyPrefab;

    bool PointInRec(Vector2 point, Vector2 rec, float width, float height)
    {
        float xMin = rec.x - width * 0.5f;
        float xMax = rec.x + width * 0.5f;
        float yMin = rec.y - height * 0.5f;
        float yMax = rec.y + height * 0.5f;

        if (point.x < xMin) return false;
        if (point.x > xMax) return false;
        if (point.y < yMin) return false;
        if (point.y > yMax) return false;

        return true;
    }

    float speed = 5.0f;
    float rotationSpeed = 100.0f;

    float xMin = -9.0f;
    float xMax = 9.0f;
    float yMin = -5.0f;
    float yMax = 5.0f;

    void Spawn()
    {
        Vector2 point = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        while (PointInRec(point, Vector3.zero, 16.0f, 8.0f))
        {
            point = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        }
        Instantiate(enemyPrefab, point, Quaternion.identity);
    }

    float time = 0.0f;

    void Update()
    {
        float dt = Time.deltaTime;

        // Spawn an enemy within the box every second
        time += dt;
        if (time > 1.0f)
        {
            time = 0.0f;
            Spawn();
        }

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
