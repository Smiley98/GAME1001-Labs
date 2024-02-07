using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    void Start()
    {
        // 1. Declare our counter (number)
        // 2. Create our condition (<= 10 [less-than or equal-to 10])
        // 3. Increment our counter (add 1 to number each time [number++])
        for (int number = 1; number <= 10; number++)
        {
            Debug.Log(number);
            if (number % 3 == 0)       // if our number is divisible by 3:
            {
                Debug.Log("Buzz " + "(" + number + ")");
            }
            else if (number % 5 == 0)   // if our number is divisible by 5:
            {
                Debug.Log("Fizz " + "(" + number + ")");
            }
        }
    }
}
