using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextUpdater : MonoBehaviour
{
    public TMP_Text text;

    // Runs when we toggle a GameObject on
    void OnEnable()
    {
        text.text = Time.time.ToString();
    }
}
