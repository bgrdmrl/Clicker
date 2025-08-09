using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CounterClick : MonoBehaviour
{
    public AudioSource mainMusic;

    public TextMeshProUGUI counterTextMesh;
    public TextMeshProUGUI rewardSPTextMesh;

    public static float counter = 0f;
    public static float everySecondGetPoint = 0.0f;
    public float rewardCounter = 0.0f;
    public bool isPanelOpen = false;

    public Button soldierButton1;
    public Button soldierButton2;
    public Button soldierButton3;
    public Button soldierButton4;
    public Button soldierButton5;

    void Start()
    {
        StartCoroutine(EverySecondGetClick());
    }

    void Update()
    {

        if (counter < 1000)
        {
            counterTextMesh.text = counter.ToString("F0") + " SP";
        }

        else
        {
            counterTextMesh.text = WordNotation(counter, "F1");
        }

        if (counter >= 10)
        {
            soldierButton1.gameObject.SetActive(true);
        }

        if (counter >= 50)
        {
            soldierButton2.gameObject.SetActive(true);
        }

        if (BokButtonClick.counterMultiplier >= 10)
        {
            soldierButton3.gameObject.SetActive(true);
        }

        if (everySecondGetPoint >= 2)
        {
            soldierButton4.gameObject.SetActive(true);
        }

        if (everySecondGetPoint >= 5)
        {
            soldierButton5.gameObject.SetActive(true);
        }
    }

    IEnumerator EverySecondGetClick()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            counter += everySecondGetPoint;
        }
    }

    public static string WordNotation(float number, string digits)
    {
        double digitsTemp = Math.Floor(Math.Log10(number));

        IDictionary<double, string> prefixes = new Dictionary<double, string>()
        {
            {3, "K SP" },
            {4, "K SP" },
            {5, "K SP" },
            {6, "M SP" },
            {7, "M SP" },
            {8, "M SP" },
            {9, "B SP" },
            {10, "B SP" },
            {11, "B SP" },
            {12, "T SP" },
            {13, "T SP" },
            {14, "T SP" },
            {15, "QT SP" },
            {16, "QT SP" },
            {17, "QT SP" }
        };

        double digitsEvery3 = Math.Floor(digitsTemp / 3);

        if (number >= 1000)
        {
            return (number / Math.Pow(10, 3 * digitsEvery3)).ToString(digits) + prefixes[digitsTemp];
        }

        return number.ToString(digits);
    }

    public static string WordNotationWithoutSP(float number, string digits)
    {
        double digitsTemp = Math.Floor(Math.Log10(number));

        IDictionary<double, string> prefixes = new Dictionary<double, string>()
        {
            {3, "K" },
            {4, "K" },
            {5, "K" },
            {6, "M" },
            {7, "M" },
            {8, "M" },
            {9, "B" },
            {10, "B" },
            {11, "B" },
            {12, "T" },
            {13, "T" },
            {14, "T" },
            {15, "QT" },
            {16, "QT" },
            {17, "QT" }
        };

        double digitsEvery3 = Math.Floor(digitsTemp / 3);

        if (number >= 1000)
        {
            return (number / Math.Pow(10, 3 * digitsEvery3)).ToString(digits) + prefixes[digitsTemp];
        }

        return number.ToString(digits);
    }
}
