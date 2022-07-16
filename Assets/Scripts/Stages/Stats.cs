using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    private static int maxHealthy = 100;
    private static int maxSatiety = 100;
    private static int healthy = 100;
    private static int satiety = 0;
    void Update()
    {
        GameObject.Find("HealthyText").GetComponent<Text>().text = healthy.ToString();
        GameObject.Find("SatietyText").GetComponent<Text>().text = satiety.ToString();
    }
    public static void AddHealthy(int number) {
        if ((healthy + number) > maxHealthy) healthy = maxHealthy;
        else if ((healthy + number) < 0) healthy = 0;
        else healthy += number;
    }
    public static void AddSatiety(int number) {
        if ((satiety + number) > maxSatiety) satiety = maxSatiety;
        else if ((satiety + number) < 0) satiety = 0;
        else satiety += number;
    }
    public static void SetHealthy(int number) {
        if (number > maxHealthy) healthy = maxHealthy;
        else healthy = number;
    }
    public static void SetSatiety(int number) {
        if (number > maxSatiety) satiety = maxSatiety;
        else satiety = number;
    }
    public static int GetHealthy() { return healthy; }
    public static int GetSatiety() { return satiety; }
}
