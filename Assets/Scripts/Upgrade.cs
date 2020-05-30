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

	public void addLevel();
	public int	getDamage();
	public int getLevel();
	public void setCost();
	public int getCost();

}

class ClickUpgrade : IUpgrade
{
	private float damage;
	private int level;
	private int cost;

	public ClickUpgrade(float clickDamage, int clickCost, int clickLevel)
    {
		damage = clickDamage;
		cost = clickCost;
		level = clickLevel;
	}


	public void addLevel();
	public int	getDamage();
	public int getLevel();
	public void setCost(int);
	public int getCost();

}

class HeroUpgrade : IUpgrade
{
	private string name;
	private float damage;
	private int cost;
	private int level;

	public HeroUpgrade(string heroName, float heroDamage, int heroCost, int heroLevel)
    {
		name = heroName;
		damage = heroDamage;
		cost = heroCost;
		level = heroLevel;

	}


	public string getName();
	public void setName(string);
	public void addLevel();
	public int getLevel();
	public float getDamage();
	public void setCost(int);
	public int getCost();

}