using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class GuiButtonBaseCtrl : GuiControl {



        public GuiButtonBaseCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiButtonBaseCtrl(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiButtonBaseCtrl(string pName)
            : this(pName, false) {
        }

        public GuiButtonBaseCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiButtonBaseCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiButtonBaseCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiButtonBaseCtrl(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct ResetState__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ResetState(IntPtr _this);
                internal delegate void _ResetState(IntPtr _this, ResetState__Args args);
                private static _ResetState _ResetStateFunc;
                internal static _ResetState ResetState() {
                    if (_ResetStateFunc == null) {
                        _ResetStateFunc =
                            (_ResetState)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiButtonBaseCtrl_resetState"), typeof(_ResetState));
                    }

                    return _ResetStateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetStateOn__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool isOn;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetStateOn(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool isOn);
                internal delegate void _SetStateOn(IntPtr _this, SetStateOn__Args args);
                private static _SetStateOn _SetStateOnFunc;
                internal static _SetStateOn SetStateOn() {
                    if (_SetStateOnFunc == null) {
                        _SetStateOnFunc =
                            (_SetStateOn)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiButtonBaseCtrl_setStateOn"), typeof(_SetStateOn));
                    }

                    return _SetStateOnFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetText__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetText(IntPtr _this);
                internal delegate IntPtr _GetText(IntPtr _this, GetText__Args args);
                private static _GetText _GetTextFunc;
                internal static _GetText GetText() {
                    if (_GetTextFunc == null) {
                        _GetTextFunc =
                            (_GetText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiButtonBaseCtrl_getText"), typeof(_GetText));
                    }

                    return _GetTextFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetTextID__Args
                {

				   internal string id;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetTextID(IntPtr _this, string id);
                internal delegate void _SetTextID(IntPtr _this, SetTextID__Args args);
                private static _SetTextID _SetTextIDFunc;
                internal static _SetTextID SetTextID() {
                    if (_SetTextIDFunc == null) {
                        _SetTextIDFunc =
                            (_SetTextID)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiButtonBaseCtrl_setTextID"), typeof(_SetTextID));
                    }

                    return _SetTextIDFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetText__Args
                {

				   internal string text;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetText(IntPtr _this, string text);
                internal delegate void _SetText(IntPtr _this, SetText__Args args);
                private static _SetText _SetTextFunc;
                internal static _SetText SetText() {
                    if (_SetTextFunc == null) {
                        _SetTextFunc =
                            (_SetText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiButtonBaseCtrl_setText"), typeof(_SetText));
                    }

                    return _SetTextFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct PerformClick__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _PerformClick(IntPtr _this);
                internal delegate void _PerformClick(IntPtr _this, PerformClick__Args args);
                private static _PerformClick _PerformClickFunc;
                internal static _PerformClick PerformClick() {
                    if (_PerformClickFunc == null) {
                        _PerformClickFunc =
                            (_PerformClick)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiButtonBaseCtrl_performClick"), typeof(_PerformClick));
                    }

                    return _PerformClickFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnMouseDragged__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnMouseDragged(IntPtr _this);
                internal delegate void _OnMouseDragged(IntPtr _this, OnMouseDragged__Args args);
                private static _OnMouseDragged _OnMouseDraggedFunc;
                internal static _OnMouseDragged OnMouseDragged() {
                    if (_OnMouseDraggedFunc == null) {
                        _OnMouseDraggedFunc =
                            (_OnMouseDragged)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiButtonBaseCtrl_onMouseDragged"), typeof(_OnMouseDragged));
                    }

                    return _OnMouseDraggedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnMouseLeave__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnMouseLeave(IntPtr _this);
                internal delegate void _OnMouseLeave(IntPtr _this, OnMouseLeave__Args args);
                private static _OnMouseLeave _OnMouseLeaveFunc;
                internal static _OnMouseLeave OnMouseLeave() {
                    if (_OnMouseLeaveFunc == null) {
                        _OnMouseLeaveFunc =
                            (_OnMouseLeave)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiButtonBaseCtrl_onMouseLeave"), typeof(_OnMouseLeave));
                    }

                    return _OnMouseLeaveFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnMouseEnter__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnMouseEnter(IntPtr _this);
                internal delegate void _OnMouseEnter(IntPtr _this, OnMouseEnter__Args args);
                private static _OnMouseEnter _OnMouseEnterFunc;
                internal static _OnMouseEnter OnMouseEnter() {
                    if (_OnMouseEnterFunc == null) {
                        _OnMouseEnterFunc =
                            (_OnMouseEnter)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiButtonBaseCtrl_onMouseEnter"), typeof(_OnMouseEnter));
                    }

                    return _OnMouseEnterFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnRightClick__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnRightClick(IntPtr _this);
                internal delegate void _OnRightClick(IntPtr _this, OnRightClick__Args args);
                private static _OnRightClick _OnRightClickFunc;
                internal static _OnRightClick OnRightClick() {
                    if (_OnRightClickFunc == null) {
                        _OnRightClickFunc =
                            (_OnRightClick)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiButtonBaseCtrl_onRightClick"), typeof(_OnRightClick));
                    }

                    return _OnRightClickFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDoubleClick__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnDoubleClick(IntPtr _this);
                internal delegate void _OnDoubleClick(IntPtr _this, OnDoubleClick__Args args);
                private static _OnDoubleClick _OnDoubleClickFunc;
                internal static _OnDoubleClick OnDoubleClick() {
                    if (_OnDoubleClickFunc == null) {
                        _OnDoubleClickFunc =
                            (_OnDoubleClick)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiButtonBaseCtrl_onDoubleClick"), typeof(_OnDoubleClick));
                    }

                    return _OnDoubleClickFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnClick__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnClick(IntPtr _this);
                internal delegate void _OnClick(IntPtr _this, OnClick__Args args);
                private static _OnClick _OnClickFunc;
                internal static _OnClick OnClick() {
                    if (_OnClickFunc == null) {
                        _OnClickFunc =
                            (_OnClick)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiButtonBaseCtrl_onClick"), typeof(_OnClick));
                    }

                    return _OnClickFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnMouseUp__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnMouseUp(IntPtr _this);
                internal delegate void _OnMouseUp(IntPtr _this, OnMouseUp__Args args);
                private static _OnMouseUp _OnMouseUpFunc;
                internal static _OnMouseUp OnMouseUp() {
                    if (_OnMouseUpFunc == null) {
                        _OnMouseUpFunc =
                            (_OnMouseUp)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiButtonBaseCtrl_onMouseUp"), typeof(_OnMouseUp));
                    }

                    return _OnMouseUpFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnMouseDown__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnMouseDown(IntPtr _this);
                internal delegate void _OnMouseDown(IntPtr _this, OnMouseDown__Args args);
                private static _OnMouseDown _OnMouseDownFunc;
                internal static _OnMouseDown OnMouseDown() {
                    if (_OnMouseDownFunc == null) {
                        _OnMouseDownFunc =
                            (_OnMouseDown)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiButtonBaseCtrl_onMouseDown"), typeof(_OnMouseDown));
                    }

                    return _OnMouseDownFunc;
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
                                    "fnGuiButtonBaseCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiButtonBaseCtrl_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void ResetState() {

                     InternalUnsafeMethods.ResetState__Args _args = new InternalUnsafeMethods.ResetState__Args() {
                     };
                     InternalUnsafeMethods.ResetState()(ObjectPtr, _args);

                  }



                  public void SetStateOn(bool isOn = true) {

                                          InternalUnsafeMethods.SetStateOn__Args _args = new InternalUnsafeMethods.SetStateOn__Args() {
                        isOn = isOn,
                     };
                     InternalUnsafeMethods.SetStateOn()(ObjectPtr, _args);

                  }



                  public string GetText() {

                     InternalUnsafeMethods.GetText__Args _args = new InternalUnsafeMethods.GetText__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetText()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void SetTextID(string id) {

                                          InternalUnsafeMethods.SetTextID__Args _args = new InternalUnsafeMethods.SetTextID__Args() {
                        id = id,
                     };
                     InternalUnsafeMethods.SetTextID()(ObjectPtr, _args);

                  }



                  public void SetText(string text) {

                                          InternalUnsafeMethods.SetText__Args _args = new InternalUnsafeMethods.SetText__Args() {
                        text = text,
                     };
                     InternalUnsafeMethods.SetText()(ObjectPtr, _args);

                  }



                  public void PerformClick() {

                     InternalUnsafeMethods.PerformClick__Args _args = new InternalUnsafeMethods.PerformClick__Args() {
                     };
                     InternalUnsafeMethods.PerformClick()(ObjectPtr, _args);

                  }



                  public void OnMouseDragged() {

                     InternalUnsafeMethods.OnMouseDragged__Args _args = new InternalUnsafeMethods.OnMouseDragged__Args() {
                     };
                     InternalUnsafeMethods.OnMouseDragged()(ObjectPtr, _args);

                  }



                  public void OnMouseLeave() {

                     InternalUnsafeMethods.OnMouseLeave__Args _args = new InternalUnsafeMethods.OnMouseLeave__Args() {
                     };
                     InternalUnsafeMethods.OnMouseLeave()(ObjectPtr, _args);

                  }



                  public void OnMouseEnter() {

                     InternalUnsafeMethods.OnMouseEnter__Args _args = new InternalUnsafeMethods.OnMouseEnter__Args() {
                     };
                     InternalUnsafeMethods.OnMouseEnter()(ObjectPtr, _args);

                  }



                  public void OnRightClick() {

                     InternalUnsafeMethods.OnRightClick__Args _args = new InternalUnsafeMethods.OnRightClick__Args() {
                     };
                     InternalUnsafeMethods.OnRightClick()(ObjectPtr, _args);

                  }



                  public void OnDoubleClick() {

                     InternalUnsafeMethods.OnDoubleClick__Args _args = new InternalUnsafeMethods.OnDoubleClick__Args() {
                     };
                     InternalUnsafeMethods.OnDoubleClick()(ObjectPtr, _args);

                  }



                  public void OnClick() {

                     InternalUnsafeMethods.OnClick__Args _args = new InternalUnsafeMethods.OnClick__Args() {
                     };
                     InternalUnsafeMethods.OnClick()(ObjectPtr, _args);

                  }



                  public void OnMouseUp() {

                     InternalUnsafeMethods.OnMouseUp__Args _args = new InternalUnsafeMethods.OnMouseUp__Args() {
                     };
                     InternalUnsafeMethods.OnMouseUp()(ObjectPtr, _args);

                  }



                  public void OnMouseDown() {

                     InternalUnsafeMethods.OnMouseDown__Args _args = new InternalUnsafeMethods.OnMouseDown__Args() {
                     };
                     InternalUnsafeMethods.OnMouseDown()(ObjectPtr, _args);

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


        public string TextID {
            get => GenericMarshal.StringTo<string>(GetFieldValue("textID"));
            set => SetFieldValue("textID", GenericMarshal.ToString(value));
        }


        public int GroupNum {
            get => GenericMarshal.StringTo<int>(GetFieldValue("groupNum"));
            set => SetFieldValue("groupNum", GenericMarshal.ToString(value));
        }


        public GuiButtonType ButtonType {
            get => GenericMarshal.StringTo<GuiButtonType>(GetFieldValue("buttonType"));
            set => SetFieldValue("buttonType", GenericMarshal.ToString(value));
        }


        public bool UseMouseEvents {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useMouseEvents"));
            set => SetFieldValue("useMouseEvents", GenericMarshal.ToString(value));
        }


    }
}
