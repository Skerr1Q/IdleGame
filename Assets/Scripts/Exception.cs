using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

class Exception
{
    static void Process(int stage, int stageMax)
    {
        if(stage > stageMax)
        {
            throw new ArgumentOutOfRangeException();
        }
    }
    static void Main()
    {
        try
        {
            Process(Stage, StageMax);
        }
        catch(ArgumentOutOfRangeException e )
        {
            Console.WriteLine(e);
        }
    }

}