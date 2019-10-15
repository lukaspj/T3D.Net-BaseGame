using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;

namespace T3DNetFramework.Generated.Classes.Sim {    
    public unsafe class TriggerData : GameBaseData {
        public TriggerData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public TriggerData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public TriggerData(string pName) 
            : this(pName, false) {
        }
        
        public TriggerData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public TriggerData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public TriggerData(SimObject pObj) 
            : base(pObj) {
        }
        
        public TriggerData(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnLeaveTrigger__Args
            {
                internal IntPtr trigger;
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnLeaveTrigger(IntPtr _this, OnLeaveTrigger__Args args);
            private static _OnLeaveTrigger _OnLeaveTriggerFunc;
            internal static _OnLeaveTrigger OnLeaveTrigger() {
                if (_OnLeaveTriggerFunc == null) {
                    _OnLeaveTriggerFunc =
                        (_OnLeaveTrigger)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbTriggerData_onLeaveTrigger"), typeof(_OnLeaveTrigger));
                }
                
                return _OnLeaveTriggerFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnTickTrigger__Args
            {
                internal IntPtr trigger;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnTickTrigger(IntPtr _this, OnTickTrigger__Args args);
            private static _OnTickTrigger _OnTickTriggerFunc;
            internal static _OnTickTrigger OnTickTrigger() {
                if (_OnTickTriggerFunc == null) {
                    _OnTickTriggerFunc =
                        (_OnTickTrigger)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbTriggerData_onTickTrigger"), typeof(_OnTickTrigger));
                }
                
                return _OnTickTriggerFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnEnterTrigger__Args
            {
                internal IntPtr trigger;
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnEnterTrigger(IntPtr _this, OnEnterTrigger__Args args);
            private static _OnEnterTrigger _OnEnterTriggerFunc;
            internal static _OnEnterTrigger OnEnterTrigger() {
                if (_OnEnterTriggerFunc == null) {
                    _OnEnterTriggerFunc =
                        (_OnEnterTrigger)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbTriggerData_onEnterTrigger"), typeof(_OnEnterTrigger));
                }
                
                return _OnEnterTriggerFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
                if (_StaticGetTypeFunc == null) {
                    _StaticGetTypeFunc =
                        (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTriggerData_staticGetType"), typeof(_StaticGetType));
                }
                
                return _StaticGetTypeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Create__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _Create(Create__Args args);
            private static _Create _CreateFunc;
            internal static _Create Create() {
                if (_CreateFunc == null) {
                    _CreateFunc =
                        (_Create)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTriggerData_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void OnLeaveTrigger(Trigger trigger, GameBase obj) {
             InternalUnsafeMethods.OnLeaveTrigger__Args _args = new InternalUnsafeMethods.OnLeaveTrigger__Args() {
                trigger = trigger.ObjectPtr,
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnLeaveTrigger()(ObjectPtr, _args);
        }

        public void OnTickTrigger(Trigger trigger) {
             InternalUnsafeMethods.OnTickTrigger__Args _args = new InternalUnsafeMethods.OnTickTrigger__Args() {
                trigger = trigger.ObjectPtr,
             };
             InternalUnsafeMethods.OnTickTrigger()(ObjectPtr, _args);
        }

        public void OnEnterTrigger(Trigger trigger, GameBase obj) {
             InternalUnsafeMethods.OnEnterTrigger__Args _args = new InternalUnsafeMethods.OnEnterTrigger__Args() {
                trigger = trigger.ObjectPtr,
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnEnterTrigger()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public int TickPeriodMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("tickPeriodMS"));
            set => SetFieldValue("tickPeriodMS", GenericMarshal.ToString(value));
        }

        public bool ClientSide {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("clientSide"));
            set => SetFieldValue("clientSide", GenericMarshal.ToString(value));
        }
    }
}