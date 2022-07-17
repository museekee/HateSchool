using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Story2 : MonoBehaviour
{
    [SerializeField] private GameObject TalkText;
    [SerializeField] private GameObject SceneGosu;
    [SerializeField] private GameObject Foods;
    [SerializeField] private GameObject Mouse;

    private TalkScript Talk;
    async void Start()
    {
        Talk = TalkText.GetComponent<TalkScript>();
        Talk.ShowTalk();
        Talk.ChangeText("아 배고파.....");
        await Task.Delay(1000);
        Talk.ChangeText("아침밥이나 먹어야지..");
        await Task.Delay(2000);
        Talk.ChangeText("곧 나올 음식을 드래그 해서 입에 넣으면 먹을 수 있어.");
        await Task.Delay(3250);
        Talk.ChangeText($"최대 kcal인 {Calorie.MaxKcal}kcal을 넘지 않게 조심히 먹어!");
        await Task.Delay(5000);
        Talk.HideTalk();
        Foods.SetActive(true);
    }
}