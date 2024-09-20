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
    [SerializeField] private GameObject speedUI;
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

    private void Update()
    {
        
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
    public void UnlockSpeed()
    {
        if (!unlockSkill.TryToUnlock(UnlockSkills.Skills.speed))
        {
            Debug.Log("can't Unlock skill");

        }
        else
        {
            Debug.Log("unlocked Speed");
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
    }

    private void UpdateVisuals()
    {



        if (unlockSkill.IsUnlocked(UnlockSkills.Skills.attack))
        {
            critUI.SetActive(true);
            Debug.Log(unlockSkill.IsUnlocked(UnlockSkills.Skills.attack));
        }
        else
        {
            if (unlockSkill.IsUnlocked(UnlockSkills.Skills.crit))
            {
                
                critUI.SetActive(true);
            }
           
        }

        if (unlockSkill.IsUnlocked(UnlockSkills.Skills.speed))
        {
            speedUI.SetActive(true);
        }
        else
        {
            if (unlockSkill.CanUnlock(UnlockSkills.Skills.speed))
            {
                speedUI.SetActive(true);
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
        }
    }
}
