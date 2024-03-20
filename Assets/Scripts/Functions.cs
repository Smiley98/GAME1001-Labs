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
        Debug.Log(RandomNumber());

        // Just like variables, we can store function ouput for latter use!
        int number = RandomNumber();
        Debug.Log(number);

        // Our add function needs 2 inputs & 1 output:
        int a = RandomNumber();
        int b = RandomNumber();
        Debug.Log("Number 1: " + a);
        Debug.Log("Number 2: " + b);
        Debug.Log("Sum: " + Add(a, b));

        // Task: Create a Sub, Mul, and Div function similar to the Add function
    }

    void Update()
    {
        
    }

    // This function has no inputs (nothing in parenthesis),
    // but outputs a whole number (returns int])!
    int RandomNumber()
    {
        // Ouputs a random number between 0 and 9
        return Random.Range(0, 10);
    }

    //int Add(int a, int b) <-- "Function Signature" - tells us our function name, inputs & outputs
    // {} <-- "Function Body" - contains the logic of the function (code that runs when we call our function)
    // (Multiple words for "run" -- call, execute, invoke)
    int Add(int a, int b)
    {
        return a + b;
    }
}
