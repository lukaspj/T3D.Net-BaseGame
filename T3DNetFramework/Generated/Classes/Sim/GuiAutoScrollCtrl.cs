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
    public unsafe class GuiAutoScrollCtrl : GuiTickCtrl {
        public GuiAutoScrollCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiAutoScrollCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiAutoScrollCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiAutoScrollCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiAutoScrollCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiAutoScrollCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiAutoScrollCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
                if (_ResetFunc == null) {
                    _ResetFunc =
                        (_Reset)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiAutoScrollCtrl_reset"), typeof(_Reset));
                }
                
                return _ResetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnReset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnReset(IntPtr _this, OnReset__Args args);
            private static _OnReset _OnResetFunc;
            internal static _OnReset OnReset() {
                if (_OnResetFunc == null) {
                    _OnResetFunc =
                        (_OnReset)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiAutoScrollCtrl_onReset"), typeof(_OnReset));
                }
                
                return _OnResetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnComplete__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnComplete(IntPtr _this, OnComplete__Args args);
            private static _OnComplete _OnCompleteFunc;
            internal static _OnComplete OnComplete() {
                if (_OnCompleteFunc == null) {
                    _OnCompleteFunc =
                        (_OnComplete)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiAutoScrollCtrl_onComplete"), typeof(_OnComplete));
                }
                
                return _OnCompleteFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnStart__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnStart(IntPtr _this, OnStart__Args args);
            private static _OnStart _OnStartFunc;
            internal static _OnStart OnStart() {
                if (_OnStartFunc == null) {
                    _OnStartFunc =
                        (_OnStart)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiAutoScrollCtrl_onStart"), typeof(_OnStart));
                }
                
                return _OnStartFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnTick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnTick(IntPtr _this, OnTick__Args args);
            private static _OnTick _OnTickFunc;
            internal static _OnTick OnTick() {
                if (_OnTickFunc == null) {
                    _OnTickFunc =
                        (_OnTick)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiAutoScrollCtrl_onTick"), typeof(_OnTick));
                }
                
                return _OnTickFunc;
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
                                "fnGuiAutoScrollCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiAutoScrollCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void Reset() {
             InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
             };
             InternalUnsafeMethods.Reset()(ObjectPtr, _args);
        }

        public virtual void OnReset() {
             InternalUnsafeMethods.OnReset__Args _args = new InternalUnsafeMethods.OnReset__Args() {
             };
             InternalUnsafeMethods.OnReset()(ObjectPtr, _args);
        }

        public virtual void OnComplete() {
             InternalUnsafeMethods.OnComplete__Args _args = new InternalUnsafeMethods.OnComplete__Args() {
             };
             InternalUnsafeMethods.OnComplete()(ObjectPtr, _args);
        }

        public virtual void OnStart() {
             InternalUnsafeMethods.OnStart__Args _args = new InternalUnsafeMethods.OnStart__Args() {
             };
             InternalUnsafeMethods.OnStart()(ObjectPtr, _args);
        }

        public virtual void OnTick() {
             InternalUnsafeMethods.OnTick__Args _args = new InternalUnsafeMethods.OnTick__Args() {
             };
             InternalUnsafeMethods.OnTick()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public GuiAutoScrollDirection ScrollDirection {
            get => GenericMarshal.StringTo<GuiAutoScrollDirection>(GetFieldValue("scrollDirection"));
            set => SetFieldValue("scrollDirection", GenericMarshal.ToString(value));
        }

        public float StartDelay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("startDelay"));
            set => SetFieldValue("startDelay", GenericMarshal.ToString(value));
        }

        public float ResetDelay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("resetDelay"));
            set => SetFieldValue("resetDelay", GenericMarshal.ToString(value));
        }

        public int ChildBorder {
            get => GenericMarshal.StringTo<int>(GetFieldValue("childBorder"));
            set => SetFieldValue("childBorder", GenericMarshal.ToString(value));
        }

        public float ScrollSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("scrollSpeed"));
            set => SetFieldValue("scrollSpeed", GenericMarshal.ToString(value));
        }

        public bool IsLooping {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isLooping"));
            set => SetFieldValue("isLooping", GenericMarshal.ToString(value));
        }

        public bool ScrollOutOfSight {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("scrollOutOfSight"));
            set => SetFieldValue("scrollOutOfSight", GenericMarshal.ToString(value));
        }
    }
}