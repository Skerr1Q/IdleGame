/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class GameLoader : MonoBehaviour
{
    public int savedStage;
    public int savedStageMax;
    public int savedCoins;
    public int savedClickDamage;
    public int savedClickCost;
    public int savedClickLevel;
    public float savedJimmyDPC;
    public int savedJimmyCost;
    public int savedJimmyLevel;
    public float savedSheenDPC;
    public int savedSheenCost;
    public int savedSheenLevel;
    public float savedCarlDPC;
    public int savedCarlCost;
    public int savedCarlLevel;

    void Start()
    {
        if(Load.isLoading == true)
        {
            savedStage = PlayerPrefs.GetInt("SavedStage");
            Game.Stage = savedStage;

            savedStageMax = PlayerPrefs.GetInt("SavedStageMax");
            Game.StageMax = savedStageMax;

            savedCoins = PlayerPrefs.GetInt("SavedMoney");
            Game.Coins = savedCoins;

            savedClickDamage = PlayerPrefs.GetInt("SavedClickDamage");
            ClickUpgrade.Damage = savedClickDamage;

            savedClickCost = PlayerPrefs.GetInt("SavedClickCost");
            ClickUpgrade.Cost = savedClickCost;

            savedClickLevel = PlayerPrefs.GetInt("SavedClickLevel");
            ClickUpgrade.Level = savedClickLevel;

            savedJimmyDPC = PlayerPrefs.GetInt("SavedJimmyDPC");
            JimmyUpgrade.DPC = savedJimmyDPC;

            savedJimmyCost = PlayerPrefs.GetInt("SavedJimmyCost");
            JimmyUpgrade.Cost = savedJimmyCost;

            savedJimmyLevel = PlayerPrefs.GetInt("SavedJimmyLevel");
            JimmyUpgrade.Level = savedJimmyLevel;

            savedSheenDPC = PlayerPrefs.GetInt("SavedSheenDPC");
            SheenUpgrade.DPC = savedSheenDPC;

            savedSheenCost = PlayerPrefs.GetInt("SavedSheenCost");
            SheenUpgrade.Cost = savedSheenCost;

            savedSheenLevel = PlayerPrefs.GetInt("SavedSheenLevel");
            SheenUpgrade.Level = savedSheenLevel;

            savedCarlDPC = PlayerPrefs.GetInt("SavedCarlDPC");
            CarlUpgrade.DPC = savedCarlDPC;

            savedCarlCost = PlayerPrefs.GetInt("SavedCarlCost");
            CarlUpgrade.Cost = savedCarlCost;

            savedCarlLevel = PlayerPrefs.GetInt("SavedCarlLevel");
            CarlUpgrade.Level = savedCarlLevel;

        }
    }
}
*/