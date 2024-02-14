using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    void Start()
    {
        // Store a single number
        int number;
        
        // Store space for 10 numbers
        int[] numbers1 = new int[10];

        // Store 10 numbers directly
        int[] numbers2 =
        {
            1, 2, 3, 4, 5
        };

        // We can access the value of an array element by supplying its index in []
        Debug.Log("Before change:");
        Debug.Log(numbers2[0]);
        Debug.Log(numbers2[1]);
        Debug.Log(numbers2[2]);

        Debug.Log("After change:");
        numbers2[0] = 69;
        numbers2[1] = 420;
        numbers2[2] = 1337;
        Debug.Log(numbers2[0]);
        Debug.Log(numbers2[1]);
        Debug.Log(numbers2[2]);

        Debug.Log("Counting downwards from 10");
        for (int i = 0; i < numbers1.Length; i++)
        {
            numbers1[i] = 10 - i;
            Debug.Log(numbers1[i]);
        }

        Debug.Log("Counting upwards from 1");
        for (int i = 0; i < numbers2.Length; i++)
        {
            Debug.Log(numbers2[i]);
        }

        Debug.Log("Sum of all numbers");
        int sum = 0;
        for (int i = 0; i < numbers1.Length; i++)
        {
            sum += numbers1[i];
        }
        Debug.Log(sum);

        Debug.Log("Average of all numbers");
        Debug.Log(sum / (float)numbers1.Length);
    }
}
