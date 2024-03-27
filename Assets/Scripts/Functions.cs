using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Ouputs whether numbers is sorted or not
    bool IsSorted(int[] numbers)
    {
        int previous = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            int current = numbers[i];
            if (previous > current)
                return false;
            previous = current;
        }
        return true;
    }

    // Outputs the index of number in the array if found, otherwise return -1
    int Find(int number, int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == number)
                return i;
        }
        return -1;
    }

    void Start()
    {
        //Week11();
        //Week12();
        //Homework();
        ListExamples();
    }

    void ListExamples()
    {
        // Like arrays, lists are a collection of the same data type (int, float, GameObject, etc)
        // Lists indicate said data-type within the angle-brackets <>
        //int[] array = new int[10];
        List<int> list = new List<int>();

        // List is said to be a "dynamic array" because it can get bigger and/or smaller
        // This is because we can add & remove elements from out list!
        list.Add(1);
        list.Add(2);
        list.Add(3);

        // Also like arrays, we access elements in our list based on indices via square-brackets []
        // Similar to arrays, lists store a Count variable akin to array's Length
        for (int i = 0; i < list.Count; i++)
            Debug.Log(list[i]);

        // We can remove based on value or based on index!
        // Removing based on value is less efficient, but more convenient

        Debug.Log("Removing *value* 2: 1, 2, 3 --> 1, 3");
        list.Remove(2);     // Removes the value 2 (which was at index 1 aka list[1])
        for (int i = 0; i < list.Count; i++)
            Debug.Log(list[i]);

        Debug.Log("Removing *index* 1: 1, 3 --> 1");
        list.RemoveAt(1);   // Removes the value at index 1 which is 3
        for (int i = 0; i < list.Count; i++)
            Debug.Log(list[i]);

        // Is our list empty?
        Debug.Log(list.Count == 0);
    }

    // Passed "by-value" meaing we pass a *copy* of n
    void Increment(int n)
    {
        Debug.Log("Before inner increment: " + n);
        ++n;
        Debug.Log("After inner increment: " + n);
    }

    // Passed "by-reference" meaing we pass the actual variable n
    void Increment(ref int n)
    {
        Debug.Log("Before inner increment: " + n);
        ++n;
        Debug.Log("After inner increment: " + n);
    }

    void Week12()
    {
        int n = 5;
        Debug.Log("Before outer increment: " + n);
        Increment(n);
        Debug.Log("After outer increment: " + n);

        Debug.Log("Before outer increment: " + n);
        Increment(ref n);
        Debug.Log("After outer increment: " + n);
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

    void Week11()
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
