using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGosu : MonoBehaviour
{
    public static void SetCanGoStage(int stage) {
        if (int.Parse(PlayerPrefs.GetString("CanGoStage")) > stage) return;
        PlayerPrefs.SetString("CanGoStage", stage.ToString());
    }
}
