using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;

public class DetachedWithinArchitecture: Architecture<DetachedWithinArchitecture>
{
    protected override void Init()
    {
        //Model
        RegisterModel<AllSkillInfoModel>(new AllSkillInfoModel());
        RegisterModel<CombatSkillModel>(new CombatSkillModel());
        RegisterModel<KeySettingsModel>(new KeySettingsModel());
        
        
        //System
        RegisterSystem<IPlayerInputSystem>(new PlayerInputSystem());
        
        //Utility
        RegisterUtility<IStorage>(new PlayerPrefStorage());
        
    }
}

public class DetachedWithinGameController : MonoBehaviour, IController 
{ 
    IArchitecture IBelongToArchitecture.GetArchitecture() => DetachedWithinArchitecture.Interface;
}
// public class DetachedWithinUIController : BasePanel, IController 
// { 
//     IArchitecture IBelongToArchitecture.GetArchitecture()=>  DetachedWithinArchitecture.Interface;
// } 在实现UI管理器之后使用

