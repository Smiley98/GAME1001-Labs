using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    [SerializeField] float sales = 500.0f;

    void Start()
    {
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
