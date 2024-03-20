using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    void Start()
    {
        // We run functions by typing their name and
        // supplying their inputs within parentheis()
        // We can store the output of a function within a variable!

        int a = RandomInteger();
        int b = RandomInteger();
        Debug.Log("Number 1: " + a);
        Debug.Log("Number 2: " + b);
        Debug.Log("Sum: " + Add(a, b));

        // Task: write a Sub, Mul, and Div function that operate on whole numbers
        // (Similar to Add but just different operations)
    }

    void Update()
    {
        
    }

    // Outputs a random whole number between 0 and 9
    int RandomInteger()
    {
        return Random.Range(0, 10);
    }


    //int Add(int a, int b) <-- "function signature"
    // Function signatures contain all the information about a function.
    // The signature dictates a function's name, inputs, and outputs.

    // The "function body" is the code within the curly braces {}
    // Its the code that runs when the function runs
    //{
    //}

    //int number = 5;
    // We can think of signatures like a variable's name & type,
    // whereas a variable's value is like a function body.

    // For this task, your function signatures for Add, Sub, Mul, Div
    // should be the same (excluding the name), but the bodies should change.
    int Add(int a, int b)
    {
        return a + b;
    }
}
