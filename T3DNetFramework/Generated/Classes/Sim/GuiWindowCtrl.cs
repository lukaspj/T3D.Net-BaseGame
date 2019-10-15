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
    public unsafe class GuiWindowCtrl : GuiContainer {
        public GuiWindowCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiWindowCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiWindowCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiWindowCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiWindowCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiWindowCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiWindowCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Attach__Args
            {
                internal IntPtr bottomWindow;
                internal IntPtr topWindow;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Attach(Attach__Args args);
            private static _Attach _AttachFunc;
            internal static _Attach Attach() {
                if (_AttachFunc == null) {
                    _AttachFunc =
                        (_Attach)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiWindowCtrl_attach"), typeof(_Attach));
                }
                
                return _AttachFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AttachTo__Args
            {
                internal IntPtr window;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AttachTo(IntPtr _this, AttachTo__Args args);
            private static _AttachTo _AttachToFunc;
            internal static _AttachTo AttachTo() {
                if (_AttachToFunc == null) {
                    _AttachToFunc =
                        (_AttachTo)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiWindowCtrl_attachTo"), typeof(_AttachTo));
                }
                
                return _AttachToFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ToggleCollapseGroup__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ToggleCollapseGroup(IntPtr _this, ToggleCollapseGroup__Args args);
            private static _ToggleCollapseGroup _ToggleCollapseGroupFunc;
            internal static _ToggleCollapseGroup ToggleCollapseGroup() {
                if (_ToggleCollapseGroupFunc == null) {
                    _ToggleCollapseGroupFunc =
                        (_ToggleCollapseGroup)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiWindowCtrl_toggleCollapseGroup"), typeof(_ToggleCollapseGroup));
                }
                
                return _ToggleCollapseGroupFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCollapseGroup__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool state;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCollapseGroup(IntPtr _this, SetCollapseGroup__Args args);
            private static _SetCollapseGroup _SetCollapseGroupFunc;
            internal static _SetCollapseGroup SetCollapseGroup() {
                if (_SetCollapseGroupFunc == null) {
                    _SetCollapseGroupFunc =
                        (_SetCollapseGroup)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiWindowCtrl_setCollapseGroup"), typeof(_SetCollapseGroup));
                }
                
                return _SetCollapseGroupFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectWindow__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SelectWindow(IntPtr _this, SelectWindow__Args args);
            private static _SelectWindow _SelectWindowFunc;
            internal static _SelectWindow SelectWindow() {
                if (_SelectWindowFunc == null) {
                    _SelectWindowFunc =
                        (_SelectWindow)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiWindowCtrl_selectWindow"), typeof(_SelectWindow));
                }
                
                return _SelectWindowFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnRestore__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnRestore(IntPtr _this, OnRestore__Args args);
            private static _OnRestore _OnRestoreFunc;
            internal static _OnRestore OnRestore() {
                if (_OnRestoreFunc == null) {
                    _OnRestoreFunc =
                        (_OnRestore)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiWindowCtrl_onRestore"), typeof(_OnRestore));
                }
                
                return _OnRestoreFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnCollapse__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnCollapse(IntPtr _this, OnCollapse__Args args);
            private static _OnCollapse _OnCollapseFunc;
            internal static _OnCollapse OnCollapse() {
                if (_OnCollapseFunc == null) {
                    _OnCollapseFunc =
                        (_OnCollapse)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiWindowCtrl_onCollapse"), typeof(_OnCollapse));
                }
                
                return _OnCollapseFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMaximize__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMaximize(IntPtr _this, OnMaximize__Args args);
            private static _OnMaximize _OnMaximizeFunc;
            internal static _OnMaximize OnMaximize() {
                if (_OnMaximizeFunc == null) {
                    _OnMaximizeFunc =
                        (_OnMaximize)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiWindowCtrl_onMaximize"), typeof(_OnMaximize));
                }
                
                return _OnMaximizeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMinimize__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMinimize(IntPtr _this, OnMinimize__Args args);
            private static _OnMinimize _OnMinimizeFunc;
            internal static _OnMinimize OnMinimize() {
                if (_OnMinimizeFunc == null) {
                    _OnMinimizeFunc =
                        (_OnMinimize)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiWindowCtrl_onMinimize"), typeof(_OnMinimize));
                }
                
                return _OnMinimizeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnClose__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnClose(IntPtr _this, OnClose__Args args);
            private static _OnClose _OnCloseFunc;
            internal static _OnClose OnClose() {
                if (_OnCloseFunc == null) {
                    _OnCloseFunc =
                        (_OnClose)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiWindowCtrl_onClose"), typeof(_OnClose));
                }
                
                return _OnCloseFunc;
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
                                "fnGuiWindowCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiWindowCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public static void Attach(GuiWindowCtrl bottomWindow, GuiWindowCtrl topWindow) {
             InternalUnsafeMethods.Attach__Args _args = new InternalUnsafeMethods.Attach__Args() {
                bottomWindow = bottomWindow.ObjectPtr,
                topWindow = topWindow.ObjectPtr,
             };
             InternalUnsafeMethods.Attach()(_args);
        }

        public void AttachTo(GuiWindowCtrl window) {
             InternalUnsafeMethods.AttachTo__Args _args = new InternalUnsafeMethods.AttachTo__Args() {
                window = window.ObjectPtr,
             };
             InternalUnsafeMethods.AttachTo()(ObjectPtr, _args);
        }

        public void ToggleCollapseGroup() {
             InternalUnsafeMethods.ToggleCollapseGroup__Args _args = new InternalUnsafeMethods.ToggleCollapseGroup__Args() {
             };
             InternalUnsafeMethods.ToggleCollapseGroup()(ObjectPtr, _args);
        }

        public void SetCollapseGroup(bool state) {
             InternalUnsafeMethods.SetCollapseGroup__Args _args = new InternalUnsafeMethods.SetCollapseGroup__Args() {
                state = state,
             };
             InternalUnsafeMethods.SetCollapseGroup()(ObjectPtr, _args);
        }

        public void SelectWindow() {
             InternalUnsafeMethods.SelectWindow__Args _args = new InternalUnsafeMethods.SelectWindow__Args() {
             };
             InternalUnsafeMethods.SelectWindow()(ObjectPtr, _args);
        }

        public void OnRestore() {
             InternalUnsafeMethods.OnRestore__Args _args = new InternalUnsafeMethods.OnRestore__Args() {
             };
             InternalUnsafeMethods.OnRestore()(ObjectPtr, _args);
        }

        public void OnCollapse() {
             InternalUnsafeMethods.OnCollapse__Args _args = new InternalUnsafeMethods.OnCollapse__Args() {
             };
             InternalUnsafeMethods.OnCollapse()(ObjectPtr, _args);
        }

        public void OnMaximize() {
             InternalUnsafeMethods.OnMaximize__Args _args = new InternalUnsafeMethods.OnMaximize__Args() {
             };
             InternalUnsafeMethods.OnMaximize()(ObjectPtr, _args);
        }

        public void OnMinimize() {
             InternalUnsafeMethods.OnMinimize__Args _args = new InternalUnsafeMethods.OnMinimize__Args() {
             };
             InternalUnsafeMethods.OnMinimize()(ObjectPtr, _args);
        }

        public void OnClose() {
             InternalUnsafeMethods.OnClose__Args _args = new InternalUnsafeMethods.OnClose__Args() {
             };
             InternalUnsafeMethods.OnClose()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string Text {
            get => GenericMarshal.StringTo<string>(GetFieldValue("text"));
            set => SetFieldValue("text", GenericMarshal.ToString(value));
        }

        public bool ResizeWidth {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("resizeWidth"));
            set => SetFieldValue("resizeWidth", GenericMarshal.ToString(value));
        }

        public bool ResizeHeight {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("resizeHeight"));
            set => SetFieldValue("resizeHeight", GenericMarshal.ToString(value));
        }

        public bool CanMove {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("canMove"));
            set => SetFieldValue("canMove", GenericMarshal.ToString(value));
        }

        public bool CanClose {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("canClose"));
            set => SetFieldValue("canClose", GenericMarshal.ToString(value));
        }

        public bool CanMinimize {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("canMinimize"));
            set => SetFieldValue("canMinimize", GenericMarshal.ToString(value));
        }

        public bool CanMaximize {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("canMaximize"));
            set => SetFieldValue("canMaximize", GenericMarshal.ToString(value));
        }

        public bool CanCollapse {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("canCollapse"));
            set => SetFieldValue("canCollapse", GenericMarshal.ToString(value));
        }

        public string CloseCommand {
            get => GenericMarshal.StringTo<string>(GetFieldValue("closeCommand"));
            set => SetFieldValue("closeCommand", GenericMarshal.ToString(value));
        }

        public bool EdgeSnap {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("edgeSnap"));
            set => SetFieldValue("edgeSnap", GenericMarshal.ToString(value));
        }
    }
}