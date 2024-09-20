using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnlockSkills;

public class UISkilltree : MonoBehaviour
{

    [SerializeField] private UnlockSkills unlockSkill;
    [SerializeField] private CanUseSkill canUseSkill;

    [SerializeField] private GameObject atkUI;
    [SerializeField] private GameObject defUI;
    [SerializeField] private GameObject critUI;
    [SerializeField] private GameObject frostShieldUI;
    [SerializeField] private GameObject fireBallUI;
    [SerializeField] private GameObject iceBlastUI;


    List<GameObject> skillButtons = new List<GameObject>();

    private void Awake()
    {
        
    }
    public void SetPlayerSkills(UnlockSkills unlockSkills)
    {
        this.unlockSkill = unlockSkills;
        unlockSkills.onSkillUnlock += UnlockSkills_onSkillUnlock;
        UpdateVisuals();
    }

    private void UnlockSkills_onSkillUnlock(object sender, UnlockSkills.OnSkillUnluckEventArges e)
    {
        UpdateVisuals();
    }

    public void UnlockAttack()
    {
        if (!unlockSkill.TryToUnlock(UnlockSkills.Skills.attack))
        {
            Debug.Log("can't Unlock skill");
        }
        else
        {
            
            Debug.Log("unlocked Attack");
        }
    }
    public void UnlockDefence()
    {
        if (!unlockSkill.TryToUnlock(UnlockSkills.Skills.defence))
        {
            Debug.Log("can't Unlock skill");

        }
        else
        {
            Debug.Log("unlocked defence");
        }
    }
    public void UnlockCrit()
    {

        if (!unlockSkill.TryToUnlock(UnlockSkills.Skills.crit))
        {
            Debug.Log("can't Unlock skill");

        }
        else
        {
            Debug.Log("unlocked Crit");
        }
    }
   
    public void UnlockFireBall()
    {
        if (!unlockSkill.TryToUnlock(UnlockSkills.Skills.fireBall))
        {
            Debug.Log("can't Unlock skill");

        }
        else
        {
            Debug.Log("unlocked FireBall");
        }
    }
    public void UnlockIceBlast()
    {
        if (!unlockSkill.TryToUnlock(UnlockSkills.Skills.iceBlast))
        {
            Debug.Log("can't Unlock skill");

        }
        else
        {
            Debug.Log("unlocked iceBlast");
        }
    } public void UnlockFrostSHield()
    {
        if (!unlockSkill.TryToUnlock(UnlockSkills.Skills.frostShield))
        {
            Debug.Log("can't Unlock skill");

        }
        else
        {
            Debug.Log("unlocked iceBlast");
        }
    }

    private void UpdateVisuals()
    {



        if (unlockSkill.IsUnlocked(UnlockSkills.Skills.attack))
        {
            critUI.SetActive(true);
           
        }
        else
        {
            if (unlockSkill.IsUnlocked(UnlockSkills.Skills.crit))
            {
                
                critUI.SetActive(true);
            }
           
        }   


            if (unlockSkill.IsUnlocked(UnlockSkills.Skills.fireBall))
            {
                fireBallUI.SetActive(true);
            }
            else
            {
                if (unlockSkill.CanUnlock(UnlockSkills.Skills.fireBall))
                {
                    fireBallUI.SetActive(true);
                }
               
            }




            if (unlockSkill.IsUnlocked(UnlockSkills.Skills.iceBlast))
            {
                iceBlastUI.SetActive(true);
            }
            else
            {
                if (unlockSkill.CanUnlock(UnlockSkills.Skills.iceBlast))
                {
                    iceBlastUI.SetActive(true);
                }
            } 

            if (unlockSkill.IsUnlocked(UnlockSkills.Skills.defence))
            {
                defUI.SetActive(true);
            }
            else
            {
                if (unlockSkill.CanUnlock(UnlockSkills.Skills.defence))
                {
                    defUI.SetActive(true);
                }
            } 


            if (unlockSkill.IsUnlocked(UnlockSkills.Skills.frostShield))
            {
                frostShieldUI.SetActive(true);
            }
            else
            {
                if (unlockSkill.CanUnlock(UnlockSkills.Skills.frostShield))
                {
                    frostShieldUI.SetActive(true);
                }
            }
        
    }
}
