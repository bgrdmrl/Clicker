using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public static Controller instance;

    public static int spriteIndex = 0;
    public static int lastIndex = 0;

    public Sprite cChosenSourceSprite;
    public Sprite[] bossImages;

    private void Awake()
    {
        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        lastIndex = bossImages.Length - 1;
    }

    public void SetBossImage(int index)
    {
        cChosenSourceSprite = bossImages[index];
    }

    public void GoToBossScreen()
    {
        SetBossImage(spriteIndex);

        SaveGame.SaveTheGame();
        SceneManager.LoadScene("Bosses");

        Boss.bossMaxHealth = 50000 + (350000.0f * spriteIndex);

        //Boss.bossMaxHealth = 10 + (2 * spriteIndex);   hile
    }
}
