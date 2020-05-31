using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

interface IUpgrade : MonoBehavior
{
	private int Cost{get; set;}
	private int Level{get; private set;}

	public void addLevel();

}

class ClickUpgrade : IUpgrade
{
	private float Damage{get; set;}

	public ClickUpgrade(float clickDamage, int clickCost, int clickLevel)
    {
		Damage = clickDamage;
		Cost = clickCost;
		Level = clickLevel;
	}

	public void addLevel()
	{
		Level += 1;
	}

}

class HeroUpgrade : IUpgrade
{
	private string Name{get;}
	private float DPS{get; set;}


	public HeroUpgrade(string heroName, float heroDamage, int heroCost, int heroLevel)
    {
		Name = heroName;
		DPS = heroDamage;
		Cost = heroCost;
		Level = heroLevel;

	}

	public void addLevel()
	{
		Level += 1;
	}


}