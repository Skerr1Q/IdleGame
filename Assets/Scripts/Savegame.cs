using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class SaveGame : MonoBehaviour
{
    public void Save()
    {
<<<<<<< HEAD
        PlayerPrefs.SetInt("SavedStage", stageMax);
        PlayerPrefs.SetInt("SavedMoney", coins);
        PlayerPrefs.SetInt("SavedClick", click);
        PlayerPrefs.SetFloat("SavedJimmyDPS", JimmyUpgrade.DPS);
        PlayerPrefs.SetFloat("SavedSheenDPS", SheenUpgrade.DPS);
        PlayerPrefs.SetFloat("SavedCarlDPS", CarlUpgrade.DPS);
=======
        PlayerPrefs.SetInt("SavedStage", StageMax);
        PlayerPrefs.SetInt("SavedMoney", Coins);

        PlayerPrefs.SetFloat("SavedClickDamage", ClickUpgrade.Damage);
        PlayerPrefs.SetInt("SavedClickCost", ClickUpgrade.Cost);
        PlayerPrefs.SetInt("SavedClickDamage", ClickUpgrade.Level);

        PlayerPrefs.SetFloat("SavedJimmyDPC", JimmyUpgrade.DPC);
        PlayerPrefs.SetInt("SavedJimmyCost", JimmyUpgrade.Cost);
        PlayerPrefs.SetInt("SavedJimmyLevel", JimmyUpgrade.Level);

        PlayerPrefs.SetFloat("SavedSheenUpgrades", SheenUpgrade.DPC);
        PlayerPrefs.SetInt("SavedSheenCost", SheenUpgrade.Cost);
        PlayerPrefs.SetInt("SavedSheenLevel", SheenUpgrade.Level);

        PlayerPrefs.SetFloat("SavedCarlUpgrades", CarlUpgrade.DPC);
        PlayerPrefs.SetInt("SavedCarlCost", CarlUpgrade.Cost);
        PlayerPrefs.SetInt("SavedCarlLevel", CarlUpgrade.Level);
>>>>>>> bae8bada46ecac123f8a52c1d767a7228942a2c4
    }
}