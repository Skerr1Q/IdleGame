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
	public string Name{get; set;}
	public abstract int Reward{get; set;}
	public abstract float Modifier{get; set;}
}

class Mob: Enemy
{
	public override int Reward{get; set;}
	public override float Modifier{get; set;} = 0.0f;

	public Mob(int stage, string name){
		HPMax = 10 +  (stage * 2);
		HP = (float)HPMax;
		Reward = 4 + ((stage - 1) * 2);
		Name = name;
	}
}

class Boss: Enemy
{
	public override int Reward{get; set;} = 0;
	public override float Modifier{get; set;}

	public Boss(int stage, string name){
		HPMax = 10 +  (stage * 6);
		HP = (float)HPMax;
		Name = name;
		Modifier = 0.2f;
	}
}