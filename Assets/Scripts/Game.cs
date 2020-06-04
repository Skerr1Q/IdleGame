using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Game
{
	public int Coins{get; set;}
	public int Stage{get; set;}
	public int StageMax{get; set;}
	public float Modifier{get; set;}

    public EnemyCreator MobEnemyCreator{get; set;}
    public EnemyCreator BossEnemyCreator{get; set;}
    public Enemy StageEnemy{get; set;}
    
    public HeroUpgrade JimmyUpgrade{get; set;}
    public HeroUpgrade CarlUpgrade{get; set;}
    public HeroUpgrade SheenUpgrade{get; set;}
    public ClickUpgrade ClickUpgrade{get; set;}

    public Game()
    {   
        Coins = 0;
        Stage = 1;       
        StageMax = 1;
        Modifier = 1.0f;

        ClickUpgrade = new ClickUpgrade(1, 5);
        JimmyUpgrade = new HeroUpgrade("Jimmy", 1.0f, 50);
        SheenUpgrade = new HeroUpgrade("Sheen", 5.0f, 100);
        CarlUpgrade = new HeroUpgrade("Carl", 30.0f, 200);

        MobEnemyCreator = new MobCreator("Libby");
        BossEnemyCreator = new BossCreator("Cindy");
        StageEnemy = spawnEnemy(Stage);
    }

    public float getDPS()
    {
        return Modifier*(JimmyUpgrade.DPS + SheenUpgrade.DPS + CarlUpgrade.DPS);
    }

    public void clickEnemy()
    {
        StageEnemy.HP -= ClickUpgrade.Damage;
        checkEnemy();
    }

    public void autoHitEnemy()
    {
        StageEnemy.HP -= (getDPS()/Screen.currentResolution.refreshRate);
        checkEnemy();
    }

    public void checkEnemy()
        {
        if (StageEnemy.HP <= 0)
            {
                if (StageEnemy is Mob)
                {
                    Coins += StageEnemy.Reward;
                }
                if (StageEnemy is Boss)
                {
                    Modifier += StageEnemy.Modifier;
                }

                Stage += 1;
                if (Stage > StageMax)
                {
                    StageMax = Stage;
                }
                StageEnemy = spawnEnemy(Stage);
            }
        }

    public Enemy spawnEnemy(int stage)
    {
        Enemy StageEnemy;
        if ( stage % 5 != 0 )
        {
            StageEnemy = MobEnemyCreator.createEnemy(stage);
		}
        else
        {
            StageEnemy = BossEnemyCreator.createEnemy(stage);                  
		}
        return StageEnemy;
    }
}

