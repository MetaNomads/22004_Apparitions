using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_2: Skill
{
    public void Start()
    {
        skillID = 2;
        init();
    }
    public override void OnCast()
    {
        Debug.Log(this.skillInfo.skillName);
    }
}
