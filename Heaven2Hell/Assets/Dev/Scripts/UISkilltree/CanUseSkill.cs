using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnlockSkills;

public class CanUseSkill : MonoBehaviour
{
    private UnlockSkills skilltree;



    public void Awake()
    {
        skilltree = new UnlockSkills();
        skilltree.onSkillUnlock += Skilltree_onSkillUnlock;
       
    }

    private void Skilltree_onSkillUnlock(object sender, OnSkillUnluckEventArges e)
    {
        switch (e.SkillType) 
        {
            case UnlockSkills.Skills.attack:
                CanUseAttackBuff();
                break;
            case UnlockSkills.Skills.defence:
                CanUseDefenseBuff();
                break;
            case UnlockSkills.Skills.speed:
                CanUseSpeedBuff();
                break;
            case UnlockSkills.Skills.crit:
                CanUseHeavyCritsBuff();
                break;
            case UnlockSkills.Skills.fireBall:
                CanUseFireBallBuff();
                break;
            case UnlockSkills.Skills.iceBlast:
                CanUseIceBlastBuff();
                break;

        }

    }

    public UnlockSkills NewSkill() 
    {
        return skilltree;
    }

    public bool CanUseMoveBuff()
    {
        return true;
    }

    public bool CanUseAttackBuff() { return skilltree.IsUnlocked(UnlockSkills.Skills.attack); }

    public bool CanUseDefenseBuff() { return skilltree.IsUnlocked(UnlockSkills.Skills.defence); }

    public bool CanUseSpeedBuff() { return skilltree.IsUnlocked(UnlockSkills.Skills.speed); }

    public bool CanUseFireBallBuff() { return skilltree.IsUnlocked(UnlockSkills.Skills.fireBall); }

    public bool CanUseIceBlastBuff() { return skilltree.IsUnlocked(UnlockSkills.Skills.iceBlast); }


    public bool CanUseHeavyCritsBuff() { return skilltree.IsUnlocked(UnlockSkills.Skills.crit); }
}
