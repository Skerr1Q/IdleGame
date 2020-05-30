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
	public Coins{get; set;}
	public Stage{get; set;}
	public StageMax{get; set;}
	public Modifier{get; set;}

    public float timer;
    public int timerCap = 30;
;
/*
    public Text moneyText;
    public Text dpsText;
    public Text stageText;
    public Text killsText;
    public Text healthText;
    public Text timerText;

    public GameObject back;
    public GameObject forward;

    public Image healthBar;
    public Image timerBar;
*/
    public void start()
    {   
        ClickUpgrade ClickUpgrade = new ClickUpgrade(1, 5, 1);
        HeroUpgrade JimmyUpgrade = new HeroUpgrade("Jimmy", 1, 20, 1);
        HeroUpgrade SheenUpgrade = new HeroUpgrade("Sheen", 100, 1);
        HeroUpgrade CarlUpgrade = new HeroUpgrade("Carl", 500, 1);

        if (Stage%5 != 0){
            Mob StageEnemy = new Mob(Stage)
		}
        else{
            Boss StageEnemy = new Boss(Stage)
		}

    }

    public void update()
    {
        moneyText = "$" + money.ToString("F2");
        stageText.text = "Stage - " + stage;
        dpcText.text = dpc + "Damage per click";
        killsText.text = kills + "/" + killsMax + "kills";
        healthText.text = health + "/" + healthCap + "HP";

        healthBar.fillAmount = (float)(health / healthCap);

        if (stage > 1) back.gameObject.SetActive(true);
        else
            back.gameObject.SetActive(false);

        if (stage != stageMax) forward.gameObject.SetActive(true);
        else
            forward.gameObject.SetActive(false);
        IsBossCheker();

    }
     public void IsBossCheker()
    {
        if (stage % 5 == 0)
        {
            isBoss = 10;
            stageText.text = "(BOSS!) Stage - " + stage;
            timer -= Time.deltaTime;
            if( timer <= 0)
            {
                stage -= 1;
                health = healthCap;
            }

            timerText.text = timer + "/" + timerCap;
            timerBar.gameObject.SetActive(true);
            timerBar.fillmount = timer / timerCap;
        }
        else
        {
            isBoss = 1;
            stageText.text = "Stage - " + stage;
            timerText.text = "";
            timerBar.gameObject.SetActive(false);
        }
    }

    public void Hit()
    {
        health -= dpc;
        if (health <= 0)
        {
            money += System.Math.Ceiling(healthCap / 14);
            
            if (stage == stageMax)
            {
                kills += 1;
                if (kills >= killsMax)
                {
                    kills = 0;
                    stage += 1;
                    stageMax += 1;
                }
            }
            IsBossCheker();
            health = healthCap;
            if (isBoss == 10)
            {
                timer = timerCap;
                killsMax = 1;
            }
            killsMax = 10;
        }
    }

    public void backStage()
    {
        if (getStage() > 1) setStage(getStage - 1);
    }
    public void forwardStage()
    {
        if (getStage() != GetStageMax()) setStage(getStage + 1);
    }

}

