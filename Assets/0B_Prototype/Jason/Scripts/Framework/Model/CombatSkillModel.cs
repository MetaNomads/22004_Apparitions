using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

public class CombatSkillModel : AbstractModel
{
    public List<Skill> combatSkillList;
    public int currentSkillIndex;
    
    
    public int skillLimit;
    protected override void OnInit()
    {
        combatSkillList  = new List<Skill>();
        currentSkillIndex = 0;
    }
}
