using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button2Click : MonoBehaviour                               // every second power artýran askerler
{
    public TextMeshProUGUI counterTextMesh;
    public TextMeshProUGUI point2TextMesh;
    public TextMeshProUGUI point4TextMesh;
    public TextMeshProUGUI currentEverySecondPowerPointTextMesh;

    public GameObject soldier2EmptyInventory;
    public GameObject soldier4EmptyInventory;

    public TextMeshProUGUI soldier2LevelTextMesh;
    public TextMeshProUGUI soldier4LevelTextMesh;

    public static float pointMultiplier2 = 1.0f;
    public static float pointMultiplier4 = 1.0f;
    public static float counterText = 0.0f;

    public static int soldier2Level = 0;
    public static int soldier4Level = 0;

    public void Soldier2()
    {
        counterText = CounterClick.counter;

        if (counterText >= 50 + (pointMultiplier2 - 1) * 250)
        {
            if (pointMultiplier2 == 1)
            {
                soldier2EmptyInventory.SetActive(true);

                soldier2Level++;

                soldier2LevelTextMesh.text = "Level = " + soldier2Level.ToString() + " => +" + (2 * soldier2Level).ToString() + " ESP";
            }

            else if (pointMultiplier2 > 1)
            {
                soldier2Level++;

                soldier2LevelTextMesh.text = "Level = " + soldier2Level.ToString() + " => +" + (2 * soldier2Level).ToString() + " ESP";
            }

            counterText -= 50 + (pointMultiplier2 - 1) * 250;

            CounterClick.everySecondGetPoint++;

            CounterClick.counter = counterText;

            pointMultiplier2++;

            // currentEverySecondPowerPointTextMesh.text = (2 * CounterClick.everySecondGetPoint).ToString();

            if (CounterClick.everySecondGetPoint * 2 < 1000)
            {
                currentEverySecondPowerPointTextMesh.text = (CounterClick.everySecondGetPoint * 2).ToString("F0");
            }

            else
            {
                currentEverySecondPowerPointTextMesh.text = CounterClick.WordNotationWithoutSP(CounterClick.everySecondGetPoint * 2, "F1");
            }

            // point2TextMesh.text = (50 + (pointMultiplier2 - 1) * 250 + " SP").ToString();

            if ((50 + ((pointMultiplier2 - 1) * 250)) < 1000)
            {
                point2TextMesh.text = "/" + (50 + ((pointMultiplier2 - 1) * 250)).ToString("F0") + " SP";
            }

            else
            {
                point2TextMesh.text = "/" + CounterClick.WordNotation(50 + ((pointMultiplier2 - 1) * 250), "F1");
            }
        }
    }

    public void Soldier4()
    {
        counterText = CounterClick.counter;

        if (counterText >= 200 + (pointMultiplier4 - 1) * 400)
        {
            if (pointMultiplier4 == 1)
            {
                soldier4EmptyInventory.SetActive(true);

                soldier4Level++;

                soldier4LevelTextMesh.text = "Level = " + soldier4Level.ToString() + " => +" + (4 * soldier4Level).ToString() + " ESP";
            }

            else if (pointMultiplier4 > 1)
            {
                soldier4Level++;

                soldier4LevelTextMesh.text = "Level = " + soldier4Level.ToString() + " => +" + (4 * soldier4Level).ToString() + " ESP";
            }

            counterText -= 200 + (pointMultiplier4 - 1) * 400;

            CounterClick.everySecondGetPoint += 2;

            CounterClick.counter = counterText;

            pointMultiplier4 ++;

            // currentEverySecondPowerPointTextMesh.text = (2 * CounterClick.everySecondGetPoint).ToString();

            if (CounterClick.everySecondGetPoint * 2 < 1000)
            {
                currentEverySecondPowerPointTextMesh.text = (CounterClick.everySecondGetPoint * 2).ToString("F0");
            }

            else
            {
                currentEverySecondPowerPointTextMesh.text = CounterClick.WordNotationWithoutSP(CounterClick.everySecondGetPoint * 2, "F1");
            }

            // point4TextMesh.text = (200 + (pointMultiplier4 - 1) * 400 + " SP").ToString();

            if ((200 + ((pointMultiplier4 - 1) * 400)) < 1000)
            {
                point4TextMesh.text = "/" + (200 + ((pointMultiplier4 - 1) * 400)).ToString("F0") + " SP";
            }

            else
            {
                point4TextMesh.text = "/" + CounterClick.WordNotation(200 + ((pointMultiplier4 - 1) * 400), "F1");
            }
        }
    }
}
