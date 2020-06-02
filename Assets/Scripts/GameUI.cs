using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class GameUI : MonoBehaviour
{
    public Game IdleGame = new Game();

    public Text coinsText;
    public Text dpsText;
    public Text stageText;
    public Text healthText;
    public Text timerText;

    public Text ClickText;
    public Text JimmyText;
    public Text SheenText;
    public Text CarlText;

    public float Timer{get; set;}
    private int timerCap = 30;
    
    Timer = (float)timerCap;

    coinsText.text = "Coins: " + IdleGame.Coins;
    stageText.text = "Stage: " + IdleGame.Stage;
    dpsText.text = "DPS: " + IdleGame.getDPS();
    healthText.text = "Health: " + IdleGame.StageEnemy.HP + " / " + IdleGame.StageEnemy.HPMax + "HP";
    ClickText.text = "Upgrade Clicks \n Level:" + IdleGame.ClickUpgrade.Level + "Cost: " + IdleGame.ClickUpgrade.Cost + "Damage: " + IdleGame.ClickUpgrade.Damage;
    JimmyText.text = "Upgrade Jimmy \n Level:" + IdleGame.JimmyUpgrade.Level + "Cost: " + IdleGame.JimmyUpgrade.Cost + "DPS: " + IdleGame.JimmyUpgrade.DPS;
    SheenText.text = "Upgrade Sheen \n Level:" + IdleGame.SheenUpgrade.Level + "Cost: " + IdleGame.SheenUpgrade.Cost + "DPS: " + IdleGame.SheenUpgrade.DPS;
    CarlText.text = "Upgrade Carl \n Level:" + IdleGame.CarlUpgrade.Level + "Cost: " + IdleGame.CarlUpgrade.Cost + "DPS: " + IdleGame.CarlUpgrade.DPS;
    timerText.text = Timer + " / " + timerCap;

    public void ClickUpgradeButtonClick()
    {
        IdleGame.Coins -= IdleGame.ClickUpgrade.Cost;
        IdleGame.ClickUpgrade.addLevel();
        ClickText.text = "Upgrade Clicks \n Level:" + IdleGame.ClickUpgrade.Level + "Cost: " + IdleGame.ClickUpgrade.Cost + "Damage: " + IdleGame.ClickUpgrade.Damage;
    }

    public void ClickUpgradeButtonJimmy()
    {
        IdleGame.Coins -= IdleGame.JimmyUpgrade.Cost;
        IdleGame.JimmyUpgrade.addLevel();
        JimmyText.text = "Upgrade Jimmy \n Level:" + IdleGame.JimmyUpgrade.Level + "Cost: " + IdleGame.JimmyUpgrade.Cost + "DPS: " + IdleGame.JimmyUpgrade.DPS;
    }

    public void ClickUpgradeButtonSheen()
    {
        IdleGame.Coins -= IdleGame.SheenUpgrade.Cost;
        IdleGame.SheenUpgrade.addLevel();
        SheenText.text = "Upgrade Sheen \n Level:" + IdleGame.SheenUpgrade.Level + "Cost: " + IdleGame.SheenUpgrade.Cost + "DPS: " + IdleGame.SheenUpgrade.DPS;
    }

    public void ClickUpgradeButtonCarl()
    {
        IdleGame.Coins -= IdleGame.CarlUpgrade.Cost;
        IdleGame.CarlUpgrade.addLevel();
        CarlText.text = "Upgrade Carl \n Level:" + IdleGame.CarlUpgrade.Level + "Cost: " + IdleGame.CarlUpgrade.Cost + "DPS: " + IdleGame.CarlUpgrade.DPS;
    }
    
    public void ClickEnemyButton()
    {
        IdleGame.clickEnemy();
        healthText.text = "Health: " + IdleGame.StageEnemy.HP + "/" + IdleGame.StageEnemy.HPMax + "HP";
    }

    public void enableTimer()
    {
        if (IdleGame.StageEnemy is Boss)
        {
            Timer -= Time.deltaTime;
            timerText.text = Timer + " / " + timerCap;
        }
                        
        if (Timer <= 0)
        {
            IdleGame.StageEnemy.HP = IdleGame.StageEnemy.HPMax;
            Timer = (float)timerCap;
        }
    }
}
