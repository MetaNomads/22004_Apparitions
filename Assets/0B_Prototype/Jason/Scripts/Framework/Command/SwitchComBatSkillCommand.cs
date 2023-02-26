using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

public class SwitchComBatSkillCommand : AbstractCommand
{
    private int indexSwitchTo;
    
    
    public SwitchComBatSkillCommand(int index)
    {
        indexSwitchTo = index;
    }
    protected override void OnExecute()
    {
        this.GetModel<CombatSkillModel>().currentSkillIndex = indexSwitchTo;
    }
}
