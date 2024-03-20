using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    bool IsSorted(int[] numbers)
    {
        // TODO -- return whether array is sorted or not
        return false;
    }

    int Find(int number, int[] numbers)
    {
        // TODO -- return the index of number in the array if found, otherwise return -1
        return -1;
    }

    void Start()
    {
        //Lesson();
        Homework();
    }

    void Homework()
    {
        // Homework task 1:
        int[] unsorted = { 1, 3, 2, 4, 5, 7, 6, 8, 9, 11 };
        int[] sorted = new int[10];
        for (int i = 0; i < 10; i++)
            sorted[i] = i + 1;

        bool isSorted1 = IsSorted(sorted);      // Should be true
        bool isSorted2 = IsSorted(unsorted);    // Should be false
        Debug.Log(isSorted1);
        Debug.Log(isSorted2);

        // Homework task 2:
        int index1 = Find(1, sorted);       // Should be 0
        int index2 = Find(420, sorted);     // Should be -1
        Debug.Log(index1);
        Debug.Log(index2);
    }

    void Lesson()
    {
        // We run functions by typing their name and
        // supplying their inputs within parentheis()
        // We can store the output of a function within a variable!

        {
            int a = RandomInteger();
            int b = RandomInteger();
            Debug.Log("Number 1: " + a);
            Debug.Log("Number 2: " + b);
            Debug.Log("Sum: " + Add(a, b));
            Debug.Log("Difference: " + Sub(a, b));
            Debug.Log("Product: " + Mul(a, b));
            Debug.Log("Quotient: " + Div(a, b));
        }

        {
            float a = RandomDecimal();
            float b = RandomDecimal();
            Debug.Log("Number 1: " + a);
            Debug.Log("Number 2: " + b);
            Debug.Log("Sum: " + Add(a, b));
            Debug.Log("Difference: " + Sub(a, b));
            Debug.Log("Product: " + Mul(a, b));
            Debug.Log("Quotient: " + Div(a, b));
        }
    }

    // Outputs a random whole number between 0 and 9
    int RandomInteger()
    {
        return Random.Range(0, 10);
    }

    // Outputs a random decimal number between 0 and 9
    float RandomDecimal()
    {
        return Random.Range(0.0f, 10.0f);
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

    int Sub(int a, int b)
    {
        return a - b;
    }

    int Mul(int a, int b)
    {
        return a * b;
    }

    int Div(int a, int b)
    {
        return a / b;
    }

    //int number = 5;
    //float number = 5.5f;
    // Variables with the same name are compiler errors, but same-named functions are okay
    // as long as their signatures are different!
    // We call this "function overloading"

    float Add(float a, float b)
    {
        return a + b;
    }

    float Sub(float a, float b)
    {
        return a - b;
    }

    float Mul(float a, float b)
    {
        return a * b;
    }

    float Div(float a, float b)
    {
        return a / b;
    }
}
