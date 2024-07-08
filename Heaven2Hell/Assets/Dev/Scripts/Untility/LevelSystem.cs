using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public event EventHandler OnExperianceChanged;
    public event EventHandler OnLevelChanged;


    private int level;
    private int xPObtained;
    private int xPNeeded;
    

    public LevelSystem()
    {
        level = 0;
        xPObtained = 0;
        xPNeeded = 100;
    }


    public void GainExperience(int amountOfXp)
    {
        xPObtained += amountOfXp;
        while (xPObtained > xPNeeded)
        {
            level++;
            xPObtained -= xPNeeded;
            if (OnLevelChanged != null)
            {
                OnLevelChanged(this,EventArgs.Empty);
            }
        }
        if(OnExperianceChanged != null)
        {
            OnExperianceChanged(this,EventArgs.Empty);
        }
    }

    public int GetLevel()
    {
        return level;
    }
}
