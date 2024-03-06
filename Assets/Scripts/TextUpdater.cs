using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class TextUpdater : MonoBehaviour
{
    public TMP_Text text;
    public TMP_InputField inputField;
    public Button refreshButton;

    int[] numbers = new int[3];
    int numberCount = 0;

    void Awake()
    {
        // Tell OnClickHandler() to run every time we click our refresh button
        refreshButton.onClick.AddListener(OnClickHandler);
    }

    public void OnClickHandler()
    {
        // Assign the text in the top-right to be whatever our user inputted
        text.text = inputField.text;

        // Convert text to number, then store current number in array
        numbers[numberCount] = Int32.Parse(inputField.text);

        // Increment current number count
        numberCount++;

        // Output all stored numbers to the console once we have 10 numbers
        if (numberCount == numbers.Length)
        {
            // Homework:
            // 1. Print all numbers in *reverse * order(start at index 9, end at index 0)
            // 2. Print the sum of the numbers in the array(numbers[0] + numbers[1] + numbers[2] etc)
            // 3. Print the largest number in the array(compare largest so far with current, update accordingly)
            for (int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }
        }

        // Assigns number count to the remainder of number count / numbers length
        // Practically, this causes numberCount to "wrap-around" back to 0 once its numbers.Length
        numberCount %= numbers.Length;
    }
}
