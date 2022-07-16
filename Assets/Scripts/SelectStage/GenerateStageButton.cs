using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateStageButton : MonoBehaviour
{
    [SerializeField] private StageListItem stageListItem;
    [SerializeField] private GameObject stageListContent;
    void Start()
    {
        StageListArray[] stageArray = JsonUtility.FromJson<StageList>(Resources.Load<TextAsset>("JSON/StageList").ToString()).stages;
        int canGoStage = int.Parse(PlayerPrefs.GetString("CanGoStage"));
        foreach(StageListArray item in stageArray) {
            StageListItem listItem = Instantiate(stageListItem, Vector3.zero, Quaternion.identity);
            listItem.stageName = item.name;
            listItem.stageScene = item.scene;
            Debug.Log(canGoStage);
            if (canGoStage >= item.scene) listItem.canClick = true;
            else listItem.canClick = false;
            listItem.Init();
            listItem.transform.SetParent(stageListContent.transform);
            Vector3 scale = listItem.transform.localScale;
            scale.Set(1, 1, 1);
            listItem.transform.localScale = scale;
        }
    }
}

[System.Serializable]
class StageList
{
    public StageListArray[] stages;
}
[System.Serializable]
class StageListArray
{
    public string name;
    public int scene;
}