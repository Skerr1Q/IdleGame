using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehavior
{
	public int Coins{get; set;}
	public int Stage{get; set;}
	public int StageMax{get; set;}
	public  float Modifier{get; set;}

    public float Timer{get; set;}
    private int timerCap = 30;

    public Enemy StageEnemy{get; set;}
    
    public void start()
    {   
        ClickUpgrade ClickUpgrade = new ClickUpgrade(1, 5, 1);
        HeroUpgrade JimmyUpgrade = new HeroUpgrade("Jimmy", 1, 20, 1);
        HeroUpgrade SheenUpgrade = new HeroUpgrade("Sheen", 50, 100, 1);
        HeroUpgrade CarlUpgrade = new HeroUpgrade("Carl", 100, 500, 1);
    }

    public void update()
    {

    }

    public float getDPS(){
        return (JimmyUpgrade.DPS + SheenUpgrade.DPS + CarlUpgrade.DPS);
    }

    public void clickEnemy()
    {
        StageEnemy.HP -= ClickUpgrade.Damage;
        checkEnemy();
    }

    public void autoHitEnemy()
    {
        StageEnemy.HP -= getDPS();
        checkEnemy();
    }

    public void checkEnemy()
        {
            {
                if (StageEnemy.GetType() == Boss)
                    {
                        timerTextbox.gameObject.SetActive(true);
                        Timer -= Time.deltaTime;
                        timerText.GetComponent<Text>.text = Timer + " / " timerCap;
                    }
                    
                if (Timer <= 0)
                    {
                        StageEnemy.HP = StageEnemy.HPMax;
                    }

                if (StageEnemy.HP <= 0)
                    {
                        if (StageEnemy.GetType() == Mob)
                        {
                            Coins += StageEnemy.Reward;
                        }
                        if (StageEnemy.GetType() == Boss)
                        {
                            Modifier = StageEnemy.Reward;
                        }

                        Stage += 1;

                        Timer = (float)timerCap;
                        timerTextbox.gameObject.SetActive(false);

                        spawnEnemy(Stage);
                    }
            }
        }

    public void spawnEnemy(int stage)
    {
        if ( stage % 5 != 0 )
        {
            StageEnemy = new Mob(stage);
		}
        else
        {
            StageEnemy = new Boss(stage);                  
		}
    }


}

