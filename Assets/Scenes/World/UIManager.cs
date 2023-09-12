using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text xpText;
    [SerializeField] private Text levelText;
    [SerializeField] private GameObject menu;

    private void Awake()
    {
        Assert.IsNotNull(xpText);
        Assert.IsNotNull(levelText);
        Assert.IsNotNull(menu);
    }

    public void UpdateLevel()
    {
        levelText.text = GameManager.Instance.CurrentPlayer.Lvl.ToString();
    }

    public void UpdateXP()
    {
        xpText.text = GameManager.Instance.CurrentPlayer.Xp + " / " + GameManager.Instance.CurrentPlayer.RequiredXp;
    }


    public void ToggleMenu()
    {
        menu.SetActive(!menu.activeSelf);
    }

    public void ToogleReturn()
    {
        menu.SetActive(!menu.activeSelf);
    }

    public void ToogleExit() 
    {
        Application.Quit();
    }

    private void Update()
    {
        UpdateLevel();
        UpdateXP();
    }
}
