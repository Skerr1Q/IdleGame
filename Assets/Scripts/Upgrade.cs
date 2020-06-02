using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

interface IUpgrade
{
	int Cost{get; set;}
	int Level{get; set;}

	void addLevel();

}

public class ClickUpgrade : IUpgrade
{
	public int Cost{get; set;}
	public int Level{get; set;}
	public int Damage{get; set;}

	public ClickUpgrade(int clickDamage, int clickCost, int clickLevel)
    {
		Damage = clickDamage;
		Cost = clickCost;
		Level = clickLevel;
	}

	public void addLevel()
	{
		Level += 1;
		Damage *= 2;
		Cost *= 3; 
	}

}

public class HeroUpgrade : IUpgrade
{
	public string Name{get;}
	public float DPS{get; set;}
	public int Cost{get; set;}
	public int Level{get; set;}

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
		DPS *= 1.5f;
		Cost *= 3; 
	}


}