using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Engine;
using Unity.Engine.UI;


public class SaveGame : MonoBehaviour
{
 
    public void SaveTheGame()
    {
        PlayerPrefs.SetInt("SavedStage", stageMax);
        PlayerPrefs.SetInt("SavedMoney", coins);
        PlayerPrefs.SetInt("SavedClick", click);
        PlayerPrefs.SetInt("SavedJimmyUpgrades", Jimmy);
        PlayerPrefs.SetInt("SavedSheenUpgrades", Sheen);
        PlayerPrefs.SetInt("SavedCarlUpgrades", Carl);
    }
}
