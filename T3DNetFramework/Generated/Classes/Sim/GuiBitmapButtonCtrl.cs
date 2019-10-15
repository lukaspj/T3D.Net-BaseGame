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
    public unsafe class GuiBitmapButtonCtrl : GuiButtonCtrl {
        public GuiBitmapButtonCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiBitmapButtonCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiBitmapButtonCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiBitmapButtonCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiBitmapButtonCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiBitmapButtonCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiBitmapButtonCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBitmap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string path;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBitmap(IntPtr _this, SetBitmap__Args args);
            private static _SetBitmap _SetBitmapFunc;
            internal static _SetBitmap SetBitmap() {
                if (_SetBitmapFunc == null) {
                    _SetBitmapFunc =
                        (_SetBitmap)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiBitmapButtonCtrl_setBitmap"), typeof(_SetBitmap));
                }
                
                return _SetBitmapFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnShiftClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnShiftClick(IntPtr _this, OnShiftClick__Args args);
            private static _OnShiftClick _OnShiftClickFunc;
            internal static _OnShiftClick OnShiftClick() {
                if (_OnShiftClickFunc == null) {
                    _OnShiftClickFunc =
                        (_OnShiftClick)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiBitmapButtonCtrl_onShiftClick"), typeof(_OnShiftClick));
                }
                
                return _OnShiftClickFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAltClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAltClick(IntPtr _this, OnAltClick__Args args);
            private static _OnAltClick _OnAltClickFunc;
            internal static _OnAltClick OnAltClick() {
                if (_OnAltClickFunc == null) {
                    _OnAltClickFunc =
                        (_OnAltClick)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiBitmapButtonCtrl_onAltClick"), typeof(_OnAltClick));
                }
                
                return _OnAltClickFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnCtrlClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnCtrlClick(IntPtr _this, OnCtrlClick__Args args);
            private static _OnCtrlClick _OnCtrlClickFunc;
            internal static _OnCtrlClick OnCtrlClick() {
                if (_OnCtrlClickFunc == null) {
                    _OnCtrlClickFunc =
                        (_OnCtrlClick)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiBitmapButtonCtrl_onCtrlClick"), typeof(_OnCtrlClick));
                }
                
                return _OnCtrlClickFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnDefaultClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnDefaultClick(IntPtr _this, OnDefaultClick__Args args);
            private static _OnDefaultClick _OnDefaultClickFunc;
            internal static _OnDefaultClick OnDefaultClick() {
                if (_OnDefaultClickFunc == null) {
                    _OnDefaultClickFunc =
                        (_OnDefaultClick)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiBitmapButtonCtrl_onDefaultClick"), typeof(_OnDefaultClick));
                }
                
                return _OnDefaultClickFunc;
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
                                "fnGuiBitmapButtonCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiBitmapButtonCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void SetBitmap(string path) {
             InternalUnsafeMethods.SetBitmap__Args _args = new InternalUnsafeMethods.SetBitmap__Args() {
                path = path,
             };
             InternalUnsafeMethods.SetBitmap()(ObjectPtr, _args);
        }

        public void OnShiftClick() {
             InternalUnsafeMethods.OnShiftClick__Args _args = new InternalUnsafeMethods.OnShiftClick__Args() {
             };
             InternalUnsafeMethods.OnShiftClick()(ObjectPtr, _args);
        }

        public void OnAltClick() {
             InternalUnsafeMethods.OnAltClick__Args _args = new InternalUnsafeMethods.OnAltClick__Args() {
             };
             InternalUnsafeMethods.OnAltClick()(ObjectPtr, _args);
        }

        public void OnCtrlClick() {
             InternalUnsafeMethods.OnCtrlClick__Args _args = new InternalUnsafeMethods.OnCtrlClick__Args() {
             };
             InternalUnsafeMethods.OnCtrlClick()(ObjectPtr, _args);
        }

        public void OnDefaultClick() {
             InternalUnsafeMethods.OnDefaultClick__Args _args = new InternalUnsafeMethods.OnDefaultClick__Args() {
             };
             InternalUnsafeMethods.OnDefaultClick()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string Bitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("bitmap"));
            set => SetFieldValue("bitmap", GenericMarshal.ToString(value));
        }

        public GuiBitmapMode BitmapMode {
            get => GenericMarshal.StringTo<GuiBitmapMode>(GetFieldValue("bitmapMode"));
            set => SetFieldValue("bitmapMode", GenericMarshal.ToString(value));
        }

        public bool AutoFitExtents {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoFitExtents"));
            set => SetFieldValue("autoFitExtents", GenericMarshal.ToString(value));
        }

        public bool UseModifiers {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useModifiers"));
            set => SetFieldValue("useModifiers", GenericMarshal.ToString(value));
        }

        public bool UseStates {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useStates"));
            set => SetFieldValue("useStates", GenericMarshal.ToString(value));
        }

        public bool Masked {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("masked"));
            set => SetFieldValue("masked", GenericMarshal.ToString(value));
        }
    }
}