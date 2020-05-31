using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

abstract class Enemy: MonoBehavior
{
	public float HP{get; set;}
	public int HPMax{get;}
	public abstract int Reward{get;}

}

class Mob: Enemy
{
	public override int Reward{get; private set;}

	public Mob(int stage){
		HPMax = 10 +  (stage * 2);
		Reward = (4 + (int)((stage - 1) * 2));
	}
}

class Boss: Enemy
{
	public override int Reward{get; private set;}

	public Boss(int stage){
		HPMax = 10 +  (stage * 4);
		Reward = 1.0 + (0.2 * (stage/5));
	}
}