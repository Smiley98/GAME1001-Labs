using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    [SerializeField] [Range(0.0f, 10000.0f)] float sales;
    void Start()
    {
        //if (sales < 0.0f)
        //{
        //    //sales = sales * -1.0f;    // long-form
        //    //sales *= -1.0f;           // short-form
        //
        //    // Alternatively, we can use the absolute-values function!
        //    //sales = Mathf.Abs(sales);
        //}

        if (sales <= 1000.0f)
        {
            // 10% commission if $1000 or less sold
            Debug.Log("Pay: " + (200.0f + sales * 0.10f));
        }
        else
        {
            // 20% commission if over $1000 sold
            Debug.Log("Pay: " + (200.0f + sales * 0.20f));
        }
    }
}
