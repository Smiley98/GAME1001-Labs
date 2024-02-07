using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Input validation option 1 -- use the Range(min, max) annotation
    [SerializeField] /*[Range(0.0f, 10000.0f)]*/ float sales;

    void Start()
    {
        // Input validation option 2 -- apply absolute value to sales (make it positive)
        //sales = Mathf.Abs(sales);

        // Given what you had learned, you could also just multiply by negative 1
        if (sales < 0.0f)
            sales = sales * -1.0f;

        if (sales <= 1000.0f)
        {
            Debug.Log("Pay: " + (200.0f + sales * 0.10f));
        }
        else
        {
            Debug.Log("Pay: " + (200.0f + sales * 0.20f));
        }
    }
}
