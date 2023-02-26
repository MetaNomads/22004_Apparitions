using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEditor;
using UnityEngine;


public class AllSkillInfoModel : AbstractModel //Combat skill data
{
    public SkillInfoListSO skillInfoList;

    protected override void OnInit()
    {
        //dont change the file path!!!!!!!
        skillInfoList = AssetDatabase.LoadAssetAtPath<SkillInfoListSO>("Assets/0B_Prototype/Jason/ScriptableObjects/SkillInfoListSO.asset");
    }
}
