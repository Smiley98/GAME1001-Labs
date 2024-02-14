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
        RefreshTime();
    }

    public void RefreshTime()
    {
        text.text = Time.time.ToString();
    }
}
