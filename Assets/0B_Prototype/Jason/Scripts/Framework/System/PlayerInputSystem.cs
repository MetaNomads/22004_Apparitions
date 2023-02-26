using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;
using UnityEngine.InputSystem;
using MetaFrame;

public struct R_Grip_PressedEvent {}
public struct TestPressedEvent {}


public interface IPlayerInputSystem : ISystem
{
    public void Enable();
    public void Disable();
}
public class PlayerInputSystem: 
    AbstractSystem,
    IPlayerInputSystem,
    MetaframeGameController.IMetaFrame_InputActions,
    MetaframeGameController.ITestKeyBoardActions
{
    private MetaframeGameController mControllers = new MetaframeGameController();
    
    //接口中方法
    protected override void OnInit()
    {
        mControllers.MetaFrame_Input.SetCallbacks(this);
        Enable();
        
        // mControllers.TestKeyBoard.SetCallbacks(this);
        // EnableTest();
    }
    
    //如果有多套方法，使用多个enable和disable
    public void Enable()
    {
        mControllers.MetaFrame_Input.Enable();
    }
    public void Disable()
    {
        mControllers.MetaFrame_Input.Disable();
    }

    
    public void EnableTest()
    {
        mControllers.TestKeyBoard.Enable();
    }
    public void DisableTest()
    {
        mControllers.TestKeyBoard.Disable();
    }



    #region All Player Input Actions
    public void OnR_Grip_Pressed(InputAction.CallbackContext context)
    {
        if(!context.performed) return;
        this.SendEvent<R_Grip_PressedEvent>();
    }

    public void OnR_Grip_Released(InputAction.CallbackContext context)
    {
    }

    public void OnR_Trigger_Touched(InputAction.CallbackContext context)
    {
        // if(context.performed) 
        //     Debug.Log("trigger touched");
    }

    public void OnR_Trigger_UnTouched(InputAction.CallbackContext context)
    {
        // if(context.performed) 
        //     Debug.Log("trigger untouched");
    }

    public void OnR_Trigger_Pressed(InputAction.CallbackContext context)
    {
        // if(context.performed) 
        //     Debug.Log("trigger pressed");
    }

    public void OnR_Trigger_Released(InputAction.CallbackContext context)
    {
        // if(context.performed) 
        //     Debug.Log("trigger released");
    }

    public void OnR_Thumbstick_Touched(InputAction.CallbackContext context)
    {

    }

    public void OnR_Thumbstick_UnTouched(InputAction.CallbackContext context)
    {

    }

    public void OnR_Thumbstick_Pressed(InputAction.CallbackContext context)
    {
        // if(context.performed) 
        //     Debug.Log("Thumbstick pressed");
    }

    public void OnR_Thumbstick_Released(InputAction.CallbackContext context)
    {

    }

    public void OnR_Primary_Touched(InputAction.CallbackContext context)
    {

    }

    public void OnR_Primary_UnTouched(InputAction.CallbackContext context)
    {

    }

    public void OnR_Primary_Pressed(InputAction.CallbackContext context)
    {

    }

    public void OnR_Primary_Released(InputAction.CallbackContext context)
    {

    }

    public void OnR_Secondary_Touched(InputAction.CallbackContext context)
    {

    }

    public void OnR_Secondary_UnTouched(InputAction.CallbackContext context)
    {

    }

    public void OnR_Secondary_Pressed(InputAction.CallbackContext context)
    {

    }

    public void OnR_Secondary_Released(InputAction.CallbackContext context)
    {

    }

    public void OnL_Grip_Pressed(InputAction.CallbackContext context)
    {

    }

    public void OnL_Grip_Released(InputAction.CallbackContext context)
    {

    }

    public void OnL_Trigger_Touched(InputAction.CallbackContext context)
    {

    }

    public void OnL_Trigger_UnTouched(InputAction.CallbackContext context)
    {

    }

    public void OnL_Trigger_Pressed(InputAction.CallbackContext context)
    {
        // if(context.performed) 
        //     Debug.Log(" left trigger pressed");
    }

    public void OnL_Trigger_Released(InputAction.CallbackContext context)
    {

    }

    public void OnL_Thumbstick_Touched(InputAction.CallbackContext context)
    {

    }

    public void OnL_Thumbstick_UnTouched(InputAction.CallbackContext context)
    {

    }

    public void OnL_Thumbstick_Pressed(InputAction.CallbackContext context)
    {

    }

    public void OnL_Thumbstick_Released(InputAction.CallbackContext context)
    {

    }

    public void OnL_Primary_Touched(InputAction.CallbackContext context)
    {

    }

    public void OnL_Primary_UnTouched(InputAction.CallbackContext context)
    {

    }

    public void OnL_Primary_Pressed(InputAction.CallbackContext context)
    {

    }

    public void OnL_Primary_Released(InputAction.CallbackContext context)
    {

    }

    public void OnL_Secondary_Touched(InputAction.CallbackContext context)
    {

    }

    public void OnL_Secondary_UnTouched(InputAction.CallbackContext context)
    {

    }

    public void OnL_Secondary_Pressed(InputAction.CallbackContext context)
    {

    }

    public void OnL_Secondary_Released(InputAction.CallbackContext context)
    {

    }
    #endregion

    
    
    
    #region TestKeyBoard
    
    public void OnSkill(InputAction.CallbackContext context)
    {
        if(context.performed)
            this.SendEvent<R_Grip_PressedEvent>();
    }

    public void OnDebug(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            this.SendEvent<TestPressedEvent>();
        }

    }
    
    #endregion
}
