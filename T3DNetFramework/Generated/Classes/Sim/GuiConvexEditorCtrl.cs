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

    public unsafe class GuiConvexEditorCtrl : EditTSCtrl {



        public GuiConvexEditorCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiConvexEditorCtrl(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiConvexEditorCtrl(string pName)
            : this(pName, false) {
        }

        public GuiConvexEditorCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiConvexEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiConvexEditorCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiConvexEditorCtrl(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct SplitSelectedFace__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SplitSelectedFace(IntPtr _this);
                internal delegate void _SplitSelectedFace(IntPtr _this, SplitSelectedFace__Args args);
                private static _SplitSelectedFace _SplitSelectedFaceFunc;
                internal static _SplitSelectedFace SplitSelectedFace() {
                    if (_SplitSelectedFaceFunc == null) {
                        _SplitSelectedFaceFunc =
                            (_SplitSelectedFace)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiConvexEditorCtrl_splitSelectedFace"), typeof(_SplitSelectedFace));
                    }

                    return _SplitSelectedFaceFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SelectConvex__Args
                {

				   internal IntPtr convex;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SelectConvex(IntPtr _this, IntPtr convex);
                internal delegate void _SelectConvex(IntPtr _this, SelectConvex__Args args);
                private static _SelectConvex _SelectConvexFunc;
                internal static _SelectConvex SelectConvex() {
                    if (_SelectConvexFunc == null) {
                        _SelectConvexFunc =
                            (_SelectConvex)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiConvexEditorCtrl_selectConvex"), typeof(_SelectConvex));
                    }

                    return _SelectConvexFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct DropSelectionAtScreenCenter__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _DropSelectionAtScreenCenter(IntPtr _this);
                internal delegate void _DropSelectionAtScreenCenter(IntPtr _this, DropSelectionAtScreenCenter__Args args);
                private static _DropSelectionAtScreenCenter _DropSelectionAtScreenCenterFunc;
                internal static _DropSelectionAtScreenCenter DropSelectionAtScreenCenter() {
                    if (_DropSelectionAtScreenCenterFunc == null) {
                        _DropSelectionAtScreenCenterFunc =
                            (_DropSelectionAtScreenCenter)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiConvexEditorCtrl_dropSelectionAtScreenCenter"), typeof(_DropSelectionAtScreenCenter));
                    }

                    return _DropSelectionAtScreenCenterFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct HandleDeselect__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _HandleDeselect(IntPtr _this);
                internal delegate void _HandleDeselect(IntPtr _this, HandleDeselect__Args args);
                private static _HandleDeselect _HandleDeselectFunc;
                internal static _HandleDeselect HandleDeselect() {
                    if (_HandleDeselectFunc == null) {
                        _HandleDeselectFunc =
                            (_HandleDeselect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiConvexEditorCtrl_handleDeselect"), typeof(_HandleDeselect));
                    }

                    return _HandleDeselectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct HandleDelete__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _HandleDelete(IntPtr _this);
                internal delegate void _HandleDelete(IntPtr _this, HandleDelete__Args args);
                private static _HandleDelete _HandleDeleteFunc;
                internal static _HandleDelete HandleDelete() {
                    if (_HandleDeleteFunc == null) {
                        _HandleDeleteFunc =
                            (_HandleDelete)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiConvexEditorCtrl_handleDelete"), typeof(_HandleDelete));
                    }

                    return _HandleDeleteFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct HasSelection__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _HasSelection(IntPtr _this);
                internal delegate int _HasSelection(IntPtr _this, HasSelection__Args args);
                private static _HasSelection _HasSelectionFunc;
                internal static _HasSelection HasSelection() {
                    if (_HasSelectionFunc == null) {
                        _HasSelectionFunc =
                            (_HasSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiConvexEditorCtrl_hasSelection"), typeof(_HasSelection));
                    }

                    return _HasSelectionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct RecenterSelection__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _RecenterSelection(IntPtr _this);
                internal delegate void _RecenterSelection(IntPtr _this, RecenterSelection__Args args);
                private static _RecenterSelection _RecenterSelectionFunc;
                internal static _RecenterSelection RecenterSelection() {
                    if (_RecenterSelectionFunc == null) {
                        _RecenterSelectionFunc =
                            (_RecenterSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiConvexEditorCtrl_recenterSelection"), typeof(_RecenterSelection));
                    }

                    return _RecenterSelectionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct HollowSelection__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _HollowSelection(IntPtr _this);
                internal delegate void _HollowSelection(IntPtr _this, HollowSelection__Args args);
                private static _HollowSelection _HollowSelectionFunc;
                internal static _HollowSelection HollowSelection() {
                    if (_HollowSelectionFunc == null) {
                        _HollowSelectionFunc =
                            (_HollowSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiConvexEditorCtrl_hollowSelection"), typeof(_HollowSelection));
                    }

                    return _HollowSelectionFunc;
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
                                    "fnGuiConvexEditorCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiConvexEditorCtrl_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void SplitSelectedFace() {

                     InternalUnsafeMethods.SplitSelectedFace__Args _args = new InternalUnsafeMethods.SplitSelectedFace__Args() {
                     };
                     InternalUnsafeMethods.SplitSelectedFace()(ObjectPtr, _args);

                  }



                  public void SelectConvex(ConvexShape convex) {

                                          InternalUnsafeMethods.SelectConvex__Args _args = new InternalUnsafeMethods.SelectConvex__Args() {
                        convex = convex.ObjectPtr,
                     };
                     InternalUnsafeMethods.SelectConvex()(ObjectPtr, _args);

                  }



                  public void DropSelectionAtScreenCenter() {

                     InternalUnsafeMethods.DropSelectionAtScreenCenter__Args _args = new InternalUnsafeMethods.DropSelectionAtScreenCenter__Args() {
                     };
                     InternalUnsafeMethods.DropSelectionAtScreenCenter()(ObjectPtr, _args);

                  }



                  public void HandleDeselect() {

                     InternalUnsafeMethods.HandleDeselect__Args _args = new InternalUnsafeMethods.HandleDeselect__Args() {
                     };
                     InternalUnsafeMethods.HandleDeselect()(ObjectPtr, _args);

                  }



                  public void HandleDelete() {

                     InternalUnsafeMethods.HandleDelete__Args _args = new InternalUnsafeMethods.HandleDelete__Args() {
                     };
                     InternalUnsafeMethods.HandleDelete()(ObjectPtr, _args);

                  }



                  public int HasSelection() {

                     InternalUnsafeMethods.HasSelection__Args _args = new InternalUnsafeMethods.HasSelection__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.HasSelection()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void RecenterSelection() {

                     InternalUnsafeMethods.RecenterSelection__Args _args = new InternalUnsafeMethods.RecenterSelection__Args() {
                     };
                     InternalUnsafeMethods.RecenterSelection()(ObjectPtr, _args);

                  }



                  public void HollowSelection() {

                     InternalUnsafeMethods.HollowSelection__Args _args = new InternalUnsafeMethods.HollowSelection__Args() {
                     };
                     InternalUnsafeMethods.HollowSelection()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public bool IsDirty {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isDirty"));
            set => SetFieldValue("isDirty", GenericMarshal.ToString(value));
        }


        public string MaterialName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("materialName"));
            set => SetFieldValue("materialName", GenericMarshal.ToString(value));
        }


    }
}
