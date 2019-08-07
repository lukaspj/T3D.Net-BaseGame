using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class GuiControl : SimGroup {



        public GuiControl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiControl(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiControl(string pName)
            : this(pName, false) {
        }

        public GuiControl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiControl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiControl(SimObject pObj)
            : base(pObj) {
        }

        public GuiControl(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetAspect__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetAspect(IntPtr _this);
                internal delegate float _GetAspect(IntPtr _this, GetAspect__Args args);
                private static _GetAspect _GetAspectFunc;
                internal static _GetAspect GetAspect() {
                    if (_GetAspectFunc == null) {
                        _GetAspectFunc =
                            (_GetAspect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_getAspect"), typeof(_GetAspect));
                    }

                    return _GetAspectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMinExtent__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point2I.InternalStruct _GetMinExtent(IntPtr _this);
                internal delegate Point2I.InternalStruct _GetMinExtent(IntPtr _this, GetMinExtent__Args args);
                private static _GetMinExtent _GetMinExtentFunc;
                internal static _GetMinExtent GetMinExtent() {
                    if (_GetMinExtentFunc == null) {
                        _GetMinExtentFunc =
                            (_GetMinExtent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_getMinExtent"), typeof(_GetMinExtent));
                    }

                    return _GetMinExtentFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetExtent__Args
                {

				   internal string extOrX;

				   internal string y;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetExtent(IntPtr _this, string extOrX, string y);
                internal delegate void _SetExtent(IntPtr _this, SetExtent__Args args);
                private static _SetExtent _SetExtentFunc;
                internal static _SetExtent SetExtent() {
                    if (_SetExtentFunc == null) {
                        _SetExtentFunc =
                            (_SetExtent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_setExtent"), typeof(_SetExtent));
                    }

                    return _SetExtentFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetExtent__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point2I.InternalStruct _GetExtent(IntPtr _this);
                internal delegate Point2I.InternalStruct _GetExtent(IntPtr _this, GetExtent__Args args);
                private static _GetExtent _GetExtentFunc;
                internal static _GetExtent GetExtent() {
                    if (_GetExtentFunc == null) {
                        _GetExtentFunc =
                            (_GetExtent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_getExtent"), typeof(_GetExtent));
                    }

                    return _GetExtentFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetPosition__Args
                {

				   internal int x;

				   internal int y;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetPosition(IntPtr _this, int x, int y);
                internal delegate void _SetPosition(IntPtr _this, SetPosition__Args args);
                private static _SetPosition _SetPositionFunc;
                internal static _SetPosition SetPosition() {
                    if (_SetPositionFunc == null) {
                        _SetPositionFunc =
                            (_SetPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_setPosition"), typeof(_SetPosition));
                    }

                    return _SetPositionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetPositionGlobal__Args
                {

				   internal int x;

				   internal int y;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetPositionGlobal(IntPtr _this, int x, int y);
                internal delegate void _SetPositionGlobal(IntPtr _this, SetPositionGlobal__Args args);
                private static _SetPositionGlobal _SetPositionGlobalFunc;
                internal static _SetPositionGlobal SetPositionGlobal() {
                    if (_SetPositionGlobalFunc == null) {
                        _SetPositionGlobalFunc =
                            (_SetPositionGlobal)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_setPositionGlobal"), typeof(_SetPositionGlobal));
                    }

                    return _SetPositionGlobalFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetGlobalPosition__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point2I.InternalStruct _GetGlobalPosition(IntPtr _this);
                internal delegate Point2I.InternalStruct _GetGlobalPosition(IntPtr _this, GetGlobalPosition__Args args);
                private static _GetGlobalPosition _GetGlobalPositionFunc;
                internal static _GetGlobalPosition GetGlobalPosition() {
                    if (_GetGlobalPositionFunc == null) {
                        _GetGlobalPositionFunc =
                            (_GetGlobalPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_getGlobalPosition"), typeof(_GetGlobalPosition));
                    }

                    return _GetGlobalPositionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetGlobalCenter__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point2I.InternalStruct _GetGlobalCenter(IntPtr _this);
                internal delegate Point2I.InternalStruct _GetGlobalCenter(IntPtr _this, GetGlobalCenter__Args args);
                private static _GetGlobalCenter _GetGlobalCenterFunc;
                internal static _GetGlobalCenter GetGlobalCenter() {
                    if (_GetGlobalCenterFunc == null) {
                        _GetGlobalCenterFunc =
                            (_GetGlobalCenter)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_getGlobalCenter"), typeof(_GetGlobalCenter));
                    }

                    return _GetGlobalCenterFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCenter__Args
                {

				   internal int x;

				   internal int y;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetCenter(IntPtr _this, int x, int y);
                internal delegate void _SetCenter(IntPtr _this, SetCenter__Args args);
                private static _SetCenter _SetCenterFunc;
                internal static _SetCenter SetCenter() {
                    if (_SetCenterFunc == null) {
                        _SetCenterFunc =
                            (_SetCenter)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_setCenter"), typeof(_SetCenter));
                    }

                    return _SetCenterFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetCenter__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point2I.InternalStruct _GetCenter(IntPtr _this);
                internal delegate Point2I.InternalStruct _GetCenter(IntPtr _this, GetCenter__Args args);
                private static _GetCenter _GetCenterFunc;
                internal static _GetCenter GetCenter() {
                    if (_GetCenterFunc == null) {
                        _GetCenterFunc =
                            (_GetCenter)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_getCenter"), typeof(_GetCenter));
                    }

                    return _GetCenterFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetPosition__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point2I.InternalStruct _GetPosition(IntPtr _this);
                internal delegate Point2I.InternalStruct _GetPosition(IntPtr _this, GetPosition__Args args);
                private static _GetPosition _GetPositionFunc;
                internal static _GetPosition GetPosition() {
                    if (_GetPositionFunc == null) {
                        _GetPositionFunc =
                            (_GetPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_getPosition"), typeof(_GetPosition));
                    }

                    return _GetPositionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Resize__Args
                {

				   internal int x;

				   internal int y;

				   internal int width;

				   internal int height;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Resize(IntPtr _this, int x, int y, int width, int height);
                internal delegate void _Resize(IntPtr _this, Resize__Args args);
                private static _Resize _ResizeFunc;
                internal static _Resize Resize() {
                    if (_ResizeFunc == null) {
                        _ResizeFunc =
                            (_Resize)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_resize"), typeof(_Resize));
                    }

                    return _ResizeFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetProfile__Args
                {

				   internal IntPtr profile;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetProfile(IntPtr _this, IntPtr profile);
                internal delegate void _SetProfile(IntPtr _this, SetProfile__Args args);
                private static _SetProfile _SetProfileFunc;
                internal static _SetProfile SetProfile() {
                    if (_SetProfileFunc == null) {
                        _SetProfileFunc =
                            (_SetProfile)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_setProfile"), typeof(_SetProfile));
                    }

                    return _SetProfileFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsAwake__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsAwake(IntPtr _this);
                internal delegate bool _IsAwake(IntPtr _this, IsAwake__Args args);
                private static _IsAwake _IsAwakeFunc;
                internal static _IsAwake IsAwake() {
                    if (_IsAwakeFunc == null) {
                        _IsAwakeFunc =
                            (_IsAwake)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_isAwake"), typeof(_IsAwake));
                    }

                    return _IsAwakeFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetVisible__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetVisible(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _SetVisible(IntPtr _this, SetVisible__Args args);
                private static _SetVisible _SetVisibleFunc;
                internal static _SetVisible SetVisible() {
                    if (_SetVisibleFunc == null) {
                        _SetVisibleFunc =
                            (_SetVisible)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_setVisible"), typeof(_SetVisible));
                    }

                    return _SetVisibleFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsVisible__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsVisible(IntPtr _this);
                internal delegate bool _IsVisible(IntPtr _this, IsVisible__Args args);
                private static _IsVisible _IsVisibleFunc;
                internal static _IsVisible IsVisible() {
                    if (_IsVisibleFunc == null) {
                        _IsVisibleFunc =
                            (_IsVisible)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_isVisible"), typeof(_IsVisible));
                    }

                    return _IsVisibleFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetActive__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetActive(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _SetActive(IntPtr _this, SetActive__Args args);
                private static _SetActive _SetActiveFunc;
                internal static _SetActive SetActive() {
                    if (_SetActiveFunc == null) {
                        _SetActiveFunc =
                            (_SetActive)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_setActive"), typeof(_SetActive));
                    }

                    return _SetActiveFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsActive__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsActive(IntPtr _this);
                internal delegate bool _IsActive(IntPtr _this, IsActive__Args args);
                private static _IsActive _IsActiveFunc;
                internal static _IsActive IsActive() {
                    if (_IsActiveFunc == null) {
                        _IsActiveFunc =
                            (_IsActive)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_isActive"), typeof(_IsActive));
                    }

                    return _IsActiveFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct MakeFirstResponder__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool isFirst;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _MakeFirstResponder(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool isFirst);
                internal delegate void _MakeFirstResponder(IntPtr _this, MakeFirstResponder__Args args);
                private static _MakeFirstResponder _MakeFirstResponderFunc;
                internal static _MakeFirstResponder MakeFirstResponder() {
                    if (_MakeFirstResponderFunc == null) {
                        _MakeFirstResponderFunc =
                            (_MakeFirstResponder)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_makeFirstResponder"), typeof(_MakeFirstResponder));
                    }

                    return _MakeFirstResponderFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetValue__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetValue(IntPtr _this);
                internal delegate IntPtr _GetValue(IntPtr _this, GetValue__Args args);
                private static _GetValue _GetValueFunc;
                internal static _GetValue GetValue() {
                    if (_GetValueFunc == null) {
                        _GetValueFunc =
                            (_GetValue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_getValue"), typeof(_GetValue));
                    }

                    return _GetValueFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetValue__Args
                {

				   internal string value;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetValue(IntPtr _this, string value);
                internal delegate void _SetValue(IntPtr _this, SetValue__Args args);
                private static _SetValue _SetValueFunc;
                internal static _SetValue SetValue() {
                    if (_SetValueFunc == null) {
                        _SetValueFunc =
                            (_SetValue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_setValue"), typeof(_SetValue));
                    }

                    return _SetValueFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsMouseLocked__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsMouseLocked(IntPtr _this);
                internal delegate bool _IsMouseLocked(IntPtr _this, IsMouseLocked__Args args);
                private static _IsMouseLocked _IsMouseLockedFunc;
                internal static _IsMouseLocked IsMouseLocked() {
                    if (_IsMouseLockedFunc == null) {
                        _IsMouseLockedFunc =
                            (_IsMouseLocked)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_isMouseLocked"), typeof(_IsMouseLocked));
                    }

                    return _IsMouseLockedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetParent__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetParent(IntPtr _this);
                internal delegate IntPtr _GetParent(IntPtr _this, GetParent__Args args);
                private static _GetParent _GetParentFunc;
                internal static _GetParent GetParent() {
                    if (_GetParentFunc == null) {
                        _GetParentFunc =
                            (_GetParent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_getParent"), typeof(_GetParent));
                    }

                    return _GetParentFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetRoot__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetRoot(IntPtr _this);
                internal delegate IntPtr _GetRoot(IntPtr _this, GetRoot__Args args);
                private static _GetRoot _GetRootFunc;
                internal static _GetRoot GetRoot() {
                    if (_GetRootFunc == null) {
                        _GetRootFunc =
                            (_GetRoot)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_getRoot"), typeof(_GetRoot));
                    }

                    return _GetRootFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct AddGuiControl__Args
                {

				   internal IntPtr control;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _AddGuiControl(IntPtr _this, IntPtr control);
                internal delegate void _AddGuiControl(IntPtr _this, AddGuiControl__Args args);
                private static _AddGuiControl _AddGuiControlFunc;
                internal static _AddGuiControl AddGuiControl() {
                    if (_AddGuiControlFunc == null) {
                        _AddGuiControlFunc =
                            (_AddGuiControl)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_addGuiControl"), typeof(_AddGuiControl));
                    }

                    return _AddGuiControlFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct PointInControl__Args
                {

				   internal int x;

				   internal int y;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _PointInControl(IntPtr _this, int x, int y);
                internal delegate bool _PointInControl(IntPtr _this, PointInControl__Args args);
                private static _PointInControl _PointInControlFunc;
                internal static _PointInControl PointInControl() {
                    if (_PointInControlFunc == null) {
                        _PointInControlFunc =
                            (_PointInControl)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_pointInControl"), typeof(_PointInControl));
                    }

                    return _PointInControlFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearFirstResponder__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool ignored;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ClearFirstResponder(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool ignored);
                internal delegate void _ClearFirstResponder(IntPtr _this, ClearFirstResponder__Args args);
                private static _ClearFirstResponder _ClearFirstResponderFunc;
                internal static _ClearFirstResponder ClearFirstResponder() {
                    if (_ClearFirstResponderFunc == null) {
                        _ClearFirstResponderFunc =
                            (_ClearFirstResponder)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_clearFirstResponder"), typeof(_ClearFirstResponder));
                    }

                    return _ClearFirstResponderFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetFirstResponder__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetFirstResponder(IntPtr _this);
                internal delegate IntPtr _GetFirstResponder(IntPtr _this, GetFirstResponder__Args args);
                private static _GetFirstResponder _GetFirstResponderFunc;
                internal static _GetFirstResponder GetFirstResponder() {
                    if (_GetFirstResponderFunc == null) {
                        _GetFirstResponderFunc =
                            (_GetFirstResponder)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_getFirstResponder"), typeof(_GetFirstResponder));
                    }

                    return _GetFirstResponderFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetFirstResponder__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetFirstResponder(IntPtr _this);
                internal delegate void _SetFirstResponder(IntPtr _this, SetFirstResponder__Args args);
                private static _SetFirstResponder _SetFirstResponderFunc;
                internal static _SetFirstResponder SetFirstResponder() {
                    if (_SetFirstResponderFunc == null) {
                        _SetFirstResponderFunc =
                            (_SetFirstResponder)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_setFirstResponder"), typeof(_SetFirstResponder));
                    }

                    return _SetFirstResponderFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsFirstResponder__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsFirstResponder(IntPtr _this);
                internal delegate bool _IsFirstResponder(IntPtr _this, IsFirstResponder__Args args);
                private static _IsFirstResponder _IsFirstResponderFunc;
                internal static _IsFirstResponder IsFirstResponder() {
                    if (_IsFirstResponderFunc == null) {
                        _IsFirstResponderFunc =
                            (_IsFirstResponder)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_isFirstResponder"), typeof(_IsFirstResponder));
                    }

                    return _IsFirstResponderFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ControlIsChild__Args
                {

				   internal IntPtr control;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _ControlIsChild(IntPtr _this, IntPtr control);
                internal delegate bool _ControlIsChild(IntPtr _this, ControlIsChild__Args args);
                private static _ControlIsChild _ControlIsChildFunc;
                internal static _ControlIsChild ControlIsChild() {
                    if (_ControlIsChildFunc == null) {
                        _ControlIsChildFunc =
                            (_ControlIsChild)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_controlIsChild"), typeof(_ControlIsChild));
                    }

                    return _ControlIsChildFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct FindHitControls__Args
                {

				   internal int x;

				   internal int y;

				   internal int width;

				   internal int height;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _FindHitControls(IntPtr _this, int x, int y, int width, int height);
                internal delegate IntPtr _FindHitControls(IntPtr _this, FindHitControls__Args args);
                private static _FindHitControls _FindHitControlsFunc;
                internal static _FindHitControls FindHitControls() {
                    if (_FindHitControlsFunc == null) {
                        _FindHitControlsFunc =
                            (_FindHitControls)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_findHitControls"), typeof(_FindHitControls));
                    }

                    return _FindHitControlsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct FindHitControl__Args
                {

				   internal int x;

				   internal int y;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _FindHitControl(IntPtr _this, int x, int y);
                internal delegate IntPtr _FindHitControl(IntPtr _this, FindHitControl__Args args);
                private static _FindHitControl _FindHitControlFunc;
                internal static _FindHitControl FindHitControl() {
                    if (_FindHitControlFunc == null) {
                        _FindHitControlFunc =
                            (_FindHitControl)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiControl_findHitControl"), typeof(_FindHitControl));
                    }

                    return _FindHitControlFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnControlDropped__Args
                {

				   internal IntPtr control;

				   internal IntPtr dropPoint;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnControlDropped(IntPtr _this, IntPtr control, IntPtr dropPoint);
                internal delegate void _OnControlDropped(IntPtr _this, OnControlDropped__Args args);
                private static _OnControlDropped _OnControlDroppedFunc;
                internal static _OnControlDropped OnControlDropped() {
                    if (_OnControlDroppedFunc == null) {
                        _OnControlDroppedFunc =
                            (_OnControlDropped)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onControlDropped"), typeof(_OnControlDropped));
                    }

                    return _OnControlDroppedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnControlDragged__Args
                {

				   internal IntPtr control;

				   internal IntPtr dropPoint;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnControlDragged(IntPtr _this, IntPtr control, IntPtr dropPoint);
                internal delegate void _OnControlDragged(IntPtr _this, OnControlDragged__Args args);
                private static _OnControlDragged _OnControlDraggedFunc;
                internal static _OnControlDragged OnControlDragged() {
                    if (_OnControlDraggedFunc == null) {
                        _OnControlDraggedFunc =
                            (_OnControlDragged)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onControlDragged"), typeof(_OnControlDragged));
                    }

                    return _OnControlDraggedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnControlDragExit__Args
                {

				   internal IntPtr control;

				   internal IntPtr dropPoint;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnControlDragExit(IntPtr _this, IntPtr control, IntPtr dropPoint);
                internal delegate void _OnControlDragExit(IntPtr _this, OnControlDragExit__Args args);
                private static _OnControlDragExit _OnControlDragExitFunc;
                internal static _OnControlDragExit OnControlDragExit() {
                    if (_OnControlDragExitFunc == null) {
                        _OnControlDragExitFunc =
                            (_OnControlDragExit)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onControlDragExit"), typeof(_OnControlDragExit));
                    }

                    return _OnControlDragExitFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnControlDragEnter__Args
                {

				   internal IntPtr control;

				   internal IntPtr dropPoint;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnControlDragEnter(IntPtr _this, IntPtr control, IntPtr dropPoint);
                internal delegate void _OnControlDragEnter(IntPtr _this, OnControlDragEnter__Args args);
                private static _OnControlDragEnter _OnControlDragEnterFunc;
                internal static _OnControlDragEnter OnControlDragEnter() {
                    if (_OnControlDragEnterFunc == null) {
                        _OnControlDragEnterFunc =
                            (_OnControlDragEnter)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onControlDragEnter"), typeof(_OnControlDragEnter));
                    }

                    return _OnControlDragEnterFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDialogPop__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnDialogPop(IntPtr _this);
                internal delegate void _OnDialogPop(IntPtr _this, OnDialogPop__Args args);
                private static _OnDialogPop _OnDialogPopFunc;
                internal static _OnDialogPop OnDialogPop() {
                    if (_OnDialogPopFunc == null) {
                        _OnDialogPopFunc =
                            (_OnDialogPop)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onDialogPop"), typeof(_OnDialogPop));
                    }

                    return _OnDialogPopFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDialogPush__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnDialogPush(IntPtr _this);
                internal delegate void _OnDialogPush(IntPtr _this, OnDialogPush__Args args);
                private static _OnDialogPush _OnDialogPushFunc;
                internal static _OnDialogPush OnDialogPush() {
                    if (_OnDialogPushFunc == null) {
                        _OnDialogPushFunc =
                            (_OnDialogPush)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onDialogPush"), typeof(_OnDialogPush));
                    }

                    return _OnDialogPushFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnActive__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnActive(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _OnActive(IntPtr _this, OnActive__Args args);
                private static _OnActive _OnActiveFunc;
                internal static _OnActive OnActive() {
                    if (_OnActiveFunc == null) {
                        _OnActiveFunc =
                            (_OnActive)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onActive"), typeof(_OnActive));
                    }

                    return _OnActiveFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnVisible__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnVisible(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _OnVisible(IntPtr _this, OnVisible__Args args);
                private static _OnVisible _OnVisibleFunc;
                internal static _OnVisible OnVisible() {
                    if (_OnVisibleFunc == null) {
                        _OnVisibleFunc =
                            (_OnVisible)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onVisible"), typeof(_OnVisible));
                    }

                    return _OnVisibleFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnAction__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnAction(IntPtr _this);
                internal delegate void _OnAction(IntPtr _this, OnAction__Args args);
                private static _OnAction _OnActionFunc;
                internal static _OnAction OnAction() {
                    if (_OnActionFunc == null) {
                        _OnActionFunc =
                            (_OnAction)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onAction"), typeof(_OnAction));
                    }

                    return _OnActionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnLoseFirstResponder__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnLoseFirstResponder(IntPtr _this);
                internal delegate void _OnLoseFirstResponder(IntPtr _this, OnLoseFirstResponder__Args args);
                private static _OnLoseFirstResponder _OnLoseFirstResponderFunc;
                internal static _OnLoseFirstResponder OnLoseFirstResponder() {
                    if (_OnLoseFirstResponderFunc == null) {
                        _OnLoseFirstResponderFunc =
                            (_OnLoseFirstResponder)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onLoseFirstResponder"), typeof(_OnLoseFirstResponder));
                    }

                    return _OnLoseFirstResponderFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnGainFirstResponder__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnGainFirstResponder(IntPtr _this);
                internal delegate void _OnGainFirstResponder(IntPtr _this, OnGainFirstResponder__Args args);
                private static _OnGainFirstResponder _OnGainFirstResponderFunc;
                internal static _OnGainFirstResponder OnGainFirstResponder() {
                    if (_OnGainFirstResponderFunc == null) {
                        _OnGainFirstResponderFunc =
                            (_OnGainFirstResponder)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onGainFirstResponder"), typeof(_OnGainFirstResponder));
                    }

                    return _OnGainFirstResponderFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnSleep__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnSleep(IntPtr _this);
                internal delegate void _OnSleep(IntPtr _this, OnSleep__Args args);
                private static _OnSleep _OnSleepFunc;
                internal static _OnSleep OnSleep() {
                    if (_OnSleepFunc == null) {
                        _OnSleepFunc =
                            (_OnSleep)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onSleep"), typeof(_OnSleep));
                    }

                    return _OnSleepFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnWake__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnWake(IntPtr _this);
                internal delegate void _OnWake(IntPtr _this, OnWake__Args args);
                private static _OnWake _OnWakeFunc;
                internal static _OnWake OnWake() {
                    if (_OnWakeFunc == null) {
                        _OnWakeFunc =
                            (_OnWake)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onWake"), typeof(_OnWake));
                    }

                    return _OnWakeFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnRemove__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnRemove(IntPtr _this);
                internal delegate void _OnRemove(IntPtr _this, OnRemove__Args args);
                private static _OnRemove _OnRemoveFunc;
                internal static _OnRemove OnRemove() {
                    if (_OnRemoveFunc == null) {
                        _OnRemoveFunc =
                            (_OnRemove)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onRemove"), typeof(_OnRemove));
                    }

                    return _OnRemoveFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnAdd__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnAdd(IntPtr _this);
                internal delegate void _OnAdd(IntPtr _this, OnAdd__Args args);
                private static _OnAdd _OnAddFunc;
                internal static _OnAdd OnAdd() {
                    if (_OnAddFunc == null) {
                        _OnAddFunc =
                            (_OnAdd)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiControl_onAdd"), typeof(_OnAdd));
                    }

                    return _OnAddFunc;
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
                                    "fnGuiControl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiControl_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public float GetAspect() {

                     InternalUnsafeMethods.GetAspect__Args _args = new InternalUnsafeMethods.GetAspect__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetAspect()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public Point2I GetMinExtent() {

                     InternalUnsafeMethods.GetMinExtent__Args _args = new InternalUnsafeMethods.GetMinExtent__Args() {
                     };
                     Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetMinExtent()(ObjectPtr, _args);

                     return new Point2I(_engineResult);
                  }



                  public void SetExtent(string extOrX, string y = "") {

                                                               InternalUnsafeMethods.SetExtent__Args _args = new InternalUnsafeMethods.SetExtent__Args() {
                        extOrX = extOrX,
                        y = y,
                     };
                     InternalUnsafeMethods.SetExtent()(ObjectPtr, _args);

                  }



                  public Point2I GetExtent() {

                     InternalUnsafeMethods.GetExtent__Args _args = new InternalUnsafeMethods.GetExtent__Args() {
                     };
                     Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetExtent()(ObjectPtr, _args);

                     return new Point2I(_engineResult);
                  }



                  public void SetPosition(int x, int y) {

                                                               InternalUnsafeMethods.SetPosition__Args _args = new InternalUnsafeMethods.SetPosition__Args() {
                        x = x,
                        y = y,
                     };
                     InternalUnsafeMethods.SetPosition()(ObjectPtr, _args);

                  }



                  public void SetPositionGlobal(int x, int y) {

                                                               InternalUnsafeMethods.SetPositionGlobal__Args _args = new InternalUnsafeMethods.SetPositionGlobal__Args() {
                        x = x,
                        y = y,
                     };
                     InternalUnsafeMethods.SetPositionGlobal()(ObjectPtr, _args);

                  }



                  public Point2I GetGlobalPosition() {

                     InternalUnsafeMethods.GetGlobalPosition__Args _args = new InternalUnsafeMethods.GetGlobalPosition__Args() {
                     };
                     Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetGlobalPosition()(ObjectPtr, _args);

                     return new Point2I(_engineResult);
                  }



                  public Point2I GetGlobalCenter() {

                     InternalUnsafeMethods.GetGlobalCenter__Args _args = new InternalUnsafeMethods.GetGlobalCenter__Args() {
                     };
                     Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetGlobalCenter()(ObjectPtr, _args);

                     return new Point2I(_engineResult);
                  }



                  public void SetCenter(int x, int y) {

                                                               InternalUnsafeMethods.SetCenter__Args _args = new InternalUnsafeMethods.SetCenter__Args() {
                        x = x,
                        y = y,
                     };
                     InternalUnsafeMethods.SetCenter()(ObjectPtr, _args);

                  }



                  public Point2I GetCenter() {

                     InternalUnsafeMethods.GetCenter__Args _args = new InternalUnsafeMethods.GetCenter__Args() {
                     };
                     Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetCenter()(ObjectPtr, _args);

                     return new Point2I(_engineResult);
                  }



                  public Point2I GetPosition() {

                     InternalUnsafeMethods.GetPosition__Args _args = new InternalUnsafeMethods.GetPosition__Args() {
                     };
                     Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetPosition()(ObjectPtr, _args);

                     return new Point2I(_engineResult);
                  }



                  public void Resize(int x, int y, int width, int height) {

                                                                                                         InternalUnsafeMethods.Resize__Args _args = new InternalUnsafeMethods.Resize__Args() {
                        x = x,
                        y = y,
                        width = width,
                        height = height,
                     };
                     InternalUnsafeMethods.Resize()(ObjectPtr, _args);

                  }



                  public void SetProfile(GuiControlProfile profile) {

                                          InternalUnsafeMethods.SetProfile__Args _args = new InternalUnsafeMethods.SetProfile__Args() {
                        profile = profile.ObjectPtr,
                     };
                     InternalUnsafeMethods.SetProfile()(ObjectPtr, _args);

                  }



                  public bool IsAwake() {

                     InternalUnsafeMethods.IsAwake__Args _args = new InternalUnsafeMethods.IsAwake__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsAwake()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetVisible(bool state = true) {

                                          InternalUnsafeMethods.SetVisible__Args _args = new InternalUnsafeMethods.SetVisible__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.SetVisible()(ObjectPtr, _args);

                  }



                  public bool IsVisible() {

                     InternalUnsafeMethods.IsVisible__Args _args = new InternalUnsafeMethods.IsVisible__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsVisible()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetActive(bool state = true) {

                                          InternalUnsafeMethods.SetActive__Args _args = new InternalUnsafeMethods.SetActive__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.SetActive()(ObjectPtr, _args);

                  }



                  public bool IsActive() {

                     InternalUnsafeMethods.IsActive__Args _args = new InternalUnsafeMethods.IsActive__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsActive()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void MakeFirstResponder(bool isFirst) {

                                          InternalUnsafeMethods.MakeFirstResponder__Args _args = new InternalUnsafeMethods.MakeFirstResponder__Args() {
                        isFirst = isFirst,
                     };
                     InternalUnsafeMethods.MakeFirstResponder()(ObjectPtr, _args);

                  }



                  public string GetValue() {

                     InternalUnsafeMethods.GetValue__Args _args = new InternalUnsafeMethods.GetValue__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetValue()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void SetValue(string value) {

                                          InternalUnsafeMethods.SetValue__Args _args = new InternalUnsafeMethods.SetValue__Args() {
                        value = value,
                     };
                     InternalUnsafeMethods.SetValue()(ObjectPtr, _args);

                  }



                  public bool IsMouseLocked() {

                     InternalUnsafeMethods.IsMouseLocked__Args _args = new InternalUnsafeMethods.IsMouseLocked__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsMouseLocked()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public GuiControl GetParent() {

                     InternalUnsafeMethods.GetParent__Args _args = new InternalUnsafeMethods.GetParent__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetParent()(ObjectPtr, _args);

                     return new GuiControl(_engineResult);
                  }



                  public GuiCanvas GetRoot() {

                     InternalUnsafeMethods.GetRoot__Args _args = new InternalUnsafeMethods.GetRoot__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetRoot()(ObjectPtr, _args);

                     return new GuiCanvas(_engineResult);
                  }



                  public void AddGuiControl(GuiControl control) {

                                          InternalUnsafeMethods.AddGuiControl__Args _args = new InternalUnsafeMethods.AddGuiControl__Args() {
                        control = control.ObjectPtr,
                     };
                     InternalUnsafeMethods.AddGuiControl()(ObjectPtr, _args);

                  }



                  public bool PointInControl(int x, int y) {

                                                               InternalUnsafeMethods.PointInControl__Args _args = new InternalUnsafeMethods.PointInControl__Args() {
                        x = x,
                        y = y,
                     };
                     bool _engineResult = InternalUnsafeMethods.PointInControl()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void ClearFirstResponder(bool ignored = false) {

                                          InternalUnsafeMethods.ClearFirstResponder__Args _args = new InternalUnsafeMethods.ClearFirstResponder__Args() {
                        ignored = ignored,
                     };
                     InternalUnsafeMethods.ClearFirstResponder()(ObjectPtr, _args);

                  }



                  public GuiControl GetFirstResponder() {

                     InternalUnsafeMethods.GetFirstResponder__Args _args = new InternalUnsafeMethods.GetFirstResponder__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetFirstResponder()(ObjectPtr, _args);

                     return new GuiControl(_engineResult);
                  }



                  public void SetFirstResponder() {

                     InternalUnsafeMethods.SetFirstResponder__Args _args = new InternalUnsafeMethods.SetFirstResponder__Args() {
                     };
                     InternalUnsafeMethods.SetFirstResponder()(ObjectPtr, _args);

                  }



                  public bool IsFirstResponder() {

                     InternalUnsafeMethods.IsFirstResponder__Args _args = new InternalUnsafeMethods.IsFirstResponder__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsFirstResponder()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool ControlIsChild(GuiControl control) {

                                          InternalUnsafeMethods.ControlIsChild__Args _args = new InternalUnsafeMethods.ControlIsChild__Args() {
                        control = control.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.ControlIsChild()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public string FindHitControls(int x, int y, int width, int height) {

                                                                                                         InternalUnsafeMethods.FindHitControls__Args _args = new InternalUnsafeMethods.FindHitControls__Args() {
                        x = x,
                        y = y,
                        width = width,
                        height = height,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.FindHitControls()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public GuiControl FindHitControl(int x, int y) {

                                                               InternalUnsafeMethods.FindHitControl__Args _args = new InternalUnsafeMethods.FindHitControl__Args() {
                        x = x,
                        y = y,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.FindHitControl()(ObjectPtr, _args);

                     return new GuiControl(_engineResult);
                  }



                  public void OnControlDropped(GuiControl control, Point2I dropPoint) {

                                          dropPoint.Alloc();                     InternalUnsafeMethods.OnControlDropped__Args _args = new InternalUnsafeMethods.OnControlDropped__Args() {
                        control = control.ObjectPtr,
                        dropPoint = dropPoint.internalStructPtr,
                     };
                     InternalUnsafeMethods.OnControlDropped()(ObjectPtr, _args);
                                                               dropPoint.Free();
                  }



                  public void OnControlDragged(GuiControl control, Point2I dropPoint) {

                                          dropPoint.Alloc();                     InternalUnsafeMethods.OnControlDragged__Args _args = new InternalUnsafeMethods.OnControlDragged__Args() {
                        control = control.ObjectPtr,
                        dropPoint = dropPoint.internalStructPtr,
                     };
                     InternalUnsafeMethods.OnControlDragged()(ObjectPtr, _args);
                                                               dropPoint.Free();
                  }



                  public void OnControlDragExit(GuiControl control, Point2I dropPoint) {

                                          dropPoint.Alloc();                     InternalUnsafeMethods.OnControlDragExit__Args _args = new InternalUnsafeMethods.OnControlDragExit__Args() {
                        control = control.ObjectPtr,
                        dropPoint = dropPoint.internalStructPtr,
                     };
                     InternalUnsafeMethods.OnControlDragExit()(ObjectPtr, _args);
                                                               dropPoint.Free();
                  }



                  public void OnControlDragEnter(GuiControl control, Point2I dropPoint) {

                                          dropPoint.Alloc();                     InternalUnsafeMethods.OnControlDragEnter__Args _args = new InternalUnsafeMethods.OnControlDragEnter__Args() {
                        control = control.ObjectPtr,
                        dropPoint = dropPoint.internalStructPtr,
                     };
                     InternalUnsafeMethods.OnControlDragEnter()(ObjectPtr, _args);
                                                               dropPoint.Free();
                  }



                  public void OnDialogPop() {

                     InternalUnsafeMethods.OnDialogPop__Args _args = new InternalUnsafeMethods.OnDialogPop__Args() {
                     };
                     InternalUnsafeMethods.OnDialogPop()(ObjectPtr, _args);

                  }



                  public void OnDialogPush() {

                     InternalUnsafeMethods.OnDialogPush__Args _args = new InternalUnsafeMethods.OnDialogPush__Args() {
                     };
                     InternalUnsafeMethods.OnDialogPush()(ObjectPtr, _args);

                  }



                  public void OnActive(bool state) {

                                          InternalUnsafeMethods.OnActive__Args _args = new InternalUnsafeMethods.OnActive__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.OnActive()(ObjectPtr, _args);

                  }



                  public void OnVisible(bool state) {

                                          InternalUnsafeMethods.OnVisible__Args _args = new InternalUnsafeMethods.OnVisible__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.OnVisible()(ObjectPtr, _args);

                  }



                  public void OnAction() {

                     InternalUnsafeMethods.OnAction__Args _args = new InternalUnsafeMethods.OnAction__Args() {
                     };
                     InternalUnsafeMethods.OnAction()(ObjectPtr, _args);

                  }



                  public void OnLoseFirstResponder() {

                     InternalUnsafeMethods.OnLoseFirstResponder__Args _args = new InternalUnsafeMethods.OnLoseFirstResponder__Args() {
                     };
                     InternalUnsafeMethods.OnLoseFirstResponder()(ObjectPtr, _args);

                  }



                  public void OnGainFirstResponder() {

                     InternalUnsafeMethods.OnGainFirstResponder__Args _args = new InternalUnsafeMethods.OnGainFirstResponder__Args() {
                     };
                     InternalUnsafeMethods.OnGainFirstResponder()(ObjectPtr, _args);

                  }



                  public void OnSleep() {

                     InternalUnsafeMethods.OnSleep__Args _args = new InternalUnsafeMethods.OnSleep__Args() {
                     };
                     InternalUnsafeMethods.OnSleep()(ObjectPtr, _args);

                  }



                  public void OnWake() {

                     InternalUnsafeMethods.OnWake__Args _args = new InternalUnsafeMethods.OnWake__Args() {
                     };
                     InternalUnsafeMethods.OnWake()(ObjectPtr, _args);

                  }



                  public void OnRemove() {

                     InternalUnsafeMethods.OnRemove__Args _args = new InternalUnsafeMethods.OnRemove__Args() {
                     };
                     InternalUnsafeMethods.OnRemove()(ObjectPtr, _args);

                  }



                  public void OnAdd() {

                     InternalUnsafeMethods.OnAdd__Args _args = new InternalUnsafeMethods.OnAdd__Args() {
                     };
                     InternalUnsafeMethods.OnAdd()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public Point2I Position {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("position"));
            set => SetFieldValue("position", GenericMarshal.ToString(value));
        }


        public Point2I Extent {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("extent"));
            set => SetFieldValue("extent", GenericMarshal.ToString(value));
        }


        public Point2I MinExtent {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("minExtent"));
            set => SetFieldValue("minExtent", GenericMarshal.ToString(value));
        }


        public GuiHorizontalSizing HorizSizing {
            get => GenericMarshal.StringTo<GuiHorizontalSizing>(GetFieldValue("horizSizing"));
            set => SetFieldValue("horizSizing", GenericMarshal.ToString(value));
        }


        public GuiVerticalSizing VertSizing {
            get => GenericMarshal.StringTo<GuiVerticalSizing>(GetFieldValue("vertSizing"));
            set => SetFieldValue("vertSizing", GenericMarshal.ToString(value));
        }


        public GuiControlProfile Profile {
            get => GenericMarshal.StringTo<GuiControlProfile>(GetFieldValue("profile"));
            set => SetFieldValue("profile", GenericMarshal.ToString(value));
        }


        public bool Visible {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("visible"));
            set => SetFieldValue("visible", GenericMarshal.ToString(value));
        }


        public bool Active {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("active"));
            set => SetFieldValue("active", GenericMarshal.ToString(value));
        }


        public string Variable {
            get => GenericMarshal.StringTo<string>(GetFieldValue("variable"));
            set => SetFieldValue("variable", GenericMarshal.ToString(value));
        }


        public string Command {
            get => GenericMarshal.StringTo<string>(GetFieldValue("command"));
            set => SetFieldValue("command", GenericMarshal.ToString(value));
        }


        public string AltCommand {
            get => GenericMarshal.StringTo<string>(GetFieldValue("altCommand"));
            set => SetFieldValue("altCommand", GenericMarshal.ToString(value));
        }


        public string Accelerator {
            get => GenericMarshal.StringTo<string>(GetFieldValue("accelerator"));
            set => SetFieldValue("accelerator", GenericMarshal.ToString(value));
        }


        public GuiControlProfile TooltipProfile {
            get => GenericMarshal.StringTo<GuiControlProfile>(GetFieldValue("tooltipProfile"));
            set => SetFieldValue("tooltipProfile", GenericMarshal.ToString(value));
        }


        public string Tooltip {
            get => GenericMarshal.StringTo<string>(GetFieldValue("tooltip"));
            set => SetFieldValue("tooltip", GenericMarshal.ToString(value));
        }


        public int Hovertime {
            get => GenericMarshal.StringTo<int>(GetFieldValue("hovertime"));
            set => SetFieldValue("hovertime", GenericMarshal.ToString(value));
        }


        public bool IsContainer {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isContainer"));
            set => SetFieldValue("isContainer", GenericMarshal.ToString(value));
        }


        public string LangTableMod {
            get => GenericMarshal.StringTo<string>(GetFieldValue("langTableMod"));
            set => SetFieldValue("langTableMod", GenericMarshal.ToString(value));
        }


    }
}
