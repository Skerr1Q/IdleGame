using System;
using System.Collections;
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
	private int _Cost;
	public int Cost{get{return _Cost*Level;} set{_Cost = value;}}

	private int _Damage;
	public int Damage{get{return _Damage*Level;} set{_Damage = value;}}

	public int Level{get; set;}


	public ClickUpgrade(int baseDamage, int baseCost)
    {
		_Damage = baseDamage;
		_Cost = baseCost;
		Level = 1;
	}

	public void addLevel()
	{
		Level += 1;
	}

}

public class HeroUpgrade : IUpgrade
{
	public string Name{get;}

	private int _Cost;
	public int Cost{get{return _Cost*(Level+1);} set{_Cost = value;}}

	private float _DPS;
	public float DPS{get{return _DPS*(float)Level;} set{_DPS = value;}}

	public int Level{get; set;}

	public HeroUpgrade(string heroName, float baseDps, int baseCost)
    {
		Name = heroName;
		DPS = baseDps;
		Cost = baseCost;
		Level = 0;

	}
	public void addLevel()
	{
		Level += 1;
	}
}