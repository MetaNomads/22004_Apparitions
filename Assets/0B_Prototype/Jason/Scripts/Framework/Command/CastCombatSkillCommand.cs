using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

public class CastCombatSkillCommand : AbstractCommand
{
    private CombatSkillModel combatSkillModel;
    protected override void OnExecute()
    {
        combatSkillModel = this.GetModel<CombatSkillModel>();
        combatSkillModel.combatSkillList[combatSkillModel.currentSkillIndex].OnCast();
    }
    

    
}
