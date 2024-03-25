using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public int Health;
    public int Exp;
    
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI ExpText;

    private void Awake()
    {
        Instance = this;
    }

    /// <summary>
    /// increasing hero's health
    /// </summary>
    /// <param name="value"></param>
    public void IncreaseHealth(int value)
    {
        Health += value;
        HealthText.text = $"HP:{Health}";
    }
    
    /// <summary>
    /// increasing hero's exp
    /// </summary>
    /// <param name="value"></param>
    public void IncreaseExp(int value)
    {
        Exp += value;
        ExpText.text = $"EXP:{Exp}";
    }
}
