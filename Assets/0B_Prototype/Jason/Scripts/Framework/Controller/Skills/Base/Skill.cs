using System;
using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;


public class Skill: MonoBehaviour,ISkill,IController
{
    // [Header("Auto Initialized")]
    [HideInInspector]
    public int skillID;
    [HideInInspector]
    public SkillInfo skillInfo;


    private AllSkillInfoModel allSkillInfoModel;

    public void init()
    {
        allSkillInfoModel = this.GetModel<AllSkillInfoModel>();
        skillInfo = allSkillInfoModel.skillInfoList.SkillList.Find(i => i.skillID == skillID);
    }


    public virtual void OnCast()
    {
        //add cool down logic
    }
    IArchitecture IBelongToArchitecture.GetArchitecture() => DetachedWithinArchitecture.Interface;
}
