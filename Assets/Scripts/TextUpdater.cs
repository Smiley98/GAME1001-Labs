using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdater : MonoBehaviour
{
    public TMP_Text greeting;
    public Button refreshButton;

    // Start is called before the first frame update
    void Start()
    {
        greeting.text = "Hello world!";
        refreshButton.onClick.AddListener(RefreshTime);
    }

    void RefreshTime()
    {
        greeting.text = Time.time.ToString();
    }
}
