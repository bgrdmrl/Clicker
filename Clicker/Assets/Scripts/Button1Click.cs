using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button1Click : MonoBehaviour                               // click power artýran askerler
{
    public TextMeshProUGUI counterTextMesh;
    public TextMeshProUGUI manatTextMesh;
    public TextMeshProUGUI manat3TextMesh;
    public TextMeshProUGUI manat5TextMesh;
    public TextMeshProUGUI currentClickPowerPointTextMesh;
    public TextMeshProUGUI currentEverySecondPowerPointTextMesh;

    public GameObject soldier1EmptyInventory;
    public GameObject soldier3EmptyInventory;
    public GameObject soldier5EmptyInventory;

    public TextMeshProUGUI soldier1LevelTextMesh;
    public TextMeshProUGUI soldier3LevelTextMesh;
    public TextMeshProUGUI soldier5LevelTextMesh;

    public static float manatMultiplier = 1.0f;
    public static float manatMultiplier3 = 1.0f;
    public static float manatMultiplier5 = 1.0f;
    public static float counterText = 0.0f;

    public static int soldier1Level = 0;
    public static int soldier3Level = 0;
    public static int soldier5Level = 0;

    public void Soldier1()
    {
        counterText = CounterClick.counter;

        if (counterText >= manatMultiplier * 10)
        {
            if (manatMultiplier == 1)
            {
                soldier1EmptyInventory.SetActive(true);

                soldier1Level++;

                soldier1LevelTextMesh.text = "Level = " + soldier1Level.ToString() + " => +" + (soldier1Level).ToString() + " CP";
            }

            else if (manatMultiplier > 1)
            {
                soldier1Level ++;

                soldier1LevelTextMesh.text = "Level = " + soldier1Level.ToString() + " => +" + (soldier1Level).ToString() + " CP";
            }

            counterText -= manatMultiplier * 10;

            CounterClick.counter = counterText;

            BokButtonClick.counterMultiplier++;

            manatMultiplier++;

            // currentClickPowerPointTextMesh.text = BokButtonClick.counterMultiplier.ToString();

            if (BokButtonClick.counterMultiplier < 1000)
            {
                currentClickPowerPointTextMesh.text = BokButtonClick.counterMultiplier.ToString("F0");
            }

            else
            {
                currentClickPowerPointTextMesh.text = CounterClick.WordNotationWithoutSP(BokButtonClick.counterMultiplier, "F1");
            }

            // manatTextMesh.text = ((manatMultiplier * 10) + " SP").ToString();

            if (manatMultiplier * 10 < 1000)
            {
                manatTextMesh.text = "/" + (manatMultiplier * 10).ToString("F0") + " SP";
            }

            else
            {
                manatTextMesh.text = "/" + CounterClick.WordNotation((manatMultiplier * 10), "F1");
            }
        }
    }

    public void Soldier3()
    {
        counterText = CounterClick.counter;

        if (counterText >= manatMultiplier3 * 20)
        {
            if (manatMultiplier3 == 1)
            {
                soldier3EmptyInventory.SetActive(true);

                soldier3Level++;

                soldier3LevelTextMesh.text = "Level = " + soldier3Level.ToString() + " => +" + (2 * soldier3Level).ToString() + " CP";
            }

            else if (manatMultiplier3 > 1)
            {
                soldier3Level++;

                soldier3LevelTextMesh.text = "Level = " + soldier3Level.ToString() + " => +" + (2 * soldier3Level).ToString() + " CP";
            }

            counterText -= manatMultiplier3 * 20;

            CounterClick.counter = counterText;

            BokButtonClick.counterMultiplier += 2;

            manatMultiplier3++;

            // currentClickPowerPointTextMesh.text = BokButtonClick.counterMultiplier.ToString();

            if (BokButtonClick.counterMultiplier < 1000)
            {
                currentClickPowerPointTextMesh.text = BokButtonClick.counterMultiplier.ToString("F0");
            }

            else
            {
                currentClickPowerPointTextMesh.text = CounterClick.WordNotationWithoutSP(BokButtonClick.counterMultiplier, "F1");
            }

            // manat3TextMesh.text = ((manatMultiplier3 * 20) + " SP").ToString();

            if (manatMultiplier3 * 20 < 1000)
            {
                manat3TextMesh.text = "/" + (manatMultiplier3 * 20).ToString("F0") + " SP";
            }

            else
            {
                manat3TextMesh.text = "/" + CounterClick.WordNotation((manatMultiplier3 * 20), "F1");
            }
        }
    }

    public void Soldier5()
    {
        counterText = CounterClick.counter;

        if (counterText >= 1000 + (manatMultiplier5 - 1) * 1000)
        {
            if (manatMultiplier5 == 1)
            {
                soldier5EmptyInventory.SetActive(true);

                soldier5Level++;

                soldier5LevelTextMesh.text = "Level = " + soldier5Level.ToString() + " => +" + (16 * soldier5Level).ToString() + " CP / " + (16 * soldier5Level).ToString() + " ESP";
            }

            else if (manatMultiplier5 > 1)
            {
                soldier5Level++;

                soldier5LevelTextMesh.text = "Level = " + soldier5Level.ToString() + " => +" + (16 * soldier5Level).ToString() + " CP / " + (16 * soldier5Level).ToString() + " ESP";
            }

            counterText -= 1000 + (manatMultiplier5 - 1) * 1000;

            CounterClick.counter = counterText;

            BokButtonClick.counterMultiplier += 16;

            CounterClick.everySecondGetPoint += 8;

            manatMultiplier5++;

            // currentClickPowerPointTextMesh.text = BokButtonClick.counterMultiplier.ToString();

            if (BokButtonClick.counterMultiplier < 1000)
            {
                currentClickPowerPointTextMesh.text = BokButtonClick.counterMultiplier.ToString("F0");
            }

            else
            {
                currentClickPowerPointTextMesh.text = CounterClick.WordNotationWithoutSP(BokButtonClick.counterMultiplier, "F1");
            }

            // currentEverySecondPowerPointTextMesh.text = (2 * CounterClick.everySecondGetPoint).ToString();

            if (CounterClick.everySecondGetPoint * 2 < 1000)
            {
                currentEverySecondPowerPointTextMesh.text = (CounterClick.everySecondGetPoint * 2).ToString("F0");
            }

            else
            {
                currentEverySecondPowerPointTextMesh.text = CounterClick.WordNotationWithoutSP(CounterClick.everySecondGetPoint * 2, "F1");
            }

            // manat5TextMesh.text = (1000 + (manatMultiplier5 - 1) * 1000 + " SP").ToString();

            manat5TextMesh.text = "/" + CounterClick.WordNotation(1000 + (manatMultiplier5 - 1) * 1000, "F0");
        }
    }
}
