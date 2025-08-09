using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class Boss : MonoBehaviour
{
    public static int bossPoint = 0;
    public static int restartBossPoint = 0;
    public static float bossMaxHealth;
    public static float bossCurrentHealth;
    public static bool isLastBossKilled = false;

    public float maxTime;
    float currentTime;
    public string[] bossNames;

    public Image timerBar;
    public Image healthBar;

    public Button bossButton;
    public Button continueButton;
    public GameObject giveUpButton;

    public TextMeshProUGUI bossTimer;
    public TextMeshProUGUI bossHealthTextMesh;
    public TextMeshProUGUI clickPowerTextMesh;
    public TextMeshProUGUI everySecondPowerTextMesh;
    public TextMeshProUGUI bossNameTextMesh;

    bool canHit;

    public GameObject youDiedPanel;

    public void GetBossImageAndName()
    {
        bossButton.image.sprite = Controller.instance.cChosenSourceSprite;

        bossNameTextMesh.text = bossNames[Controller.spriteIndex].ToString();
    }

    void Start()
    {

        SaveGame.isAutoSavingStarted = true;

        clickPowerTextMesh.text = BokButtonClick.counterMultiplier.ToString();
        everySecondPowerTextMesh.text = (CounterClick.everySecondGetPoint * 2).ToString();

        if (BokButtonClick.counterMultiplier < 1000)
        {
            clickPowerTextMesh.text = "Click Point = " + BokButtonClick.counterMultiplier.ToString("F0");
        }

        else
        {
            clickPowerTextMesh.text = "Click Point = " + CounterClick.WordNotationWithoutSP(BokButtonClick.counterMultiplier, "F1");
        }

        if (CounterClick.everySecondGetPoint * 2 < 1000)
        {
            everySecondPowerTextMesh.text = "Every Second Point = " + (CounterClick.everySecondGetPoint * 2).ToString("F0");
        }

        else
        {
            everySecondPowerTextMesh.text = "Every Second Point = " + CounterClick.WordNotationWithoutSP(CounterClick.everySecondGetPoint * 2, "F1");
        }

        GetBossImageAndName();

        bossCurrentHealth = bossMaxHealth;

        currentTime = maxTime;

        canHit = true;

        StartCoroutine(EverySecondHitDamage());
    }

    void Update()
    {
        bossHealthTextMesh.text = CounterClick.WordNotationWithoutSP(bossCurrentHealth, "F1") + "/" + CounterClick.WordNotationWithoutSP(bossMaxHealth, "F1");

        if (currentTime > 0)
        {
            currentTime -= 1 * Time.deltaTime;
        }

        timerBar.transform.localScale = new Vector3(currentTime / maxTime, 1, 1);
        bossTimer.text = currentTime.ToString("F1");

        if (currentTime <= 0)
        {
            canHit = false;
            youDiedPanel.SetActive(true);
            giveUpButton.SetActive(false);
        }
    }

    public void TakeDamage(float damage)
    {
        bossCurrentHealth -= damage;
        healthBar.transform.localScale = new Vector3(bossCurrentHealth / bossMaxHealth, 1, 1);

        if (bossCurrentHealth <= 0)
        {
            if (!isLastBossKilled)
            {
                if (Controller.spriteIndex == Controller.lastIndex)
                {
                    isLastBossKilled = true;

                    restartBossPoint += Controller.spriteIndex + 1;
                }

                if (Controller.spriteIndex < Controller.lastIndex)
                {
                    Controller.spriteIndex++;

                    restartBossPoint += Controller.spriteIndex;
                }
            }

            SceneManager.LoadScene("SampleScene");

            SaveGame.SaveTheGame();
        }
    }

    public void HitBoss()
    {
        TakeDamage(SaveGame.controllerCounterMultiplier);
    }

    IEnumerator EverySecondHitDamage()
    {
        while (canHit)
        {
            yield return new WaitForSeconds(0.5f);
            TakeDamage(SaveGame.controllerEverySecondGetPoint);
        }
    }

    public void GiveUpButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ContinueButtonClick()
    {
        if (bossPoint >= 10)
        {
            bossPoint -= 10;

            currentTime = 4;
            youDiedPanel.SetActive(false);
            canHit = true;
            StartCoroutine(EverySecondHitDamage());

            continueButton.interactable = false;
            giveUpButton.SetActive(true);
        }
        else
        {
            Debug.Log("Yeterli BP yok.");

            SceneManager.LoadScene("SampleScene");
        }
    }
}
