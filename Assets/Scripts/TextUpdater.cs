using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Homework hints:
// Make an array of 10 integers (similar to how we made int[] numbers1)
// Make a counter integer that stores the number of elements in your array
// Increment the counter and store the user's text every time the button is clicked
// Once the counter reaches 10, debug log all numbers stored in the array.
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
            // 1. Print all numbers in *reverse* order (start at index 9, end at index 0)
            // 2. Print the sum of the numbers in the array (numbers[0] + numbers[1] + numbers[2] etc)
            // 3. Print the largest number in the array (compare largest so far with current, update accordingly)
            for (int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }
        }

        // "Wrap-around" our counter --> prevents our array from going out of bounds!
        // ie will be 0-9 for values 0-9, 10 % 10 = 0, 10 % 11 = 1, 10 % 12 = 2 etc.
        numberCount %= numbers.Length;
    }
}
