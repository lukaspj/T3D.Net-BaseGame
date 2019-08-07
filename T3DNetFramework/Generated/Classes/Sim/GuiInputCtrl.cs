using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DSharpFramework.Engine;
using T3DSharpFramework.Engine.Util;
using T3DSharpFramework.Generated.Classes.Global;
using T3DSharpFramework.Generated.Classes.Reflection;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Classes.Sim.Net;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Enums.Reflection;
using T3DSharpFramework.Generated.Structs.Global;
using T3DSharpFramework.Generated.Structs.Gui;
using T3DSharpFramework.Generated.Structs.Math;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Generated.Classes.Sim {    

    public unsafe class GuiInputCtrl : GuiMouseEventCtrl {



        public GuiInputCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiInputCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiInputCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiInputCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiInputCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiInputCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiInputCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnAxisEvent__Args
                {
				   
				   internal string device;
				   
				   internal string action;
				   
				   internal float axisValue;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnAxisEvent(IntPtr _this, string device, string action, float axisValue);
                internal delegate void _OnAxisEvent(IntPtr _this, OnAxisEvent__Args args);
                private static _OnAxisEvent _OnAxisEventFunc;
                internal static _OnAxisEvent OnAxisEvent() {
                    if (_OnAxisEventFunc == null) {
                        _OnAxisEventFunc =
                            (_OnAxisEvent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiInputCtrl_onAxisEvent"), typeof(_OnAxisEvent));
                    }
                    
                    return _OnAxisEventFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnInputEvent__Args
                {
				   
				   internal string device;
				   
				   internal string action;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnInputEvent(IntPtr _this, string device, string action, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _OnInputEvent(IntPtr _this, OnInputEvent__Args args);
                private static _OnInputEvent _OnInputEventFunc;
                internal static _OnInputEvent OnInputEvent() {
                    if (_OnInputEventFunc == null) {
                        _OnInputEventFunc =
                            (_OnInputEvent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiInputCtrl_onInputEvent"), typeof(_OnInputEvent));
                    }
                    
                    return _OnInputEventFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct StaticGetType__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _StaticGetType();
                internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
                private static _StaticGetType _StaticGetTypeFunc;
                internal static _StaticGetType StaticGetType() {
                    if (_StaticGetTypeFunc == null) {
                        _StaticGetTypeFunc =
                            (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiInputCtrl_staticGetType"), typeof(_StaticGetType));
                    }
                    
                    return _StaticGetTypeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Create__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _Create();
                internal delegate IntPtr _Create(Create__Args args);
                private static _Create _CreateFunc;
                internal static _Create Create() {
                    if (_CreateFunc == null) {
                        _CreateFunc =
                            (_Create)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiInputCtrl_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void OnAxisEvent(string device, string action, float axisValue) {
        
                                                                                    InternalUnsafeMethods.OnAxisEvent__Args _args = new InternalUnsafeMethods.OnAxisEvent__Args() {
                        device = device,
                        action = action,
                        axisValue = axisValue,
                     };
                     InternalUnsafeMethods.OnAxisEvent()(ObjectPtr, _args);
                                                                                                
                  }
	

			
                  public void OnInputEvent(string device, string action, bool state) {
        
                                                                                    InternalUnsafeMethods.OnInputEvent__Args _args = new InternalUnsafeMethods.OnInputEvent__Args() {
                        device = device,
                        action = action,
                        state = state,
                     };
                     InternalUnsafeMethods.OnInputEvent()(ObjectPtr, _args);
                                                                                                
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public bool SendAxisEvents {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("sendAxisEvents"));
            set => SetFieldValue("sendAxisEvents", GenericMarshal.ToString(value));
        }


        public bool SendBreakEvents {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("sendBreakEvents"));
            set => SetFieldValue("sendBreakEvents", GenericMarshal.ToString(value));
        }


        public bool SendModifierEvents {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("sendModifierEvents"));
            set => SetFieldValue("sendModifierEvents", GenericMarshal.ToString(value));
        }


    }
}