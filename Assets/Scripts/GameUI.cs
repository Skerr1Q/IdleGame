using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class IdleGameUI : MonoBehaviour
{
    public Game IdleGame = new Game();

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

    public void Start()
    {
        moneyText.GetComponent<Text>.text = "Coins: " + Game.Coins;
        stageText.GetComponent<Text>.text = "Stage: " + Game.Stage;
        dpcText.GetComponent<Text>.text = "DPS: " + Game.getDPS();
        healthText.GetComponent<Text>.text = Game.StageEnemy.HP + "/" + Game.StageEnemy.HPMax + "HP";
    }

    public void Upgrade()
    {

    }

}
