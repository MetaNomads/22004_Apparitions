using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

public class TriggerKeyCodeCommand<T>: AbstractCommand where T : class, IKeyCodeEvent
{
    private E_KeyCodeEventEnum E_keyCodeEvent;
    public TriggerKeyCodeCommand(E_KeyCodeEventEnum keycodeEvent)
    {
        E_keyCodeEvent = keycodeEvent;
    }
    
    protected override void OnExecute()
    {
        var keyCodeEvent = this.GetModel<KeySettingsModel>().KeyCodeDict[E_keyCodeEvent];
        this.SendEvent(keyCodeEvent as T);
    }
}

