using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Click : MonoBehaviour
{
    public static int Clicked = 0;
    void Awake() {
        Clicked = 0;
    }
    public void Click() {
        Clicked++;
        Debug.Log(Clicked);
    }
}
