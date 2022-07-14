#region Access
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MMA;
#endregion
namespace MMA.Input
{
    public static class Key
    {
        // public const string _   = KeyData._;
        public static string Subscribe   = "Input_Subscribe"; // (bool, Action...... )
    }
    public static class Import
    {
        //public const string _ = _;
    }
    public sealed partial class Input_Module : Module
    {
        #region References
        //[Header("Applications")]
        //[SerializeField] public ApplicationBase interface_Input;
        #endregion
        #region Reactions ( On___ )
        // Contenedor de toda las reacciones del Input
        protected override void OnSubscription(bool condition)
        {
            //
        }
        #endregion
        #region Methods
        // Contenedor de toda la logica del Input
        #endregion
        #region Request ( Coroutines )
        // Contenedor de toda la Esperas de corutinas del Input
        #endregion
        #region Task ( async )
        // Contenedor de toda la Esperas asincronas del Input
        #endregion
    }
}

//using System;
//using UnityEngine;
//using UnityEngine.Events;
//[Serializable]
//public class CommandsController
//{
//    [Serializable]
//    private enum PressType
//    {
//        PressDown,
//        Press,
//        PressUp
//    }
//    [SerializeField]
//    private enum Execution
//    {
//        Update,
//        FixedUpdate
//    }
//    [Serializable]
//    private struct Command
//    {
//        [SerializeField] private string displayName;
//        [SerializeField] private KeyCode key;
//        [SerializeField] private PressType pressType;
//        [SerializeField] private Execution execution;
//        [SerializeField] private UnityEvent callback;

//        public void Check(Execution _executionCheck)
//        {
//            if (!_executionCheck.Equals(execution)) return;

//            bool result = false;
//            switch (pressType)
//            {
//                case PressType.PressDown:
//                    result = Input.GetKeyDown(key);
//                    break;
//                case PressType.Press:
//                    result = Input.GetKey(key);
//                    break;
//                case PressType.PressUp:
//                    result = Input.GetKeyUp(key);
//                    break;
//            }
//            if (result) callback.Invoke();
//        }
//    }
//    #region Variables
//    [SerializeField] private Command[] commands;
//    #endregion
//    #region Method
//    public void CheckUpdate() => Checker(Execution.Update);
//    public void CheckFixedUpdate() => Checker(Execution.FixedUpdate);
//    private void Checker(Execution execution)
//    {
//        int lenght = commands.Length;
//        for (int i = 0; i < lenght; i++) commands[i].Check(execution);
//    }
//    #endregion
//}
