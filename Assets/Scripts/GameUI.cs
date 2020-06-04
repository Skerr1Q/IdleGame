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
    public Game IdleGame{get; set;}
    //public static GameLoader IdleGameLoader = new GameLoader();

    public GameObject enemyButton;
    public Sprite LibbyImage;
    public Sprite CindyImage;

    public Text coinsText;
    public Text dpsText;
    public Text stageText;
    public Text healthText;
    public Text timerText;
    public Text nameText;
    public Text modifierText;

    public Text ClickText;
    public Text JimmyText;
    public Text SheenText;
    public Text CarlText;

    public GameObject backButton;
    public GameObject forwardButton;

    public int TimerCap{get; set;}
    public float Timer{get; set;}

    public void Start()
    {

        //if (GameLoader.Loaded == false)
        //{
            IdleGame = new Game();
        //}
        //else
        //{
        //    LoadGame();
        //}

        changeText();
        TimerCap = 30;
        Timer = (float)TimerCap;
    }

    public void Update()
    {
        if (IdleGame.StageEnemy is Boss)
        {
            enableTimer();
        }
        else
        {
            Timer = (float)TimerCap;
        }
        changeText();
        changeImage();
        IdleGame.autoHitEnemy();
        //SaveGame();
    }

    public void changeText()
    {
        coinsText.text = "Coins: " + IdleGame.Coins;
        stageText.text = "Stage: " + IdleGame.Stage;
        dpsText.text = "DPS: " + IdleGame.getDPS().ToString("F2");
        nameText.text = IdleGame.StageEnemy.Name;
        modifierText.text = "Modifier: " + IdleGame.Modifier.ToString("F1");
        healthText.text = "Health: " + IdleGame.StageEnemy.HP.ToString("F2") + " / " + IdleGame.StageEnemy.HPMax + "HP";
        ClickText.text = "Upgrade Clicks\nLevel: " + IdleGame.ClickUpgrade.Level + "    Cost: " + IdleGame.ClickUpgrade.Cost + "    Damage: " + IdleGame.ClickUpgrade.Damage;
        JimmyText.text = "Upgrade Jimmy\nLevel: " + IdleGame.JimmyUpgrade.Level + "    Cost: " + IdleGame.JimmyUpgrade.Cost + "    DPS: " + IdleGame.JimmyUpgrade.DPS;
        SheenText.text = "Upgrade Sheen\nLevel: " + IdleGame.SheenUpgrade.Level + "    Cost: " + IdleGame.SheenUpgrade.Cost + "    DPS: " + IdleGame.SheenUpgrade.DPS;
        CarlText.text = "Upgrade Carl\nLevel: " + IdleGame.CarlUpgrade.Level + "    Cost: " + IdleGame.CarlUpgrade.Cost + "    DPS: " + IdleGame.CarlUpgrade.DPS;
        timerText.text = Timer.ToString("F2") + " / " + TimerCap;
    }

    public void changeImage()
    {
        if (IdleGame.StageEnemy is Mob)
        {
            enemyButton.GetComponent<Image>().sprite = LibbyImage;        
        }
        else if (IdleGame.StageEnemy is Boss)
        {
            enemyButton.GetComponent<Image>().sprite = CindyImage;
        }
    }

    public void ClickUpgradeButtonClick()
    {
        if (IdleGame.Coins >= IdleGame.ClickUpgrade.Cost)
        {
            IdleGame.Coins -= IdleGame.ClickUpgrade.Cost;
            IdleGame.ClickUpgrade.addLevel();
        }
    }

    public void ClickUpgradeButtonJimmy()
    {
        if (IdleGame.Coins >= IdleGame.JimmyUpgrade.Cost)
        {
            IdleGame.Coins -= IdleGame.JimmyUpgrade.Cost;
            IdleGame.JimmyUpgrade.addLevel();
        }
    }

    public void ClickUpgradeButtonSheen()
    {
        if (IdleGame.Coins >= IdleGame.SheenUpgrade.Cost)
        {
            IdleGame.Coins -= IdleGame.SheenUpgrade.Cost;
            IdleGame.SheenUpgrade.addLevel();
        }
    }

    public void ClickUpgradeButtonCarl()
    {
        if (IdleGame.Coins >= IdleGame.CarlUpgrade.Cost)
        {
            IdleGame.Coins -= IdleGame.CarlUpgrade.Cost;
            IdleGame.CarlUpgrade.addLevel();
        }
    }
    
    public void ClickEnemyButton()
    {
        IdleGame.clickEnemy();
    }

    public void enableTimer()
    {
        Timer -= Time.deltaTime;
                        
        if (Timer <= 0)
        {
            IdleGame.StageEnemy.HP = IdleGame.StageEnemy.HPMax;
            Timer = (float)TimerCap;
        }
    }

    public void forwardStage()
    {
        if (IdleGame.Stage == IdleGame.StageMax)
        {
            throw new StageNotFoundException("Cannot exceed maximum stage.");
        }
        else
        {
            IdleGame.Stage += 1;
            IdleGame.StageEnemy = IdleGame.spawnEnemy(IdleGame.Stage);
            Timer = (float)TimerCap;
        }

    }

    public void backStage()
    {
        if (IdleGame.Stage == 1)
        {
            throw new StageNotFoundException("There is no stage 0");
        }
        else
        {
            IdleGame.Stage -= 1;
            IdleGame.StageEnemy = IdleGame.spawnEnemy(IdleGame.Stage);
            Timer = (float)TimerCap;
        }
    }

//    public void SaveGame()
//    {
//        IdleGameLoader.Save(IdleGame);
//    }
//
//    public void LoadGame()
//    {
//        IdleGame = IdleGameLoader.Load();
//    }

}
