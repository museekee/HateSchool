using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkScript : MonoBehaviour
{
    void Start() {
        HideTalk();
    }
    public void ShowTalk() {
        gameObject.GetComponent<Image>().color = new Color32(0, 0, 0, 150);
    }
    public void HideTalk() {
        gameObject.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
        ChangeText("");
    }
    public void ChangeText(string text) {
        gameObject.transform.Find("Content").GetComponent<Text>().text = text;
    }
}
