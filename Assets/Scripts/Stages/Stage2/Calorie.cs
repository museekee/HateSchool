using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calorie : MonoBehaviour
{
    public static int Kcal = 0;
    public static readonly int MaxKcal = 400;
    void Update()
    {
        gameObject.GetComponent<Text>().text = $"{Kcal}/{MaxKcal} (kcal)";
    }
}