using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextUpdater : MonoBehaviour
{
    public TMP_Text greeting;

    // Start is called before the first frame update
    void Start()
    {
        greeting.text = "Hello world!";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            greeting.text = Time.time.ToString();
        }
    }
}
