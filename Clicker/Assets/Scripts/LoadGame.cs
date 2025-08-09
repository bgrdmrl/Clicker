using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{
    public static float savedEverySecondGetPoint;
    public static float savedCounterMultiplier;

    public float savedCounterText1;
    public float savedManatMultiplier;
    public float savedManatMultiplier3;
    public float savedManatMultiplier5;
    public float savedPointMultiplier2;
    public float savedPointMultiplier4;
    public float savedCounterText2;

    public int savedSpriteIndex;
    public int savedBossPoint;
    public int savedRestartBossPoint;
    public int savedIsLastBossKilled;

    public int savedSoldier1Level;
    public int savedSoldier2Level;
    public int savedSoldier3Level;
    public int savedSoldier4Level;
    public int savedSoldier5Level;

    public TextMeshProUGUI currentClickPowerPointTextMesh;
    public TextMeshProUGUI currentEverySecondPowerPointTextMesh;
    public TextMeshProUGUI bossPointTextMesh;
    public TextMeshProUGUI restartBossPointTextMesh;

    public TextMeshProUGUI manatTextMesh;
    public TextMeshProUGUI manat3TextMesh;
    public TextMeshProUGUI manat5TextMesh;
    public TextMeshProUGUI point2TextMesh;
    public TextMeshProUGUI point4TextMesh;

    public TextMeshProUGUI soldier1LevelTextMesh;
    public TextMeshProUGUI soldier2LevelTextMesh;
    public TextMeshProUGUI soldier3LevelTextMesh;
    public TextMeshProUGUI soldier4LevelTextMesh;
    public TextMeshProUGUI soldier5LevelTextMesh;

    public Button soldierButton1;
    public Button soldierButton2;
    public Button soldierButton3;
    public Button soldierButton4;
    public Button soldierButton5;

    public Button skill1Button;
    public Button skill2Button;
    public Button skill3Button;
    public Button skill4Button;
    public Button skill5Button;
    public Button BossesButton;

    public GameObject soldier1EmptyInventory;
    public GameObject soldier2EmptyInventory;
    public GameObject soldier3EmptyInventory;
    public GameObject soldier4EmptyInventory;
    public GameObject soldier5EmptyInventory;


    void Awake()
    {

        //if (PlayerPrefs.HasKey(BokButtonClick.counterMultiplier.ToString()))
        //{
        //    savedCounterMultiplier = PlayerPrefs.GetFloat("SavedCounterMultiplier");
        //    BokButtonClick.counterMultiplier = savedCounterMultiplier;
        //}

        savedCounterMultiplier = PlayerPrefs.GetFloat("SavedCounterMultiplier");
        BokButtonClick.counterMultiplier = savedCounterMultiplier;

        savedEverySecondGetPoint = PlayerPrefs.GetFloat("SavedEverySecondGetPoint");
        CounterClick.everySecondGetPoint = savedEverySecondGetPoint;
        savedCounterText1 = PlayerPrefs.GetFloat("SavedCounterText1");
        Button1Click.counterText = savedCounterText1;
        savedManatMultiplier = PlayerPrefs.GetFloat("SavedManatMultiplier");
        Button1Click.manatMultiplier = savedManatMultiplier;
        savedManatMultiplier3 = PlayerPrefs.GetFloat("SavedManatMultiplier3");
        Button1Click.manatMultiplier3 = savedManatMultiplier3;
        savedManatMultiplier5 = PlayerPrefs.GetFloat("SavedManatMultiplier5");
        Button1Click.manatMultiplier5 = savedManatMultiplier5;
        savedPointMultiplier2 = PlayerPrefs.GetFloat("SavedPointMultiplier2");
        Button2Click.pointMultiplier2 = savedPointMultiplier2;
        savedPointMultiplier4 = PlayerPrefs.GetFloat("SavedPointMultiplier4");
        Button2Click.pointMultiplier4 = savedPointMultiplier4;
        savedCounterText2 = PlayerPrefs.GetFloat("SavedCounterText2");
        Button1Click.counterText = savedCounterText2;
        savedSpriteIndex = PlayerPrefs.GetInt("SavedSpriteIndex");
        Controller.spriteIndex = savedSpriteIndex;
        savedBossPoint = PlayerPrefs.GetInt("SavedBossPoint");
        Boss.bossPoint = savedBossPoint;
        savedRestartBossPoint = PlayerPrefs.GetInt("SavedRestartBossPoint");
        Boss.restartBossPoint = savedRestartBossPoint;

        Boss.isLastBossKilled = PlayerPrefs.GetInt("SavedIsLastBossKilled") == 1;

        savedSoldier1Level = PlayerPrefs.GetInt("SavedSoldier1Level");
        Button1Click.soldier1Level = savedSoldier1Level;
        savedSoldier2Level = PlayerPrefs.GetInt("SavedSoldier2Level");
        Button2Click.soldier2Level = savedSoldier2Level;
        savedSoldier3Level = PlayerPrefs.GetInt("SavedSoldier3Level");
        Button1Click.soldier3Level = savedSoldier3Level;
        savedSoldier4Level = PlayerPrefs.GetInt("SavedSoldier4Level");
        Button2Click.soldier4Level = savedSoldier4Level;
        savedSoldier5Level = PlayerPrefs.GetInt("SavedSoldier5Level");
        Button1Click.soldier5Level = savedSoldier5Level;

        Skills.isSkill1On = PlayerPrefs.GetInt("SavedIsSkill1On") == 1;
        Skills.isSkill2On = PlayerPrefs.GetInt("SavedIsSkill2On") == 1;
        Skills.isSkill3On = PlayerPrefs.GetInt("SavedIsSkill3On") == 1;
        Skills.isSkill4On = PlayerPrefs.GetInt("SavedIsSkill4On") == 1;
        Skills.isSkill5On = PlayerPrefs.GetInt("SavedIsSkill5On") == 1;

        Skills.currentClickPower = PlayerPrefs.GetFloat("SavedCurrentClickPower");
        Skills.currentEverySecondPower = PlayerPrefs.GetFloat("SavedCurrentEverySecondPower");
        Skills.boostedPower1 = PlayerPrefs.GetFloat("SavedBoostedPower1");
        Skills.boostedPower2 = PlayerPrefs.GetFloat("SavedBoostedPower2");
        Skills.boostedPower3Click = PlayerPrefs.GetFloat("SavedBoostedPower3Click");
        Skills.boostedPower3EverySecond = PlayerPrefs.GetFloat("SavedBoostedPower3EverySecond");
        Skills.boostedPower4 = PlayerPrefs.GetFloat("SavedBoostedPower4");
        Skills.boostedPower5 = PlayerPrefs.GetFloat("SavedBoostedPower5");

        //________________________________________________________Boþluk :)_________________________________________________________//

        // currentClickPowerPointTextMesh.text = savedCounterMultiplier.ToString();
        // currentEverySecondPowerPointTextMesh.text = (savedEverySecondGetPoint * 2).ToString();

        if (BokButtonClick.counterMultiplier < 1000)
        {
            currentClickPowerPointTextMesh.text = BokButtonClick.counterMultiplier.ToString("F0");
        }

        else
        {
            currentClickPowerPointTextMesh.text = CounterClick.WordNotationWithoutSP(BokButtonClick.counterMultiplier, "F1");
        }

        if (CounterClick.everySecondGetPoint * 2 < 1000)
        {
            currentEverySecondPowerPointTextMesh.text = (CounterClick.everySecondGetPoint * 2).ToString("F0");
        }

        else
        {
            currentEverySecondPowerPointTextMesh.text = CounterClick.WordNotationWithoutSP(CounterClick.everySecondGetPoint * 2, "F1");
        }

        bossPointTextMesh.text = savedBossPoint.ToString();
        restartBossPointTextMesh.text = savedRestartBossPoint.ToString();

        // manatTextMesh.text = ((savedManatMultiplier * 10) + " SP").ToString();

        if (Button1Click.manatMultiplier * 10 < 1000)
        {
            manatTextMesh.text = "/" + (Button1Click.manatMultiplier * 10).ToString("F0") + " SP";
        }

        else
        {
            manatTextMesh.text = "/" + CounterClick.WordNotation((Button1Click.manatMultiplier * 10), "F1");
        }

        // manat3TextMesh.text = ((savedManatMultiplier3 * 20) + " SP").ToString();

        if (Button1Click.manatMultiplier3 * 20 < 1000)
        {
            manat3TextMesh.text = "/" + (Button1Click.manatMultiplier3 * 20).ToString("F0") + " SP";
        }

        else
        {
            manat3TextMesh.text = "/" + CounterClick.WordNotation((Button1Click.manatMultiplier3 * 20), "F1");
        }

        // manat5TextMesh.text = (1000 + (savedManatMultiplier5 - 1) * 1000 + " SP").ToString();

        manat5TextMesh.text = "/" + CounterClick.WordNotation(1000 + ((savedManatMultiplier5 - 1) * 1000), "F1");


        // point2TextMesh.text = ((savedPointMultiplier2 * 50) + " SP").ToString();

        if ((50 + ((Button2Click.pointMultiplier2 - 1) * 250)) < 1000)
        {
            point2TextMesh.text = "/" + (50 + ((Button2Click.pointMultiplier2 - 1) * 250)).ToString("F0") + " SP";
        }

        else
        {
            point2TextMesh.text = "/" + CounterClick.WordNotation(50 + ((Button2Click.pointMultiplier2 - 1) * 250), "F1");
        }

        // point4TextMesh.text = ((savedPointMultiplier4 * 200) + " SP").ToString();

        if ((200 + ((Button2Click.pointMultiplier4 - 1) * 400)) < 1000)
        {
            point4TextMesh.text = "/" + (200 + ((Button2Click.pointMultiplier4 - 1) * 400)).ToString("F0") + " SP";
        }

        else
        {
            point4TextMesh.text = "/" + CounterClick.WordNotation(200 + ((Button2Click.pointMultiplier4 - 1) * 400), "F1");
        }

        //________________________________________________________Boþluk :)_________________________________________________________//

        if (savedCounterMultiplier > 1)
        {
            soldierButton1.gameObject.SetActive(true);
        }

        if (savedCounterMultiplier >= 10)
        {
            soldierButton3.gameObject.SetActive(true);
        }

        if (savedEverySecondGetPoint >= 5)
        {
            soldierButton5.gameObject.SetActive(true);
        }

        if (savedEverySecondGetPoint > 0 || savedSoldier1Level >= 5)
        {
            soldierButton2.gameObject.SetActive(true);
        }

        if (savedEverySecondGetPoint > 1)
        {
            soldierButton4.gameObject.SetActive(true);
        }

        //________________________________________________________Boþluk :)_________________________________________________________//

        if (savedSoldier1Level > 0)
        {
            soldier1EmptyInventory.SetActive(true);

            soldier1LevelTextMesh.text = "Level = " + savedSoldier1Level.ToString() + " => +" + (savedSoldier1Level).ToString() + " CP";
        }

        if (savedSoldier2Level > 0)
        {
            soldier2EmptyInventory.SetActive(true);

            soldier2LevelTextMesh.text = "Level = " + savedSoldier2Level.ToString() + " => +" + (2 * savedSoldier2Level).ToString() + " ESP";
        }

        if (savedSoldier3Level > 0)
        {
            soldier3EmptyInventory.SetActive(true);

            soldier3LevelTextMesh.text = "Level = " + savedSoldier3Level.ToString() + " => +" + (2 * savedSoldier3Level).ToString() + " CP";
        }

        if (savedSoldier4Level > 0)
        {
            soldier4EmptyInventory.SetActive(true);

            soldier4LevelTextMesh.text = "Level = " + savedSoldier4Level.ToString() + " => +" + (4 * savedSoldier4Level).ToString() + " ESP";
        }

        if (savedSoldier5Level > 0)
        {
            soldier5EmptyInventory.SetActive(true);

            soldier5LevelTextMesh.text = "Level = " + savedSoldier5Level.ToString() + " => +" + (16 * savedSoldier5Level).ToString() + " CP / +" + (16 * savedSoldier5Level).ToString() + " ESP";
        }
    }

    public void RestartGame()
    {
        CounterClick.counter = 0;
        CounterClick.everySecondGetPoint = 0;
        BokButtonClick.counterMultiplier = 1;
        Button1Click.counterText = 0;
        Button1Click.manatMultiplier = 1;
        Button1Click.manatMultiplier3 = 1;
        Button1Click.manatMultiplier5 = 1;
        Button2Click.pointMultiplier2 = 1;
        Button2Click.pointMultiplier4 = 1;
        Button1Click.counterText = 0;
        Controller.spriteIndex = 0;
        Boss.isLastBossKilled = false;
        Button1Click.soldier1Level = 0;
        Button2Click.soldier2Level = 0;
        Button1Click.soldier3Level = 0;
        Button2Click.soldier4Level = 0;
        Button1Click.soldier5Level = 0;

        Boss.bossPoint += Boss.restartBossPoint;

        Boss.restartBossPoint = 0;

        currentClickPowerPointTextMesh.text = 1.ToString();
        currentEverySecondPowerPointTextMesh.text = 0.ToString();

        restartBossPointTextMesh.text = 0.ToString();
        bossPointTextMesh.text = Boss.bossPoint.ToString();

        manatTextMesh.text = ("10 SP");
        manat3TextMesh.text = ("20 SP");
        manat5TextMesh.text = ("1000 SP");
        point2TextMesh.text = ("50 SP");
        point4TextMesh.text = ("200 SP");

        soldierButton1.gameObject.SetActive(false);
        soldierButton3.gameObject.SetActive(false);
        soldierButton5.gameObject.SetActive(false);
        soldierButton2.gameObject.SetActive(false);
        soldierButton4.gameObject.SetActive(false);

        soldier1EmptyInventory.SetActive(false);
        soldier2EmptyInventory.SetActive(false);
        soldier3EmptyInventory.SetActive(false);
        soldier4EmptyInventory.SetActive(false);
        soldier5EmptyInventory.SetActive(false);

        if (Skills.isSkill1On)
        {
            Skills.boostedPower1 = 0;

            Skills.isSkill1On = false;

            skill1Button.interactable = true;
        }

        if (Skills.isSkill2On)
        {
            Skills.boostedPower2 = 0;

            Skills.isSkill2On = false;

            skill2Button.interactable = true;
        }

        if (Skills.isSkill3On)
        {
            Skills.boostedPower3Click = 0;
            Skills.boostedPower3EverySecond = 0;

            Skills.isSkill3On = false;

            skill3Button.interactable = true;
        }

        if (Skills.isSkill4On)
        {
            Skills.boostedPower4 = 0;

            Skills.isSkill4On = false;

            skill4Button.interactable = true;
        }

        if (Skills.isSkill5On)
        {
            Skills.boostedPower5 = 0;

            Skills.isSkill5On = false;

            skill5Button.interactable = true;
        }

        BossesButton.interactable = true;

        SaveGame.SaveTheGame();
    }
}