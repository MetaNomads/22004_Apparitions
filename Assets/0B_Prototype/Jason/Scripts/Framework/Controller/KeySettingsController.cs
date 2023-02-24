using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;
using UnityEngine.Events;



public class KeySettingsController : DetachedWithinGameController //最好改成单例
{
    //inspector
    //等号赋值的是默认值，可以修改
    public E_KeyCodeEventEnum r_Grip_PressedMappedEvent = E_KeyCodeEventEnum.CastSkill;
    public E_KeyCodeEventEnum TestPressedMappedEvent = E_KeyCodeEventEnum.Test;
    //more to add on
    
    private void Start()
    {
        this.RegisterEvent<R_Grip_PressedEvent>(e =>
        {
            this.SendCommand(new TriggerKeyCodeCommand<CastEvent>(r_Grip_PressedMappedEvent));
        });
        this.RegisterEvent<TestPressedEvent>(e =>
        {
            this.SendCommand(new TriggerKeyCodeCommand<TestEvent>(TestPressedMappedEvent));
        });
    }

}
