using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{
    public static bool isLoading = false;
    public void LoadGame()
    {
        isLoading = true;
    }
}
