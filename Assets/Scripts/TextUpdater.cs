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

    int[] numbers = new int[10];
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
        if (numberCount == 10)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }
        }
    }
}
