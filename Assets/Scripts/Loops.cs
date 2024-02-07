using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    void Start()
    {
        // 1. Declare a counter variable (number = 1)
        // 2. Set a condition (number <= 10) so we loop until the condition is false (number == 11)
        // 3. Increment our counter (number = number + 1, or number++ for short)!
        for (int number = 1; number <= 10; number++)
        {
            Debug.Log(number);
            if (number % 3 == 0)
            {
                Debug.Log("Buzz");
            }
            if (number % 5 == 0)
            {
                Debug.Log("Fizz");
            }
        }
    }
}
