using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public static DateTime quitDate;

    public float savedCounter;

    public float elapsedTime = 0f;
    public float savedESGP = 0.0f;

    void Awake()
    {
        string dateQuitString = PlayerPrefs.GetString("QuitDate", "");

        if (!dateQuitString.Equals(""))
        {
            DateTime dateQuit = DateTime.Parse(dateQuitString);
            DateTime dateNow = DateTime.Now;

            if (dateNow > dateQuit)
            {
                TimeSpan timespan = dateNow - dateQuit;

                elapsedTime = (float)timespan.TotalSeconds;

                savedESGP = LoadGame.savedEverySecondGetPoint * 2;

                savedCounter = PlayerPrefs.GetFloat("SavedCounter");

                CounterClick.counter = savedCounter + elapsedTime * savedESGP;

                Debug.Log("Quit for " + timespan.TotalSeconds + "second");
            }

            PlayerPrefs.SetString("QuitDate", "");
        }
    }

    //void Update()
    //{
    //    SaveGame.SaveTheGame();

    //    quitDate = DateTime.Now;
    //    PlayerPrefs.SetString("QuitDate", quitDate.ToString());

    //    //Debug.Log("App Quit");
    //    //Debug.Log(quitDate.ToString());

    //    //PlayerPrefs.DeleteAll();
    //}
}
