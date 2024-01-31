using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Computers make decisions with "if-statements"
        // We evaluate a true/false statement.
        if (2 + 2 == 3)
        {
            // We take this path if the condition is true
            Debug.Log("Condition is true!");
        }
        else
        {
            // We take this path if the condition is false
            Debug.Log("Condition is false!");
        }

        // General decision-making structure:
        if (true)
        {
            // true branch
        }
        else
        {
            // false branch
        }

        // AI decision making example
        int baseHealth = 10;
        int healthGrowth = 25;
        int level = 2;
        // Typical game level up formula
        int health = baseHealth + healthGrowth * level;

        // Perhaps we encounter a magic enemy that applies at debuf!
        health /= baseHealth;
        Debug.Log(health);

        // Snoop Dog's mana stat
        int mana = 420;

        // If health is above 50%, evaluate attack options
        if (health > 50)
        {
            Debug.Log("Attack commencing. . .");

            // If mana is 100%, do special attack
            if (mana >= 100)
            {
                Debug.Log("Special Attack!!!");
            }
            else
            {
                Debug.Log("Basic attack (boooooo laaaame)");
            }
        }
        // Heal if lower than 50% hp
        else
        {
            Debug.Log("Heal");
        }
    }

    [SerializeField] float x = 0.0f;
    [SerializeField] float y = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 0.0f)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }


        if (transform.position.x > 0.0f)
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }

        // Uncomment to change position based on X & Y slider values
        transform.position = new Vector3(x, y, 0.0f);
    }
}
