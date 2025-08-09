using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SaveGame : MonoBehaviour
{
    public static float controllerCounterMultiplier;
    public static float controllerEverySecondGetPoint;

    public static bool isAutoSavingStarted = false;

    void Start()
    {
        if (!isAutoSavingStarted)
        {
            StartCoroutine(AutoSaving());

            isAutoSavingStarted = true;
        }
    }

    public static void SaveTheGame()
    {
        PlayerPrefs.SetFloat("SavedCounter", CounterClick.counter);
        PlayerPrefs.SetFloat("SavedEverySecondGetPoint", CounterClick.everySecondGetPoint);
        PlayerPrefs.SetFloat("SavedCounterMultiplier", BokButtonClick.counterMultiplier);
        PlayerPrefs.SetFloat("SavedCounterText1", Button1Click.counterText);
        PlayerPrefs.SetFloat("SavedManatMultiplier", Button1Click.manatMultiplier);
        PlayerPrefs.SetFloat("SavedManatMultiplier3", Button1Click.manatMultiplier3);
        PlayerPrefs.SetFloat("SavedManatMultiplier5", Button1Click.manatMultiplier5);
        PlayerPrefs.SetFloat("SavedPointMultiplier2", Button2Click.pointMultiplier2);
        PlayerPrefs.SetFloat("SavedPointMultiplier4", Button2Click.pointMultiplier4);
        PlayerPrefs.SetFloat("SavedCounterText2", Button2Click.counterText);
        PlayerPrefs.SetInt("SavedSpriteIndex", Controller.spriteIndex);
        PlayerPrefs.SetInt("SavedBossPoint", Boss.bossPoint);
        PlayerPrefs.SetInt("SavedRestartBossPoint", Boss.restartBossPoint);
        PlayerPrefs.SetInt("SavedIsLastBossKilled", Boss.isLastBossKilled ? 1 : 0);
        PlayerPrefs.SetInt("SavedSoldier1Level", Button1Click.soldier1Level);
        PlayerPrefs.SetInt("SavedSoldier2Level", Button2Click.soldier2Level);
        PlayerPrefs.SetInt("SavedSoldier3Level", Button1Click.soldier3Level);
        PlayerPrefs.SetInt("SavedSoldier4Level", Button2Click.soldier4Level);
        PlayerPrefs.SetInt("SavedSoldier5Level", Button1Click.soldier5Level);

        PlayerPrefs.SetFloat("SavedBoostedPower1", Skills.boostedPower1);
        PlayerPrefs.SetFloat("SavedBoostedPower2", Skills.boostedPower2);
        PlayerPrefs.SetFloat("SavedBoostedPower3Click", Skills.boostedPower3Click);
        PlayerPrefs.SetFloat("SavedBoostedPower3EverySecond", Skills.boostedPower3EverySecond);
        PlayerPrefs.SetFloat("SavedBoostedPower4", Skills.boostedPower4);
        PlayerPrefs.SetFloat("SavedBoostedPower5", Skills.boostedPower5);

        controllerCounterMultiplier = BokButtonClick.counterMultiplier;
        controllerEverySecondGetPoint = CounterClick.everySecondGetPoint;

        TimeManager.quitDate = DateTime.Now;
        PlayerPrefs.SetString("QuitDate", TimeManager.quitDate.ToString());
    }

    IEnumerator AutoSaving()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            SaveTheGame();
            Debug.Log("game saved");
        }
    }
}