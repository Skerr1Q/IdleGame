/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class GameLoader : MonoBehaviour
{        
    public static bool Loaded = false;

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
        Game IdleGame = new Game();

        savedStage = Int32.Parse(PlayerPrefs.GetString("SavedStage"));
        IdleGame.Stage = savedStage;

        savedStageMax = Int32.Parse(PlayerPrefs.GetString("SavedStageMax"));
        IdleGame.StageMax = savedStageMax;

        savedCoins = Int32.Parse(PlayerPrefs.GetString("SavedCoins"));
        IdleGame.Coins = savedCoins;

        savedModifier = Single.Parse(PlayerPrefs.GetString("SavedModifier"));
        IdleGame.Modifier = savedModifier;

        savedClickDamage = Int32.Parse(PlayerPrefs.GetString("SavedClickDamage"));
        IdleGame.ClickUpgrade.Damage = savedClickDamage;

        savedClickCost = Int32.Parse(PlayerPrefs.GetString("SavedClickCost"));
        IdleGame.ClickUpgrade.Cost = savedClickCost;

        savedClickLevel = Int32.Parse(PlayerPrefs.GetString("SavedClickLevel"));
        IdleGame.ClickUpgrade.Level = savedClickLevel;

        savedJimmyDPS = Single.Parse(PlayerPrefs.GetString("SavedJimmyDPS"));
        IdleGame.JimmyUpgrade.DPS = savedJimmyDPS;

        savedJimmyCost = Int32.Parse(PlayerPrefs.GetString("SavedJimmyCost"));
        IdleGame.JimmyUpgrade.Cost = savedJimmyCost;

        savedJimmyLevel = Int32.Parse(PlayerPrefs.GetString("SavedJimmyLevel"));
        IdleGame.JimmyUpgrade.Level = savedJimmyLevel;

        savedSheenDPS = Single.Parse(PlayerPrefs.GetString("SavedSheenDPS"));
        IdleGame.SheenUpgrade.DPS = savedSheenDPS;

        savedSheenCost = Int32.Parse(PlayerPrefs.GetString("SavedSheenCost"));
        IdleGame.SheenUpgrade.Cost = savedSheenCost;

        savedSheenLevel = Int32.Parse(PlayerPrefs.GetString("SavedSheenLevel"));
        IdleGame.SheenUpgrade.Level = savedSheenLevel;

        savedCarlDPS = Single.Parse(PlayerPrefs.GetString("SavedCarlDPS"));
        IdleGame.CarlUpgrade.DPS = savedCarlDPS;

        savedCarlCost = Int32.Parse(PlayerPrefs.GetString("SavedCarlCost"));
        IdleGame.CarlUpgrade.Cost = savedCarlCost;

        savedCarlLevel = Int32.Parse(PlayerPrefs.GetString("SavedCarlLevel"));
        IdleGame.CarlUpgrade.Level = savedCarlLevel;

        return IdleGame;
    }

    public void Save(Game IdleGame)
    {
        PlayerPrefs.SetString("SavedStage", IdleGame.Stage.ToString());
        PlayerPrefs.SetString("SavedStageMax", IdleGame.StageMax.ToString());
        PlayerPrefs.SetString("SavedCoins", IdleGame.Coins.ToString());
        PlayerPrefs.SetString("SavedModifier", IdleGame.Modifier.ToString());

        PlayerPrefs.SetString("SavedClickDamage", IdleGame.ClickUpgrade.Damage.ToString());
        PlayerPrefs.SetString("SavedClickCost", IdleGame.ClickUpgrade.Cost.ToString());
        PlayerPrefs.SetString("SavedClickLevel", IdleGame.ClickUpgrade.Level.ToString());

        PlayerPrefs.SetString("SavedJimmyDPS", IdleGame.JimmyUpgrade.DPS.ToString());
        PlayerPrefs.SetString("SavedJimmyCost", IdleGame.JimmyUpgrade.Cost.ToString());
        PlayerPrefs.SetString("SavedJimmyLevel", IdleGame.JimmyUpgrade.Level.ToString());

        PlayerPrefs.SetString("SavedSheenDPS", IdleGame.SheenUpgrade.DPS.ToString());
        PlayerPrefs.SetString("SavedSheenCost", IdleGame.SheenUpgrade.Cost.ToString());
        PlayerPrefs.SetString("SavedSheenLevel", IdleGame.SheenUpgrade.Level.ToString());

        PlayerPrefs.SetString("SavedCarlDPS", IdleGame.CarlUpgrade.DPS.ToString());
        PlayerPrefs.SetString("SavedCarlCost", IdleGame.CarlUpgrade.Cost.ToString());
        PlayerPrefs.SetString("SavedCarlLevel", IdleGame.CarlUpgrade.Level.ToString());
        Loaded = true;
    }
}
*/