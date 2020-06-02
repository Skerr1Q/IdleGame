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
    public GameObject saveButton;
    public GameObject saveText;

    public void Save()
    {
        PlayerPrefs.SetInt("SavedStage", Game.Stage);
        PlayerPrefs.SetInt("SavedStage", Game.StageMax);
        PlayerPrefs.SetInt("SavedMoney", Game.Coins);

        PlayerPrefs.SetInt("SavedClickDamage", ClickUpgrade.Damage);
        PlayerPrefs.SetInt("SavedClickCost", ClickUpgrade.Cost);
        PlayerPrefs.SetInt("SavedClickLevel", ClickUpgrade.Level);

        PlayerPrefs.SetFloat("SavedJimmyDPC", JimmyUpgrade.DPC);
        PlayerPrefs.SetInt("SavedJimmyCost", JimmyUpgrade.Cost);
        PlayerPrefs.SetInt("SavedJimmyLevel", JimmyUpgrade.Level);

        PlayerPrefs.SetFloat("SavedSheenDPC", SheenUpgrade.DPC);
        PlayerPrefs.SetInt("SavedSheenCost", SheenUpgrade.Cost);
        PlayerPrefs.SetInt("SavedSheenLevel", SheenUpgrade.Level);

        PlayerPrefs.SetFloat("SavedCarlDPC", CarlUpgrade.DPC);
        PlayerPrefs.SetInt("SavedCarlCost", CarlUpgrade.Cost);
        PlayerPrefs.SetInt("SavedCarlLevel", CarlUpgrade.Level);

        
    }
}
