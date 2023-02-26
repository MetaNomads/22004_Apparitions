using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_1 : Skill
{
    [Header("Inspector")] 
    public int effectRadius;
    public void Start()
    {
        skillID = 1;
        init();
    }
    public override void OnCast()
    {
        Debug.Log(this.skillInfo.skillName);
    }
}
