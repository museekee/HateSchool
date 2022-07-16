using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageListItem : MonoBehaviour
{
    public string stageName;
    public int stageScene;
    public bool canClick = false;
    [SerializeField] private GameObject NameText;
    public void Init() {
        Debug.Log($"{stageScene}. {stageName}");
        NameText.GetComponent<Text>().text = $"{stageScene}. {stageName}";
    }
    public void LoadStage() {
        if (canClick) SceneManager.LoadScene($"Stage{stageScene}");
    }
}
