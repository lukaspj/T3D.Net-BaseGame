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
    public unsafe class GuiFadeinBitmapCtrl : GuiBitmapCtrl {
        public GuiFadeinBitmapCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiFadeinBitmapCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiFadeinBitmapCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiFadeinBitmapCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiFadeinBitmapCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiFadeinBitmapCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiFadeinBitmapCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnDone__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnDone(IntPtr _this, OnDone__Args args);
            private static _OnDone _OnDoneFunc;
            internal static _OnDone OnDone() {
                if (_OnDoneFunc == null) {
                    _OnDoneFunc =
                        (_OnDone)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiFadeinBitmapCtrl_onDone"), typeof(_OnDone));
                }
                
                return _OnDoneFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Click__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Click(IntPtr _this, Click__Args args);
            private static _Click _ClickFunc;
            internal static _Click Click() {
                if (_ClickFunc == null) {
                    _ClickFunc =
                        (_Click)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiFadeinBitmapCtrl_click"), typeof(_Click));
                }
                
                return _ClickFunc;
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
                                "fnGuiFadeinBitmapCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiFadeinBitmapCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void OnDone() {
             InternalUnsafeMethods.OnDone__Args _args = new InternalUnsafeMethods.OnDone__Args() {
             };
             InternalUnsafeMethods.OnDone()(ObjectPtr, _args);
        }

        public void Click() {
             InternalUnsafeMethods.Click__Args _args = new InternalUnsafeMethods.Click__Args() {
             };
             InternalUnsafeMethods.Click()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public LinearColorF FadeColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("fadeColor"));
            set => SetFieldValue("fadeColor", GenericMarshal.ToString(value));
        }

        public int FadeInTime {
            get => GenericMarshal.StringTo<int>(GetFieldValue("fadeInTime"));
            set => SetFieldValue("fadeInTime", GenericMarshal.ToString(value));
        }

        public int WaitTime {
            get => GenericMarshal.StringTo<int>(GetFieldValue("waitTime"));
            set => SetFieldValue("waitTime", GenericMarshal.ToString(value));
        }

        public int FadeOutTime {
            get => GenericMarshal.StringTo<int>(GetFieldValue("fadeOutTime"));
            set => SetFieldValue("fadeOutTime", GenericMarshal.ToString(value));
        }

        public EaseF FadeInEase {
            get => GenericMarshal.StringTo<EaseF>(GetFieldValue("fadeInEase"));
            set => SetFieldValue("fadeInEase", GenericMarshal.ToString(value));
        }

        public EaseF FadeOutEase {
            get => GenericMarshal.StringTo<EaseF>(GetFieldValue("fadeOutEase"));
            set => SetFieldValue("fadeOutEase", GenericMarshal.ToString(value));
        }

        public bool Done {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("done"));
            set => SetFieldValue("done", GenericMarshal.ToString(value));
        }
    }
}