using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillListSO", menuName = "ScriptableObjects/SkillSO")]
public class SkillInfoListSO : ScriptableObject
{
    public List<SkillInfo> SkillList = new List<SkillInfo>();
}
