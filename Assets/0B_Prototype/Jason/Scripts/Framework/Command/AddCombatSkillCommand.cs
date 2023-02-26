using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

public class AddCombatSkillCommand : AbstractCommand
{
    private int skillIDToAdd;
    public AddCombatSkillCommand(int skillIDToAdd)
    {
        this.skillIDToAdd = skillIDToAdd;
    }
    protected override void OnExecute()
    {
        //还需要判断是否超过技能数量上限
        this.GetModel<CombatSkillModel>().combatSkillList.Add(Resources.Load<Skill_0>("Skills/Skill_"+skillIDToAdd));
    }
}
