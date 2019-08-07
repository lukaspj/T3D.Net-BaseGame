using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class EditManager : GuiControl {



        public EditManager(bool pRegister = false)
            : base(pRegister) {
        }

        public EditManager(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public EditManager(string pName)
            : this(pName, false) {
        }

        public EditManager(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public EditManager(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public EditManager(SimObject pObj)
            : base(pObj) {
        }

        public EditManager(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsEditorEnabled__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsEditorEnabled(IntPtr _this);
                internal delegate bool _IsEditorEnabled(IntPtr _this, IsEditorEnabled__Args args);
                private static _IsEditorEnabled _IsEditorEnabledFunc;
                internal static _IsEditorEnabled IsEditorEnabled() {
                    if (_IsEditorEnabledFunc == null) {
                        _IsEditorEnabledFunc =
                            (_IsEditorEnabled)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEditManager_isEditorEnabled"), typeof(_IsEditorEnabled));
                    }

                    return _IsEditorEnabledFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct EditorDisabled__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _EditorDisabled(IntPtr _this);
                internal delegate void _EditorDisabled(IntPtr _this, EditorDisabled__Args args);
                private static _EditorDisabled _EditorDisabledFunc;
                internal static _EditorDisabled EditorDisabled() {
                    if (_EditorDisabledFunc == null) {
                        _EditorDisabledFunc =
                            (_EditorDisabled)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEditManager_editorDisabled"), typeof(_EditorDisabled));
                    }

                    return _EditorDisabledFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct EditorEnabled__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _EditorEnabled(IntPtr _this);
                internal delegate void _EditorEnabled(IntPtr _this, EditorEnabled__Args args);
                private static _EditorEnabled _EditorEnabledFunc;
                internal static _EditorEnabled EditorEnabled() {
                    if (_EditorEnabledFunc == null) {
                        _EditorEnabledFunc =
                            (_EditorEnabled)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEditManager_editorEnabled"), typeof(_EditorEnabled));
                    }

                    return _EditorEnabledFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GotoBookmark__Args
                {

				   internal int val;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _GotoBookmark(IntPtr _this, int val);
                internal delegate void _GotoBookmark(IntPtr _this, GotoBookmark__Args args);
                private static _GotoBookmark _GotoBookmarkFunc;
                internal static _GotoBookmark GotoBookmark() {
                    if (_GotoBookmarkFunc == null) {
                        _GotoBookmarkFunc =
                            (_GotoBookmark)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEditManager_gotoBookmark"), typeof(_GotoBookmark));
                    }

                    return _GotoBookmarkFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetBookmark__Args
                {

				   internal int val;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetBookmark(IntPtr _this, int val);
                internal delegate void _SetBookmark(IntPtr _this, SetBookmark__Args args);
                private static _SetBookmark _SetBookmarkFunc;
                internal static _SetBookmark SetBookmark() {
                    if (_SetBookmarkFunc == null) {
                        _SetBookmarkFunc =
                            (_SetBookmark)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEditManager_setBookmark"), typeof(_SetBookmark));
                    }

                    return _SetBookmarkFunc;
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
                                    "fnEditManager_staticGetType"), typeof(_StaticGetType));
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
                                    "fnEditManager_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public bool IsEditorEnabled() {

                     InternalUnsafeMethods.IsEditorEnabled__Args _args = new InternalUnsafeMethods.IsEditorEnabled__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsEditorEnabled()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void EditorDisabled() {

                     InternalUnsafeMethods.EditorDisabled__Args _args = new InternalUnsafeMethods.EditorDisabled__Args() {
                     };
                     InternalUnsafeMethods.EditorDisabled()(ObjectPtr, _args);

                  }



                  public void EditorEnabled() {

                     InternalUnsafeMethods.EditorEnabled__Args _args = new InternalUnsafeMethods.EditorEnabled__Args() {
                     };
                     InternalUnsafeMethods.EditorEnabled()(ObjectPtr, _args);

                  }



                  public void GotoBookmark(int val) {

                                          InternalUnsafeMethods.GotoBookmark__Args _args = new InternalUnsafeMethods.GotoBookmark__Args() {
                        val = val,
                     };
                     InternalUnsafeMethods.GotoBookmark()(ObjectPtr, _args);

                  }



                  public void SetBookmark(int val) {

                                          InternalUnsafeMethods.SetBookmark__Args _args = new InternalUnsafeMethods.SetBookmark__Args() {
                        val = val,
                     };
                     InternalUnsafeMethods.SetBookmark()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
