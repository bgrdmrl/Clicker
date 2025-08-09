using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Skills : MonoBehaviour
{
    public TextMeshProUGUI clickPowerTextMesh;
    public TextMeshProUGUI everySecondPowerTextMesh;
    public TextMeshProUGUI bossPointTextMesh;

    public Button BossesButton;
    public Button skill1Button;
    public Button skill2Button;
    public Button skill3Button;
    public Button skill4Button;
    public Button skill5Button;

    public Image timerBar1;
    public Image timerBar2;
    public Image timerBar3;
    public Image timerBar4;
    public Image timerBar5;
    public Image timerBarBossesButton;

    public float maxTime1 = 30;
    public float currentTime1 = 0;
    public float maxTime2 = 30;
    public float currentTime2 = 0;
    public float maxTime3 = 30;
    public float currentTime3 = 0;
    public float maxTime4 = 30;
    public float currentTime4 = 0;
    public float maxTime5 = 30;
    public float currentTime5 = 0;
    public float maxTimeBossesButton = 30;
    public float currentTimeBossesButton = 0;

    public static int bossPointText = 0;
    public static float boostedPower1 = 0.0f;
    public static float boostedPower2 = 0.0f;
    public static float boostedPower3Click = 0.0f;
    public static float boostedPower3EverySecond = 0.0f;
    public static float boostedPower4 = 0.0f;
    public static float boostedPower5 = 0.0f;
    public static float currentClickPower = 0.0f;
    public static float currentEverySecondPower = 0.0f;

    public static bool isSkill1On = false;
    public static bool isSkill2On = false;
    public static bool isSkill3On = false;
    public static bool isSkill4On = false;
    public static bool isSkill5On = false;

    void Start()
    {
        timerBar1.transform.localScale = new Vector3(0, 0, 0);
        timerBar2.transform.localScale = new Vector3(0, 0, 0);
        timerBar3.transform.localScale = new Vector3(0, 0, 0);
        timerBar4.transform.localScale = new Vector3(0, 0, 0);
        timerBar5.transform.localScale = new Vector3(0, 0, 0);
        timerBarBossesButton.transform.localScale = new Vector3(0, 0, 0);

        if (isSkill1On)
        {
            clickPowerTextMesh.text = (currentClickPower - boostedPower1).ToString();

            BokButtonClick.counterMultiplier -= boostedPower1;

            isSkill1On = false;

            PlayerPrefs.SetInt("SavedIsSkill1On", isSkill1On ? 1 : 0);

            isSkill1On = PlayerPrefs.GetInt("SavedIsSkill1On") == 1;
        }

        if (isSkill2On)
        {
            everySecondPowerTextMesh.text = (currentEverySecondPower - boostedPower2).ToString();

            CounterClick.everySecondGetPoint -= boostedPower2 / 2;

            isSkill2On = false;

            PlayerPrefs.SetInt("SavedIsSkill2On", isSkill2On ? 1 : 0);

            isSkill2On = PlayerPrefs.GetInt("SavedIsSkill2On") == 1;
        }

        if (isSkill3On)
        {
            clickPowerTextMesh.text = (currentClickPower - boostedPower3Click).ToString();

            BokButtonClick.counterMultiplier -= boostedPower3Click;

            everySecondPowerTextMesh.text = (currentEverySecondPower - boostedPower3EverySecond).ToString();

            CounterClick.everySecondGetPoint -= boostedPower3EverySecond / 2;

            isSkill3On = false;

            PlayerPrefs.SetInt("SavedIsSkill3On", isSkill3On ? 1 : 0);

            isSkill3On = PlayerPrefs.GetInt("SavedIsSkill3On") == 1;
        }

        if (isSkill4On)
        {
            clickPowerTextMesh.text = (currentClickPower - 9 * boostedPower4).ToString();

            BokButtonClick.counterMultiplier -= 9 * boostedPower4;

            isSkill4On = false;

            PlayerPrefs.SetInt("SavedIsSkill4On", isSkill4On ? 1 : 0);

            isSkill4On = PlayerPrefs.GetInt("SavedIsSkill4On") == 1;
        }

        if (isSkill5On)
        {
            everySecondPowerTextMesh.text = (currentEverySecondPower - 9 * boostedPower5).ToString();

            CounterClick.everySecondGetPoint -= 9 * (boostedPower5 / 2);

            isSkill5On = false;

            PlayerPrefs.SetInt("SavedIsSkill5On", isSkill5On ? 1 : 0);

            isSkill5On = PlayerPrefs.GetInt("SavedIsSkill5On") == 1;
        }
    }

    void Update()
    {
        currentClickPower = BokButtonClick.counterMultiplier;
        currentEverySecondPower = CounterClick.everySecondGetPoint * 2;

        PlayerPrefs.SetFloat("SavedCurrentClickPower", currentClickPower);
        PlayerPrefs.SetFloat("SavedCurrentEverySecondPower", currentEverySecondPower);

        if (isSkill1On)
        {
            if (currentTime1 > 0)
            {
                currentTime1 -= 1 * Time.deltaTime;
            }

            timerBar1.transform.localScale = new Vector3(currentTime1 / maxTime1, 1, 1);
        }

        if (isSkill2On)
        {
            if (currentTime2 > 0)
            {
                currentTime2 -= 1 * Time.deltaTime;
            }

            timerBar2.transform.localScale = new Vector3(currentTime2 / maxTime2, 1, 1);
        }

        if (isSkill3On)
        {
            if (currentTime3 > 0)
            {
                currentTime3 -= 1 * Time.deltaTime;
            }

            timerBar3.transform.localScale = new Vector3(currentTime3 / maxTime3, 1, 1);
        }

        if (isSkill4On)
        {
            if (currentTime4 > 0)
            {
                currentTime4 -= 1 * Time.deltaTime;
            }

            timerBar4.transform.localScale = new Vector3(currentTime4 / maxTime4, 1, 1);
        }

        if (isSkill5On)
        {
            if (currentTime5 > 0)
            {
                currentTime5 -= 1 * Time.deltaTime;
            }

            timerBar5.transform.localScale = new Vector3(currentTime5 / maxTime5, 1, 1);
        }

        if (isSkill1On || isSkill2On || isSkill3On || isSkill4On || isSkill5On)
        {
            if (currentTimeBossesButton > 0)
            {
                currentTimeBossesButton -= 1 * Time.deltaTime;
            }

            timerBarBossesButton.transform.localScale = new Vector3(currentTimeBossesButton / maxTimeBossesButton, 1, 1);
        }
    }

    public void Skill1()
    {
        currentTime1 = maxTime1;
        currentTimeBossesButton = maxTimeBossesButton;

        bossPointText = System.Convert.ToInt32(bossPointTextMesh.text);
        boostedPower1 = BokButtonClick.counterMultiplier;

        if (bossPointText >= 1)
        {
            skill1Button.interactable = false;
            skill2Button.interactable = false;
            skill3Button.interactable = false;
            skill4Button.interactable = false;
            skill5Button.interactable = false;
            BossesButton.interactable = false;

            bossPointText -= 1;

            Boss.bossPoint = bossPointText;

            bossPointTextMesh.text = Boss.bossPoint.ToString();

            isSkill1On = true;

            PlayerPrefs.SetInt("SavedIsSkill1On", isSkill1On ? 1 : 0);

            StartCoroutine(Skill1Enumerator());
        }
    }

    IEnumerator Skill1Enumerator()
    {
        while (isSkill1On)
        {
            // clickPowerTextMesh.text = (2 * boostedPower1).ToString();

            BokButtonClick.counterMultiplier += boostedPower1;

            if (BokButtonClick.counterMultiplier < 1000)
            {
                clickPowerTextMesh.text = (BokButtonClick.counterMultiplier).ToString();
            }

            else
            {
                clickPowerTextMesh.text = CounterClick.WordNotationWithoutSP(BokButtonClick.counterMultiplier, "F1");
            }

            yield return new WaitForSeconds(30f);

            // clickPowerTextMesh.text = (currentClickPower - boostedPower1).ToString();

            BokButtonClick.counterMultiplier -= boostedPower1;

            if (BokButtonClick.counterMultiplier < 1000)
            {
                clickPowerTextMesh.text = (BokButtonClick.counterMultiplier).ToString();
            }

            else
            {
                clickPowerTextMesh.text = CounterClick.WordNotationWithoutSP(BokButtonClick.counterMultiplier, "F1");
            }

            isSkill1On = false;

            PlayerPrefs.SetInt("SavedIsSkill1On", isSkill1On ? 1 : 0);

            skill1Button.interactable = true;
            skill2Button.interactable = true;
            skill3Button.interactable = true;
            skill4Button.interactable = true;
            skill5Button.interactable = true;
            BossesButton.interactable = true;
        }
    }

    public void Skill2()
    {
        currentTime2 = maxTime2;
        currentTimeBossesButton = maxTimeBossesButton;

        bossPointText = System.Convert.ToInt32(bossPointTextMesh.text);
        boostedPower2 = CounterClick.everySecondGetPoint * 2;

        if (bossPointText >= 2)
        {
            skill1Button.interactable = false;
            skill2Button.interactable = false;
            skill3Button.interactable = false;
            skill4Button.interactable = false;
            skill5Button.interactable = false;
            BossesButton.interactable = false;

            bossPointText -= 2;

            Boss.bossPoint = bossPointText;

            bossPointTextMesh.text = Boss.bossPoint.ToString();

            isSkill2On = true;

            PlayerPrefs.SetInt("SavedIsSkill2On", isSkill2On ? 1 : 0);

            StartCoroutine(Skill2Enumerator());
        }
    }

    IEnumerator Skill2Enumerator()
    {
        while (isSkill2On)
        {
            // everySecondPowerTextMesh.text = (2 * boostedPower2).ToString();

            CounterClick.everySecondGetPoint += boostedPower2 / 2;

            if (CounterClick.everySecondGetPoint * 2 < 1000)
            {
                everySecondPowerTextMesh.text = (CounterClick.everySecondGetPoint * 2).ToString();
            }

            else
            {
                everySecondPowerTextMesh.text = CounterClick.WordNotationWithoutSP(CounterClick.everySecondGetPoint * 2, "F1");
            }

            yield return new WaitForSeconds(30f);

            // everySecondPowerTextMesh.text = (currentEverySecondPower - boostedPower2).ToString();

            CounterClick.everySecondGetPoint -= boostedPower2 / 2;

            if (CounterClick.everySecondGetPoint * 2 < 1000)
            {
                everySecondPowerTextMesh.text = (CounterClick.everySecondGetPoint * 2).ToString();
            }

            else
            {
                everySecondPowerTextMesh.text = CounterClick.WordNotationWithoutSP(CounterClick.everySecondGetPoint * 2, "F1");
            }

            isSkill2On = false;

            PlayerPrefs.SetInt("SavedIsSkill2On", isSkill2On ? 1 : 0);

            skill1Button.interactable = true;
            skill2Button.interactable = true;
            skill3Button.interactable = true;
            skill4Button.interactable = true;
            skill5Button.interactable = true;
            BossesButton.interactable = true;
        }
    }

    public void Skill3()
    {
        currentTime3 = maxTime3;
        currentTimeBossesButton = maxTimeBossesButton;

        bossPointText = System.Convert.ToInt32(bossPointTextMesh.text);
        boostedPower3Click = BokButtonClick.counterMultiplier;
        boostedPower3EverySecond = CounterClick.everySecondGetPoint * 2;

        if (bossPointText >= 3)
        {
            skill1Button.interactable = false;
            skill2Button.interactable = false;
            skill3Button.interactable = false;
            skill4Button.interactable = false;
            skill5Button.interactable = false;
            BossesButton.interactable = false;

            bossPointText -= 3;

            Boss.bossPoint = bossPointText;

            bossPointTextMesh.text = Boss.bossPoint.ToString();

            isSkill3On = true;

            PlayerPrefs.SetInt("SavedIsSkill3On", isSkill3On ? 1 : 0);

            StartCoroutine(Skill3Enumerator());
        }
    }

    IEnumerator Skill3Enumerator()
    {
        while (isSkill3On)
        {
            // clickPowerTextMesh.text = (2 * boostedPower3Click).ToString();

            BokButtonClick.counterMultiplier += boostedPower3Click;

            if (BokButtonClick.counterMultiplier < 1000)
            {
                clickPowerTextMesh.text = (BokButtonClick.counterMultiplier).ToString();
            }

            else
            {
                clickPowerTextMesh.text = CounterClick.WordNotationWithoutSP(BokButtonClick.counterMultiplier, "F1");
            }

            // everySecondPowerTextMesh.text = (2 * boostedPower3EverySecond).ToString();

            CounterClick.everySecondGetPoint += boostedPower3EverySecond / 2;

            if (CounterClick.everySecondGetPoint * 2 < 1000)
            {
                everySecondPowerTextMesh.text = (CounterClick.everySecondGetPoint * 2).ToString();
            }

            else
            {
                everySecondPowerTextMesh.text = CounterClick.WordNotationWithoutSP(CounterClick.everySecondGetPoint * 2, "F1");
            }

            yield return new WaitForSeconds(30f);

            // clickPowerTextMesh.text = (currentClickPower - boostedPower3Click).ToString();

            BokButtonClick.counterMultiplier -= boostedPower3Click;

            if (BokButtonClick.counterMultiplier < 1000)
            {
                clickPowerTextMesh.text = (BokButtonClick.counterMultiplier).ToString();
            }

            else
            {
                clickPowerTextMesh.text = CounterClick.WordNotationWithoutSP(BokButtonClick.counterMultiplier, "F1");
            }

            // everySecondPowerTextMesh.text = (currentEverySecondPower - boostedPower3EverySecond).ToString();

            CounterClick.everySecondGetPoint -= boostedPower3EverySecond / 2;

            if (CounterClick.everySecondGetPoint * 2 < 1000)
            {
                everySecondPowerTextMesh.text = (CounterClick.everySecondGetPoint * 2).ToString();
            }

            else
            {
                everySecondPowerTextMesh.text = CounterClick.WordNotationWithoutSP(CounterClick.everySecondGetPoint * 2, "F1");
            }

            isSkill3On = false;

            PlayerPrefs.SetInt("SavedIsSkill3On", isSkill3On ? 1 : 0);

            skill1Button.interactable = true;
            skill2Button.interactable = true;
            skill3Button.interactable = true;
            skill4Button.interactable = true;
            skill5Button.interactable = true;
            BossesButton.interactable = true;
        }
    }

    public void Skill4()
    {
        currentTime4 = maxTime4;
        currentTimeBossesButton = maxTimeBossesButton;

        bossPointText = System.Convert.ToInt32(bossPointTextMesh.text);
        boostedPower4 = BokButtonClick.counterMultiplier;

        if (bossPointText >= 10)
        {
            skill1Button.interactable = false;
            skill2Button.interactable = false;
            skill3Button.interactable = false;
            skill4Button.interactable = false;
            skill5Button.interactable = false;
            BossesButton.interactable = false;

            bossPointText -= 10;

            Boss.bossPoint = bossPointText;

            bossPointTextMesh.text = Boss.bossPoint.ToString();

            isSkill4On = true;

            PlayerPrefs.SetInt("SavedIsSkill4On", isSkill4On ? 1 : 0);

            StartCoroutine(Skill4Enumerator());
        }
    }

    IEnumerator Skill4Enumerator()
    {
        while (isSkill4On)
        {
            // clickPowerTextMesh.text = (10 * boostedPower4).ToString();

            BokButtonClick.counterMultiplier += 9 * boostedPower4;

            if (BokButtonClick.counterMultiplier < 1000)
            {
                clickPowerTextMesh.text = (BokButtonClick.counterMultiplier).ToString();
            }

            else
            {
                clickPowerTextMesh.text = CounterClick.WordNotationWithoutSP(BokButtonClick.counterMultiplier, "F1");
            }

            yield return new WaitForSeconds(30f);

            // clickPowerTextMesh.text = (currentClickPower - 9 * boostedPower4).ToString();

            BokButtonClick.counterMultiplier -= 9 * boostedPower4;

            if (BokButtonClick.counterMultiplier < 1000)
            {
                clickPowerTextMesh.text = (BokButtonClick.counterMultiplier).ToString();
            }

            else
            {
                clickPowerTextMesh.text = CounterClick.WordNotationWithoutSP(BokButtonClick.counterMultiplier, "F1");
            }

            isSkill4On = false;

            PlayerPrefs.SetInt("SavedIsSkill4On", isSkill4On ? 1 : 0);

            skill1Button.interactable = true;
            skill2Button.interactable = true;
            skill3Button.interactable = true;
            skill4Button.interactable = true;
            skill5Button.interactable = true;
            BossesButton.interactable = true;
        }
    }

    public void Skill5()
    {
        currentTime5 = maxTime5;
        currentTimeBossesButton = maxTimeBossesButton;

        bossPointText = System.Convert.ToInt32(bossPointTextMesh.text);
        boostedPower5 = CounterClick.everySecondGetPoint * 2;

        if (bossPointText >= 10)
        {
            skill1Button.interactable = false;
            skill2Button.interactable = false;
            skill3Button.interactable = false;
            skill4Button.interactable = false;
            skill5Button.interactable = false;
            BossesButton.interactable = false;

            bossPointText -= 10;

            Boss.bossPoint = bossPointText;

            bossPointTextMesh.text = Boss.bossPoint.ToString();

            isSkill5On = true;

            PlayerPrefs.SetInt("SavedIsSkill5On", isSkill5On ? 1 : 0);

            StartCoroutine(Skill5Enumerator());
        }
    }

    IEnumerator Skill5Enumerator()
    {
        while (isSkill5On)
        {
            // everySecondPowerTextMesh.text = (10 * boostedPower5).ToString();

            CounterClick.everySecondGetPoint += 9 * (boostedPower5 / 2);

            if (CounterClick.everySecondGetPoint * 2 < 1000)
            {
                everySecondPowerTextMesh.text = (CounterClick.everySecondGetPoint * 2).ToString();
            }

            else
            {
                everySecondPowerTextMesh.text = CounterClick.WordNotationWithoutSP(CounterClick.everySecondGetPoint * 2, "F1");
            }

            yield return new WaitForSeconds(30f);

            // everySecondPowerTextMesh.text = (currentEverySecondPower - 9 * boostedPower5).ToString();

            CounterClick.everySecondGetPoint -= 9 * (boostedPower5 / 2);

            if (CounterClick.everySecondGetPoint * 2 < 1000)
            {
                everySecondPowerTextMesh.text = (CounterClick.everySecondGetPoint * 2).ToString();
            }

            else
            {
                everySecondPowerTextMesh.text = CounterClick.WordNotationWithoutSP(CounterClick.everySecondGetPoint * 2, "F1");
            }

            isSkill5On = false;

            PlayerPrefs.SetInt("SavedIsSkill5On", isSkill5On ? 1 : 0);

            skill1Button.interactable = true;
            skill2Button.interactable = true;
            skill3Button.interactable = true;
            skill4Button.interactable = true;
            skill5Button.interactable = true;
            BossesButton.interactable = true;
        }
    }

    //void OnApplicationQuit()
    //{
    //    if (isSkill1On)
    //    {
    //        clickPowerTextMesh.text = (currentClickPower - boostedPower1).ToString();

    //        BokButtonClick.counterMultiplier -= boostedPower1;
    //    }

    //    if (isSkill2On)
    //    {
    //        everySecondPowerTextMesh.text = (currentEverySecondPower - boostedPower2).ToString();

    //        CounterClick.everySecondGetPoint -= boostedPower2 / 2;
    //    }

    //    if (isSkill3On)
    //    {
    //        clickPowerTextMesh.text = (currentClickPower - boostedPower3Click).ToString();

    //        BokButtonClick.counterMultiplier -= boostedPower3Click;

    //        everySecondPowerTextMesh.text = (currentEverySecondPower - boostedPower3EverySecond).ToString();

    //        CounterClick.everySecondGetPoint -= boostedPower3EverySecond / 2;
    //    }

    //    if (isSkill4On)
    //    {
    //        clickPowerTextMesh.text = (currentClickPower - 9 * boostedPower4).ToString();

    //        BokButtonClick.counterMultiplier -= 9 * boostedPower4;
    //    }

    //    if (isSkill5On)
    //    {
    //        everySecondPowerTextMesh.text = (currentEverySecondPower - 9 * boostedPower5).ToString();

    //        CounterClick.everySecondGetPoint -= 9 * (boostedPower5 / 2);
    //    }

    //    SaveGame.SaveTheGame();
    //}
}
