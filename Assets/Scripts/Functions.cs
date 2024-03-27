using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // "Default parameter" --> if we don't supply a number input, then we will use 0
    int Increment(int number = 0)
    {
        return number + 1;
    }

    bool IsSorted(int[] numbers)
    {
        // TODO -- return whether numbers is sorted ascending least to greatest
        return false;
    }

    int Find(int number, int[] numbers)
    {
        // TODO -- search the numbers and return the index of number if found
        return -1;
    }

    // Start & Update have no inputs because nothing is in the parenthesis().
    // Start & Update have no outputs becase they return void which means "nothing".
    void Start()
    {
        Lesson();
        //Homework();
    }

    void Homework()
    {
        // Task 1 test:
        int[] unsorted = { 1, 3, 2, 4, 5, 7, 6, 8, 9, 11 };
        int[] sorted = new int[10];
        for (int i = 0; i < 10; i++)
            sorted[i] = i + 1;

        bool sorted1 = IsSorted(sorted);    // Should be true
        bool sorted2 = IsSorted(unsorted);  // Should be false
        Debug.Log(sorted1);
        Debug.Log(sorted2);

        // Task 2 test:
        int index1 = Find(1, sorted);       // should be 0 (number 1 at index 0)
        int index2 = Find(420, sorted);     // should be -1 (not found)
        Debug.Log(index1);
        Debug.Log(index2);
    }

    void Lesson()
    {
        // We run a function by writing its name followed by parenthsis.
        Debug.Log(RandomInteger());

        // Just like variables, we can store function ouput for latter use!
        int number = RandomInteger();
        Debug.Log(number);

        // Our add function needs 2 inputs & 1 output:
        int a = RandomInteger();
        int b = RandomInteger();
        Debug.Log("Number 1: " + a);
        Debug.Log("Number 2: " + b);

        // Test integers with a & b
        Debug.Log("Sum: " + Add(a, b));
        Debug.Log("Difference: " + Sub(a, b));
        Debug.Log("Product: " + Mul(a, b));
        Debug.Log("Quotient: " + Div(a, b));

        float c = RandomDecimal();
        float d = RandomDecimal();
        Debug.Log("Number 3: " + c);
        Debug.Log("Number 4: " + d);

        // Test decimals with c & d
        Debug.Log("Sum: " + Add(c, d));
        Debug.Log("Difference: " + Sub(c, d));
        Debug.Log("Product: " + Mul(c, d));
        Debug.Log("Quotient: " + Div(c, d));

        // Default parameter example
        Debug.Log(Increment(1));
        Debug.Log(Increment());
    }

    // This function has no inputs (nothing in parenthesis),
    // but outputs a whole number (returns int])!
    int RandomInteger()
    {
        // Ouputs a random number between 0 and 9
        return Random.Range(0, 10);
    }

    float RandomDecimal()
    {
        // Ouputs a random number between 0 and 9
        return Random.Range(0.0f, 10.0f);
    }

    //int Add(int a, int b) <-- "Function Signature" - tells us our function name, inputs & outputs
    // {} <-- "Function Body" - contains the logic of the function (code that runs when we call our function)
    // (Multiple words for "run" -- call, execute, invoke)
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
