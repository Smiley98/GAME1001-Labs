using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // "Default parameter" --> if we don't supply a number input, then we will use 0
    int DefaultParameter(int number = 0)
    {
        return number + 1;
    }


    // Passes n "by value" --> passes a copy of n
    void Increment(int n)
    {
        Debug.Log("Before inner increment: " + n);
        ++n;
        Debug.Log("After inner increment: " + n);
    }

    // Passes n "by reference" --> passes the actual variable
    void Increment(ref int n)
    {
        Debug.Log("Before inner increment (by reference): " + n);
        ++n;
        Debug.Log("After inner increment (by reference): " + n);
    }

    // We can have "multiple outputs" by passing multiple references
    void Increment(ref int n1, ref int n2, ref int n3)
    {
        ++n1;
        ++n2;
        ++n3;
    }

    // Outputs whether numbers is sorted ascending least to greatest
    bool IsSorted(int[] numbers)
    {
        // TODO -- 
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

    // Outputs the index of number if found, otherwise -1 if not found
    int Find(int number, int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == number)
                return i;
        }
        return -1;
    }

    // Start & Update have no inputs because nothing is in the parenthesis().
    // Start & Update have no outputs becase they return void which means "nothing".
    void Start()
    {
        //Week11();
        //Week12();
        //Homework();
        ListExamples();
    }

    // (Week 12 part 2)
    void ListExamples()
    {
        // Just like an array, we define the data-type that our list stores, but within the <> ("angle-brackets")
        //int[] array = new int[10];

        // Unlike arrays, we can add to & remove from lists so we don't need to specify their size up-front!
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        // Lists use "Count" instead of "Length" for the number of elements they contain
        for (int i = 0; i < list.Count; i++)
            Debug.Log(list[i]);

        // Lists are powerful so they can removed based on value instead of index
        list.Remove(2);
        for (int i = 0; i < list.Count; i++)
            Debug.Log(list[i]); // list is now { 0, 3 }

        // Additionally, we can also remove based on index:
        list.RemoveAt(0);   // list is now { 3 }
        for (int i = 0; i < list.Count; i++)
            Debug.Log(list[i]);
    }

    void Week12()
    {
        int n = 5;
        Debug.Log("Before outer increment (by value): " + n);
        Increment(n);
        Debug.Log("After outer increment (by value): " + n);

        Debug.Log("Before outer increment (by reference): " + n);
        Increment(ref n);
        Debug.Log("After outer increment (by reference): " + n);

        int m = 7;
        int o = 8;
        Debug.Log("Before multi-increment: " + n + " " + m + " " + o);
        Increment(ref n, ref m, ref o);
        //Increment(n, m, o); <--- compiler error because function signature requires all values to be passed by reference!
        Debug.Log("After multi-increment: " + n + " " + m + " " + o);
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

    void Week11()
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
        Debug.Log(DefaultParameter(1));
        Debug.Log(DefaultParameter());
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
