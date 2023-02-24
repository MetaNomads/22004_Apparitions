using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;
using System;

public interface IKeyCodeEvent {}

public class CastEvent : IKeyCodeEvent {}

public class TestEvent:IKeyCodeEvent{}
//more to add on


public enum E_KeyCodeEventEnum
{
    CastSkill,
    Test,
    //more to add on
}

public class KeySettingsModel : AbstractModel
{
    public Dictionary<E_KeyCodeEventEnum, IKeyCodeEvent> KeyCodeDict;
    protected override void OnInit()
    {
        KeyCodeDict = new Dictionary<E_KeyCodeEventEnum, IKeyCodeEvent>()
        {
            {E_KeyCodeEventEnum.CastSkill, new CastEvent()},
            {E_KeyCodeEventEnum.Test, new TestEvent()}
            
            //more to add on
        };
    }
}
