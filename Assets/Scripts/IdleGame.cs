using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class IdleGame : MonoBehavior
{
	public int Coins{get; set;}
	public int Stage{get; set;}
	public int StageMax{get; set;}
	public  float Modifier{get; set;}
    public float Timer { get; set; }
    protected int timerCap = 30;

    public Text coinsText;
    public GameObject coinsTextbox;

    public Text dpsText;
    public GameObject dpsTextbox;

    public Text stageText;
    public GameObject stageTextbox;

    public Text healthText;
    public GameObject healthTextbox;

    public Text timerText;
    public GameObject timerTextbox;

    public GameObject back;
    public GameObject forward;

    
    public void start()
    {   
        ClickUpgrade ClickUpgrade = new ClickUpgrade(1, 5, 1);
        HeroUpgrade JimmyUpgrade = new HeroUpgrade("Jimmy", 1, 20, 1);
        HeroUpgrade SheenUpgrade = new HeroUpgrade("Sheen", 50, 100, 1);
        HeroUpgrade CarlUpgrade = new HeroUpgrade("Carl", 100, 500, 1);

        if ( Stage % 5 != 0 )
        {
            Mob StageEnemy = new Mob(Stage);
		}
        else
        {
            Boss StageEnemy = new Boss(Stage);                  
		}

    }

    public void update()
    {
        moneyText.GetComponent<Text>.text = "Coins: " + Coins;
        stageText.GetComponent<Text>.text = "Stage: " + Stage;
        dpcText.GetComponent<Text>.text = "DPS: " + getDPS();
        healthText.GetComponent<Text>.text = StageEnemy.HP + "/" + StageEnemy.HPMax + "HP";
    }

    public float getDPS(){
        return (JimmyUpgrade.Damage + SheenUpgrade.Damage + CarlUpgrade.Damage);
    }

    public void HitEnemy(){
        StageEnemy.HP - ClickUpgrade.Damage;

    }

    public void AutoHitEnemy()
    {
        if (StageEnemy.GetType() == Boss)
            {
                timerTextbox.gameObject.SetActive(true);
                Timer -= Time.deltaTime;
                timerText.GetComponent<Text>.text = Timer + " / " timerCap;
            }

        StageEnemy.HP -= getDPS();

        if (Timer <= 0)
            {
                StageEnemy.HP = StageEnemy.HPMax;
            }

        if (StageEnemy.HP <= 0)
            {
                if (StageEnemy.GetType() == Mob)
                {
                    Coins += StageEnemy.getReward(Stage);
                }
                if (StageEnemy.GetType() == Boss)
                {
                    Modifier = StageEnemy.Reward;
                }

                Stage += 1;

                Timer = (float)timerCap;
            }

        }
    }

}