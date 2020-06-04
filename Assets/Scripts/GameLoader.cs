using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class GameLoader : MonoBehaviour
{        
    public Game IdleGame{get; set;}

    public static bool Loaded = false;

    public GameLoader(Game idleGame)
    {
        IdleGame = idleGame;
    }

    public int savedStage;
    public int savedStageMax;
    public int savedCoins;
    public float savedModifier;
    public int savedClickDamage;
    public int savedClickCost;
    public int savedClickLevel;
    public float savedJimmyDPS;
    public int savedJimmyCost;
    public int savedJimmyLevel;
    public float savedSheenDPS;
    public int savedSheenCost;
    public int savedSheenLevel;
    public float savedCarlDPS;
    public int savedCarlCost;
    public int savedCarlLevel;

    public Game Load()
    {
        Game IdleGame;

        savedStage = PlayerPrefs.GetInt("SavedStage");
        IdleGame.Stage = savedStage;

        savedStageMax = PlayerPrefs.GetInt("SavedStageMax");
        IdleGame.StageMax = savedStageMax;

        savedCoins = PlayerPrefs.GetInt("SavedMoney");
        IdleGame.Coins = savedCoins;

        savedModifier = PlayerPrefs.GetFloat("SavedModifier");
        IdleGame.Modifier = savedModifier;

        savedClickDamage = PlayerPrefs.GetInt("SavedClickDamage");
        IdleGame.ClickUpgrade.Damage = savedClickDamage;

        savedClickCost = PlayerPrefs.GetInt("SavedClickCost");
        IdleGame.ClickUpgrade.Cost = savedClickCost;

        savedClickLevel = PlayerPrefs.GetInt("SavedClickLevel");
        IdleGame.ClickUpgrade.Level = savedClickLevel;

        savedJimmyDPS = PlayerPrefs.GetFloat("SavedJimmyDPS");
        IdleGame.JimmyUpgrade.DPS = savedJimmyDPS;

        savedJimmyCost = PlayerPrefs.GetInt("SavedJimmyCost");
        IdleGame.JimmyUpgrade.Cost = savedJimmyCost;

        savedJimmyLevel = PlayerPrefs.GetInt("SavedJimmyLevel");
        IdleGame.JimmyUpgrade.Level = savedJimmyLevel;

        savedSheenDPS = PlayerPrefs.GetFloat("SavedSheenDPS");
        IdleGame.SheenUpgrade.DPS = savedSheenDPS;

        savedSheenCost = PlayerPrefs.GetInt("SavedSheenCost");
        IdleGame.SheenUpgrade.Cost = savedSheenCost;

        savedSheenLevel = PlayerPrefs.GetInt("SavedSheenLevel");
        IdleGame.SheenUpgrade.Level = savedSheenLevel;

        savedCarlDPS = PlayerPrefs.GetFloat("SavedCarlDPS");
        IdleGame.CarlUpgrade.DPS = savedCarlDPS;

        savedCarlCost = PlayerPrefs.GetInt("SavedCarlCost");
        IdleGame.CarlUpgrade.Cost = savedCarlCost;

        savedCarlLevel = PlayerPrefs.GetInt("SavedCarlLevel");
        IdleGame.CarlUpgrade.Level = savedCarlLevel;

        return IdleGame;
    }

    public void Save()
    {
        PlayerPrefs.SetInt("SavedStage", IdleGame.Stage);
        PlayerPrefs.SetInt("SavedStage", IdleGame.StageMax);
        PlayerPrefs.SetInt("SavedMoney", IdleGame.Coins);
        PlayerPrefs.GetFloat("SavedModifier", IdleGame.Modifier);

        PlayerPrefs.SetInt("SavedClickDamage", IdleGame.ClickUpgrade.Damage);
        PlayerPrefs.SetInt("SavedClickCost", IdleGame.ClickUpgrade.Cost);
        PlayerPrefs.SetInt("SavedClickLevel", IdleGame.ClickUpgrade.Level);

        PlayerPrefs.SetFloat("SavedJimmyDPS", IdleGame.JimmyUpgrade.DPS);
        PlayerPrefs.SetInt("SavedJimmyCost", IdleGame.JimmyUpgrade.Cost);
        PlayerPrefs.SetInt("SavedJimmyLevel", IdleGame.JimmyUpgrade.Level);

        PlayerPrefs.SetFloat("SavedSheenDPS", IdleGame.SheenUpgrade.DPS);
        PlayerPrefs.SetInt("SavedSheenCost", IdleGame.SheenUpgrade.Cost);
        PlayerPrefs.SetInt("SavedSheenLevel", IdleGame.SheenUpgrade.Level);

        PlayerPrefs.SetFloat("SavedCarlDPS", IdleGame.CarlUpgrade.DPS);
        PlayerPrefs.SetInt("SavedCarlCost", IdleGame.CarlUpgrade.Cost);
        PlayerPrefs.SetInt("SavedCarlLevel", IdleGame.CarlUpgrade.Level);
        Loaded = true;

    }
}
