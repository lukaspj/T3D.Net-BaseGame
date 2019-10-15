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
    public unsafe class GuiMenuBar : GuiTickCtrl {
        public GuiMenuBar(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiMenuBar(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiMenuBar(string pName) 
            : this(pName, false) {
        }
        
        public GuiMenuBar(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiMenuBar(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiMenuBar(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiMenuBar(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct FindMenu__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string barTitle;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _FindMenu(IntPtr _this, FindMenu__Args args);
            private static _FindMenu _FindMenuFunc;
            internal static _FindMenu FindMenu() {
                if (_FindMenuFunc == null) {
                    _FindMenuFunc =
                        (_FindMenu)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiMenuBar_findMenu"), typeof(_FindMenu));
                }
                
                return _FindMenuFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Insert__Args
            {
                internal IntPtr pObject;
                internal int pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Insert(IntPtr _this, Insert__Args args);
            private static _Insert _InsertFunc;
            internal static _Insert Insert() {
                if (_InsertFunc == null) {
                    _InsertFunc =
                        (_Insert)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiMenuBar_insert"), typeof(_Insert));
                }
                
                return _InsertFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMenu__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMenu(IntPtr _this, GetMenu__Args args);
            private static _GetMenu _GetMenuFunc;
            internal static _GetMenu GetMenu() {
                if (_GetMenuFunc == null) {
                    _GetMenuFunc =
                        (_GetMenu)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiMenuBar_getMenu"), typeof(_GetMenu));
                }
                
                return _GetMenuFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMenuCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMenuCount(IntPtr _this, GetMenuCount__Args args);
            private static _GetMenuCount _GetMenuCountFunc;
            internal static _GetMenuCount GetMenuCount() {
                if (_GetMenuCountFunc == null) {
                    _GetMenuCountFunc =
                        (_GetMenuCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiMenuBar_getMenuCount"), typeof(_GetMenuCount));
                }
                
                return _GetMenuCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveFromCanvas__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveFromCanvas(IntPtr _this, RemoveFromCanvas__Args args);
            private static _RemoveFromCanvas _RemoveFromCanvasFunc;
            internal static _RemoveFromCanvas RemoveFromCanvas() {
                if (_RemoveFromCanvasFunc == null) {
                    _RemoveFromCanvasFunc =
                        (_RemoveFromCanvas)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiMenuBar_removeFromCanvas"), typeof(_RemoveFromCanvas));
                }
                
                return _RemoveFromCanvasFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AttachToCanvas__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string canvas;
                internal int pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AttachToCanvas(IntPtr _this, AttachToCanvas__Args args);
            private static _AttachToCanvas _AttachToCanvasFunc;
            internal static _AttachToCanvas AttachToCanvas() {
                if (_AttachToCanvasFunc == null) {
                    _AttachToCanvasFunc =
                        (_AttachToCanvas)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiMenuBar_attachToCanvas"), typeof(_AttachToCanvas));
                }
                
                return _AttachToCanvasFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMenuItemSelect__Args
            {
                internal int menuId;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string menuText;
                internal int menuItemId;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string menuItemText;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMenuItemSelect(IntPtr _this, OnMenuItemSelect__Args args);
            private static _OnMenuItemSelect _OnMenuItemSelectFunc;
            internal static _OnMenuItemSelect OnMenuItemSelect() {
                if (_OnMenuItemSelectFunc == null) {
                    _OnMenuItemSelectFunc =
                        (_OnMenuItemSelect)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiMenuBar_onMenuItemSelect"), typeof(_OnMenuItemSelect));
                }
                
                return _OnMenuItemSelectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMenuSelect__Args
            {
                internal int menuId;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string menuText;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMenuSelect(IntPtr _this, OnMenuSelect__Args args);
            private static _OnMenuSelect _OnMenuSelectFunc;
            internal static _OnMenuSelect OnMenuSelect() {
                if (_OnMenuSelectFunc == null) {
                    _OnMenuSelectFunc =
                        (_OnMenuSelect)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiMenuBar_onMenuSelect"), typeof(_OnMenuSelect));
                }
                
                return _OnMenuSelectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMouseInMenu__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool isInMenu;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMouseInMenu(IntPtr _this, OnMouseInMenu__Args args);
            private static _OnMouseInMenu _OnMouseInMenuFunc;
            internal static _OnMouseInMenu OnMouseInMenu() {
                if (_OnMouseInMenuFunc == null) {
                    _OnMouseInMenuFunc =
                        (_OnMouseInMenu)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiMenuBar_onMouseInMenu"), typeof(_OnMouseInMenu));
                }
                
                return _OnMouseInMenuFunc;
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
                                "fnGuiMenuBar_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiMenuBar_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public int FindMenu(string barTitle = "") {
             InternalUnsafeMethods.FindMenu__Args _args = new InternalUnsafeMethods.FindMenu__Args() {
                barTitle = barTitle,
             };
             int _engineResult = InternalUnsafeMethods.FindMenu()(ObjectPtr, _args);
             return _engineResult;
        }

        public void Insert(SimObject pObject = null, int pos = -1) {
             InternalUnsafeMethods.Insert__Args _args = new InternalUnsafeMethods.Insert__Args() {
                pObject = pObject.ObjectPtr,
                pos = pos,
             };
             InternalUnsafeMethods.Insert()(ObjectPtr, _args);
        }

        public int GetMenu(int index = 0) {
             InternalUnsafeMethods.GetMenu__Args _args = new InternalUnsafeMethods.GetMenu__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetMenu()(ObjectPtr, _args);
             return _engineResult;
        }

        public int GetMenuCount() {
             InternalUnsafeMethods.GetMenuCount__Args _args = new InternalUnsafeMethods.GetMenuCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetMenuCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public void RemoveFromCanvas() {
             InternalUnsafeMethods.RemoveFromCanvas__Args _args = new InternalUnsafeMethods.RemoveFromCanvas__Args() {
             };
             InternalUnsafeMethods.RemoveFromCanvas()(ObjectPtr, _args);
        }

        public void AttachToCanvas(string canvas, int pos) {
             InternalUnsafeMethods.AttachToCanvas__Args _args = new InternalUnsafeMethods.AttachToCanvas__Args() {
                canvas = canvas,
                pos = pos,
             };
             InternalUnsafeMethods.AttachToCanvas()(ObjectPtr, _args);
        }

        public void OnMenuItemSelect(int menuId, string menuText, int menuItemId, string menuItemText) {
             InternalUnsafeMethods.OnMenuItemSelect__Args _args = new InternalUnsafeMethods.OnMenuItemSelect__Args() {
                menuId = menuId,
                menuText = menuText,
                menuItemId = menuItemId,
                menuItemText = menuItemText,
             };
             InternalUnsafeMethods.OnMenuItemSelect()(ObjectPtr, _args);
        }

        public void OnMenuSelect(int menuId, string menuText) {
             InternalUnsafeMethods.OnMenuSelect__Args _args = new InternalUnsafeMethods.OnMenuSelect__Args() {
                menuId = menuId,
                menuText = menuText,
             };
             InternalUnsafeMethods.OnMenuSelect()(ObjectPtr, _args);
        }

        public void OnMouseInMenu(bool isInMenu) {
             InternalUnsafeMethods.OnMouseInMenu__Args _args = new InternalUnsafeMethods.OnMouseInMenu__Args() {
                isInMenu = isInMenu,
             };
             InternalUnsafeMethods.OnMouseInMenu()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public int Padding {
            get => GenericMarshal.StringTo<int>(GetFieldValue("padding"));
            set => SetFieldValue("padding", GenericMarshal.ToString(value));
        }

        public int MenubarHeight {
            get => GenericMarshal.StringTo<int>(GetFieldValue("menubarHeight"));
            set => SetFieldValue("menubarHeight", GenericMarshal.ToString(value));
        }
    }
}