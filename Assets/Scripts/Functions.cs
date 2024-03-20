using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start & Update have no inputs because nothing is in the parenthesis().
    // Start & Update have no outputs becase they return void which means "nothing".
    void Start()
    {
        // We run a function by writing its name followed by parenthsis.
        Debug.Log(Number());

        // Just like variables, we can store function ouput for latter use!
        int number = Number();
        Debug.Log(number);
    }

    void Update()
    {
        
    }

    // This function has no inputs (nothing in parenthesis),
    // but outputs a whole number (returns int])!
    int Number()
    {
        // Ouputs a random number between 0 and 9
        return Random.Range(0, 10);
    }
}
