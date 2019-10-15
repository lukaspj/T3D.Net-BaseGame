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
    public unsafe class GuiFormCtrl : GuiPanel {
        public GuiFormCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiFormCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiFormCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiFormCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiFormCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiFormCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiFormCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCaption__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string caption;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCaption(IntPtr _this, SetCaption__Args args);
            private static _SetCaption _SetCaptionFunc;
            internal static _SetCaption SetCaption() {
                if (_SetCaptionFunc == null) {
                    _SetCaptionFunc =
                        (_SetCaption)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiFormCtrl_setCaption"), typeof(_SetCaption));
                }
                
                return _SetCaptionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMenuID__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMenuID(IntPtr _this, GetMenuID__Args args);
            private static _GetMenuID _GetMenuIDFunc;
            internal static _GetMenuID GetMenuID() {
                if (_GetMenuIDFunc == null) {
                    _GetMenuIDFunc =
                        (_GetMenuID)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiFormCtrl_getMenuID"), typeof(_GetMenuID));
                }
                
                return _GetMenuIDFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnResize__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnResize(IntPtr _this, OnResize__Args args);
            private static _OnResize _OnResizeFunc;
            internal static _OnResize OnResize() {
                if (_OnResizeFunc == null) {
                    _OnResizeFunc =
                        (_OnResize)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiFormCtrl_onResize"), typeof(_OnResize));
                }
                
                return _OnResizeFunc;
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
                                "fnGuiFormCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiFormCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void SetCaption(string caption) {
             InternalUnsafeMethods.SetCaption__Args _args = new InternalUnsafeMethods.SetCaption__Args() {
                caption = caption,
             };
             InternalUnsafeMethods.SetCaption()(ObjectPtr, _args);
        }

        public int GetMenuID() {
             InternalUnsafeMethods.GetMenuID__Args _args = new InternalUnsafeMethods.GetMenuID__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetMenuID()(ObjectPtr, _args);
             return _engineResult;
        }

        public virtual void OnResize() {
             InternalUnsafeMethods.OnResize__Args _args = new InternalUnsafeMethods.OnResize__Args() {
             };
             InternalUnsafeMethods.OnResize()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string Caption {
            get => GenericMarshal.StringTo<string>(GetFieldValue("caption"));
            set => SetFieldValue("caption", GenericMarshal.ToString(value));
        }

        public string ContentLibrary {
            get => GenericMarshal.StringTo<string>(GetFieldValue("contentLibrary"));
            set => SetFieldValue("contentLibrary", GenericMarshal.ToString(value));
        }

        public string Content {
            get => GenericMarshal.StringTo<string>(GetFieldValue("content"));
            set => SetFieldValue("content", GenericMarshal.ToString(value));
        }

        public bool Movable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("movable"));
            set => SetFieldValue("movable", GenericMarshal.ToString(value));
        }

        public bool HasMenu {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("hasMenu"));
            set => SetFieldValue("hasMenu", GenericMarshal.ToString(value));
        }
    }
}