using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderMenuAnim : MonoBehaviour
{
    public GameObject PanelMenu, RestartPanelMenu, soldiersMenu, skillsMenu, bossesMenu;

    public void ShowMenu()
    {
        if (PanelMenu != null)
        {
            Animator animator = PanelMenu.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
            }
        }
    }

    public void OpenSoldiersMenu()
    {
        soldiersMenu.SetActive(true);
        bossesMenu.SetActive(false);
        skillsMenu.SetActive(false);
    }

    public void OpenSkillsMenu()
    {
        skillsMenu.SetActive(true);
        soldiersMenu.SetActive(false);
        bossesMenu.SetActive(false);
    }

    public void OpenBossesMenu()
    {
        bossesMenu.SetActive(true);
        soldiersMenu.SetActive(false);
        skillsMenu.SetActive(false);
    }

    public void ShowRestartMenu()
    {
        if (RestartPanelMenu != null)
        {
            Animator animator = RestartPanelMenu.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("showRestart");
                animator.SetBool("showRestart", !isOpen);
            }
        }
    }
}