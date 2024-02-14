using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    void Start()
    {
        // Automatically initialize an array
        // (allocate space for 10 elements even if we don't know what they will be)
        int[] numbers1 = new int[10];

        // Count down from 10 to 1
        for (int i = 10; i > 0;  i--)
        {
            int index = i - 1;
            numbers1[index] = i;
            Debug.Log(numbers1[index]);
        }

        // A simpler version of the above loop:
        for (int i = 9; i >= 0; i--)
        {
            numbers1[i] = i + 1;
            Debug.Log(numbers1[i]);
        }

        // Manually initialize an array
        int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Debug.Log("Length of numbers2: " + numbers2.Length);
        Debug.Log("First number: " + numbers2[0]);
        Debug.Log("Last number: " + numbers2[numbers2.Length - 1]);

        Debug.Log("Before change:");
        for (int i = 0; i < numbers2.Length; i++)
        {
            Debug.Log(numbers2[i]);
        }

        Debug.Log("After change:");
        numbers2[0] = 7;
        numbers2[1] = 9;
        numbers2[2] = int.MaxValue;
        for (int i = 0; i < numbers2.Length; i++)
        {
            Debug.Log(numbers2[i]);
        }
    }
}
