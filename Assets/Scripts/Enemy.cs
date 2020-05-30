using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

abstract class Enemy
{
	public float HP{get;}
	public int HPMax{get;}
	public int reward;

	abstract public float getReward;
}

class Mob: Enemy
{

	public Mob(int stage)  : base(){
		HPMax = 10 +  (stage * 2);
	}

	public override int getReward(int stage){
		return (4 + (int)((stage - 1) * 2));
	}
}

class Boss: Enemy
{

	public Boss(int stage)  : base(){
		HPMax = 10 +  (stage * 4);
	}
	public override float getReward(){
		return 1.0 + (0.2 * (stage/5));
	}
}