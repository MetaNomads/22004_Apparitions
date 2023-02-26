using System;
using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

public class CombatSkillController : DetachedWithinGameController
{
    //models
    private AllSkillInfoModel allSkillInfoModel;
    private CombatSkillModel combatSkillModel;
    
    //inspector
    public List<Skill> skillList;
    

    private void Start()
    {
        allSkillInfoModel = this.GetModel<AllSkillInfoModel>();
        combatSkillModel = this.GetModel<CombatSkillModel>();
        
        //link inspector and model
        skillList = combatSkillModel.combatSkillList;
        
        
        //events
        this.RegisterEvent<CastEvent>(e =>
        {
            this.SendCommand(new CastCombatSkillCommand());
        });
        
        // this.RegisterEvent<TestEvent>(e =>
        // {
        //     print("test success");
        // });
        
        this.SendCommand(new AddCombatSkillCommand(0));
    }

    private void Update()
    {
        
    }

    private void OnDestroy()
    {
        allSkillInfoModel = null;
    }
}
