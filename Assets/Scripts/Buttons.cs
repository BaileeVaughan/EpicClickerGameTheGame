using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [Header("Main Button")]
    public Button mainButton;
    public int baseCV = 1; //base click value
    public float curValue = 0;
    [Header("Upgrade Buttons")]
    public Button upgradeOne;
    public Button upgradeTwo;
    public int upgradeValue;
    public int buttonOneCost;
    public float buttonTwoCost;
    public bool canUpgrade;
    [Header("Text")]
    public Text curValueText;
    public Text clickValueText;
    public Text upgradeOneText;
    public Text upgradeTwoText;

    void Start()
    {
        curValue = 0;
        baseCV = 1;
        curValueText.text = "0" + " clicks";
        clickValueText.text = "0" + " per click";
        buttonOneCost = 30;
        buttonTwoCost = 50;
    }

    private void Update()
    {
        curValueText.text = curValue.ToString() + " clicks";
        clickValueText.text = baseCV.ToString() + " per click";
        upgradeValue = baseCV;
        buttonOneCost = upgradeValue * 2;
        buttonTwoCost = upgradeValue * 3;        
        if (curValue < buttonOneCost)
        {
            upgradeOneText.text = buttonOneCost.ToString() + " to unlock";
        }
        else
        {
            upgradeOneText.text = " + 1";
        }
        if (curValue < buttonTwoCost)
        {
            upgradeTwoText.text = buttonTwoCost.ToString() + " to unlock";
        }
        else
        {
            upgradeTwoText.text = " + 5";
        }
    }

    public void MainButtonDown()
    {
        if (mainButton)
        {
            curValue += baseCV;
        }
    }

    public void UpgradeButtonOne()
    {
        if (curValue >= buttonOneCost)
        {
            if (upgradeOne)
            {
                baseCV += 1;
            }
        }
    }

    public void UpgradeButtonTwo()
    {
        if (curValue >= buttonTwoCost)
        {
            if (upgradeTwo)
            {
                baseCV += 5;
            }
        }
    }
}
