using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Story : MonoBehaviour
{
    [SerializeField] private AudioClip Alarm;
    [SerializeField] private GameObject SceneGosu;
    [SerializeField] private GameObject OffArm;
    [SerializeField] private GameObject TalkText;
    [SerializeField] private GameObject WakeUp;
    [SerializeField] private GameObject Audio;

    private TalkScript Talk;

    void Awake() {
        Talk = TalkText.GetComponent<TalkScript>();
    }
    async void Start()
    {
        ChangeAudio(Alarm);
        PlayAudio();
        await Task.Delay(1556);
        OffArm.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        await Task.Delay(500);
        Talk.ShowTalk();
        Talk.ChangeText("흐아암... 졸려");
        await Task.Delay(1000);
        Talk.ChangeText("시끄러운 알람소리에 일어났지만 아직도 졸려...");
        await Task.Delay(2000);
        Talk.ChangeText("10초동안 깨우기 버튼을 25번 이상 클릭해서 깨워줘!");
        await Task.Delay(2500);
        Talk.HideTalk();
        WakeUp.SetActive(true);
        await Task.Delay(10000);
        Talk.ShowTalk();
        WakeUp.SetActive(false);
        if (Stage1Click.Clicked < 25) {
            Talk.ChangeText($"{Stage1Click.Clicked}번 밖에 클릭하지 못했어... 다음엔 더 잘 해봐!");
            await Task.Delay(2000);
            SceneGosu.GetComponent<SceneGosu>().GotoMain();
        }
        else {
            StageGosu.SetCanGoStage(2);
            Talk.ChangeText($"{Stage1Click.Clicked}번이나 클릭했네? 성공이야!");
            await Task.Delay(2000);
            SceneGosu.GetComponent<SceneGosu>().GotoMain();
        }
    }
    void ChangeAudio(AudioClip clip) {
        Audio.GetComponent<AudioSource>().clip = clip;
    }
    void PlayAudio() {
        Audio.GetComponent<AudioSource>().Play();
    }
}
