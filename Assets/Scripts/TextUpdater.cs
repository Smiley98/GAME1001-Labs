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

    // Happens first in the event lifecycle, we can add the click-listener here if we like
    // This will run REGARDLESS of whether the object is enable/disabled!
    //void Awake()
    //{
    //    Debug.Log("Awoke");
    //}

    // Happens second in the event lifecycle, OR whenever an object gets re-enabled
    //void OnEnable()
    //{
    //    text.text = inputField.text;
    //    Debug.Log("UI enabled");
    //}

    // Happens whenever an object is disabled
    //void OnDisable()
    //{
    //    Debug.Log("UI disabled");
    //}

    // Happens third in the event lifecycle
    // Only runs if script is enabled (whereas Awake will run once regardless)
    // Re-enabling an object will cause OnEnable, Reset, and Start to get called
    // See https://docs.unity3d.com/Manual/ExecutionOrder.html for more details!
    void Start()
    {
        // Tell OnClickHandler() to run every time we click our refresh button
        refreshButton.onClick.AddListener(OnClickHandler);
    }

    int[] numbers = new int[10];
    int numberCount = 0;

    public void OnClickHandler()
    {
        // Assign the text in the top-right to be whatever our user inputted
        text.text = inputField.text;

        // Convert text from string to integer, and add it to the array
        numbers[numberCount] = Int32.Parse(text.text);

        // Count up every time user adds a number
        numberCount++;

        // Check if we've reached our desired number count, then output all numbers
        if (numberCount == 10)
        {
            numberCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }
        }
    }
}
