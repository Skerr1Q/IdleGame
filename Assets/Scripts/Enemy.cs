using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public abstract class Enemy
{
	public float HP{get; set;}
	public int HPMax{get; set;}
	public int Reward{get; set;}
	public abstract string Name{get; set;}
}

class Mob: Enemy
{
	public override string Name{get; set;} = "Earth Golem";

	public Mob(int stage){
		HPMax = 10 +  (stage * 2);
		HP = (float)HPMax;
		Reward = 4 + ((stage - 1) * 2);
	}
}

class Boss: Enemy
{
	public new float Reward{get; set;}
	public override string Name{get; set;} = "Wooden Golem";

	public Boss(int stage){
		HPMax = 10 +  (stage * 4);
		HP = (float)HPMax;
		Reward = 1.0f + (0.2f * ((float)(stage)/(5.0f)));
	}
}