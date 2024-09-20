using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISkilltree : MonoBehaviour
{

    [SerializeField] private UnlockSkills unlockSkill;
    [SerializeField] private CanUseSkill canUseSkill;
    [SerializeField] private GameObject critUI;
    [SerializeField] private GameObject speedUI;
    [SerializeField] private GameObject fireBallUI;
    [SerializeField] private GameObject iceBlastUI;

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
        if (unlockSkill.IsUnlocked(UnlockSkills.Skills.crit))
        {
            critUI.SetActive(false);
        }
        else
        {
            if (unlockSkill.CanUnlock(UnlockSkills.Skills.crit))
            {
                Debug.Log("stop Test");
                critUI.SetActive(true);
            }
            else
            {
                Debug.Log("test");
                critUI.SetActive(false);
            }
        }


        if (unlockSkill.IsUnlocked(UnlockSkills.Skills.speed))
        {
            speedUI.SetActive(false);
        }
        else
        {
            if (unlockSkill.CanUnlock(UnlockSkills.Skills.speed))
            {
                Debug.Log("stop Test");
                speedUI.SetActive(true);
            }
            else
            {
                Debug.Log("test");
                speedUI.SetActive(false);
            }



            if (unlockSkill.IsUnlocked(UnlockSkills.Skills.fireBall))
            {
                fireBallUI.SetActive(false);
            }
            else
            {
                if (unlockSkill.CanUnlock(UnlockSkills.Skills.fireBall))
                {
                    Debug.Log("stop Test");
                    fireBallUI.SetActive(true);
                }
                else
                {
                    Debug.Log("test");
                    fireBallUI.SetActive(false);
                }
            }




            if (unlockSkill.IsUnlocked(UnlockSkills.Skills.iceBlast))
            {
                iceBlastUI.SetActive(false);
            }
            else
            {
                if (unlockSkill.CanUnlock(UnlockSkills.Skills.iceBlast))
                {
                    Debug.Log("stop Test");
                    iceBlastUI.SetActive(true);
                }
                else
                {
                    Debug.Log("test");
                    iceBlastUI.SetActive(false);
                }
            }
        }
    }
}
