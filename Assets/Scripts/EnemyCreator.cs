using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public abstract class EnemyCreator
{
    public string Name{get; set;}

    public EnemyCreator(string name)
    {
        Name = name;
    }

    public abstract Enemy createEnemy(int stage);
}

public class MobCreator: EnemyCreator
{
    public MobCreator(string name): base(name){}

    public override Enemy createEnemy(int stage)
    {
        return new Mob(stage, Name);
    }
}

public class BossCreator: EnemyCreator
{
    public BossCreator(string name): base(name){}

    public override Enemy createEnemy(int stage)
    {
        return new Boss(stage, Name);
    }
}