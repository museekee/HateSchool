using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalDefSet : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetString("CanGoStage", null);
        if (PlayerPrefs.GetString("CanGoStage") == string.Empty) {
            PlayerPrefs.SetString("CanGoStage", "1");
        }
    }
}
