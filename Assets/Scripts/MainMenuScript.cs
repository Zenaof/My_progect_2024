using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    private Button SinglePlayBut;
    private Button MultiPlayBut;
    private Button SettingsBut;
    private Button ExitBut;

    private void Awake()
    {
        SinglePlayBut = GetComponent<Button>();
        MultiPlayBut = GetComponent<Button>();
        SettingsBut = GetComponent<Button>();
        ExitBut = GetComponent<Button>();
    }
    
   public void goSinglePlay()
    {
        
    }

    public void goMultiPlay()
    {
        
    }

    public void openSettings()
    {
        
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
