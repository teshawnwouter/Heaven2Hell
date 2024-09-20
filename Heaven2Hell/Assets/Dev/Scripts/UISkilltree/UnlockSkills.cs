using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnlockSkills 
{


    public event EventHandler<OnSkillUnluckEventArges> onSkillUnlock;
    public class OnSkillUnluckEventArges : EventArgs
    {
        public Skills SkillType;
    }
    public enum Skills
    {
        None,
        attack,
        defence,
        iceBlast,
        fireBall,
        crit,
        frostShield
    }
    public List<Skills> M_Skills;

    public UnlockSkills()
    {
        M_Skills = new List<Skills>();
    }
    
    private void UnlockSkill(Skills skill)
    {
        if (!IsUnlocked(skill))
        {
            M_Skills.Add(skill);
            onSkillUnlock?.Invoke(this, new OnSkillUnluckEventArges{ SkillType = skill});
        }
        
    }

    public bool IsUnlocked(Skills skills)
    {
        return M_Skills.Contains(skills);
    }

    public Skills GetSkillRequirements(Skills skills)
    {
        switch (skills)
        {
            case Skills.crit: return Skills.attack;
            case Skills.fireBall: return Skills.crit;
            case Skills.iceBlast: return Skills.fireBall;
            case Skills.defence: return Skills.iceBlast;
            case Skills.frostShield: return Skills.defence;
        }
        return Skills.None;
    }


    public bool CanUnlock(Skills skills)
    {
        Skills SkillRequirements = GetSkillRequirements(skills);
        if (SkillRequirements != Skills.None)
        {
            if (IsUnlocked(SkillRequirements))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        else
        {
            return true;
        }
    }

    public bool TryToUnlock(Skills skills)
    {
        if (CanUnlock(skills))
        {
            UnlockSkill(skills);
            return true;
        }
        else
        {
            return false;
        }
    }
}
