using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSub : MonoBehaviour
{
    [SerializeField] PlayerBehavour player;

    private void Awake()
    {
        LevelSystem levelSystem = new LevelSystem();
        player.SetLevelSystem(levelSystem);
    }
}
