using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkilltreeConnections : MonoBehaviour
{

    [SerializeField] private CanUseSkill canUseSkill;
    [SerializeField] private UISkilltree UIskilltree;
    void Start()
    {
        UIskilltree.SetPlayerSkills(canUseSkill.NewSkill());
    }
}
