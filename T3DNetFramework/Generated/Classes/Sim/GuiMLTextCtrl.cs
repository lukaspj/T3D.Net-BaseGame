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

    public unsafe class GuiMLTextCtrl : GuiControl {



        public GuiMLTextCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiMLTextCtrl(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiMLTextCtrl(string pName)
            : this(pName, false) {
        }

        public GuiMLTextCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiMLTextCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiMLTextCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiMLTextCtrl(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetAlpha__Args
                {

				   internal float alphaVal;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetAlpha(IntPtr _this, float alphaVal);
                internal delegate void _SetAlpha(IntPtr _this, SetAlpha__Args args);
                private static _SetAlpha _SetAlphaFunc;
                internal static _SetAlpha SetAlpha() {
                    if (_SetAlphaFunc == null) {
                        _SetAlphaFunc =
                            (_SetAlpha)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiMLTextCtrl_setAlpha"), typeof(_SetAlpha));
                    }

                    return _SetAlphaFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ForceReflow__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ForceReflow(IntPtr _this);
                internal delegate void _ForceReflow(IntPtr _this, ForceReflow__Args args);
                private static _ForceReflow _ForceReflowFunc;
                internal static _ForceReflow ForceReflow() {
                    if (_ForceReflowFunc == null) {
                        _ForceReflowFunc =
                            (_ForceReflow)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiMLTextCtrl_forceReflow"), typeof(_ForceReflow));
                    }

                    return _ForceReflowFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ScrollToBottom__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ScrollToBottom(IntPtr _this);
                internal delegate void _ScrollToBottom(IntPtr _this, ScrollToBottom__Args args);
                private static _ScrollToBottom _ScrollToBottomFunc;
                internal static _ScrollToBottom ScrollToBottom() {
                    if (_ScrollToBottomFunc == null) {
                        _ScrollToBottomFunc =
                            (_ScrollToBottom)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiMLTextCtrl_scrollToBottom"), typeof(_ScrollToBottom));
                    }

                    return _ScrollToBottomFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ScrollToTop__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ScrollToTop(IntPtr _this);
                internal delegate void _ScrollToTop(IntPtr _this, ScrollToTop__Args args);
                private static _ScrollToTop _ScrollToTopFunc;
                internal static _ScrollToTop ScrollToTop() {
                    if (_ScrollToTopFunc == null) {
                        _ScrollToTopFunc =
                            (_ScrollToTop)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiMLTextCtrl_scrollToTop"), typeof(_ScrollToTop));
                    }

                    return _ScrollToTopFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ScrollToTag__Args
                {

				   internal int tagID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ScrollToTag(IntPtr _this, int tagID);
                internal delegate void _ScrollToTag(IntPtr _this, ScrollToTag__Args args);
                private static _ScrollToTag _ScrollToTagFunc;
                internal static _ScrollToTag ScrollToTag() {
                    if (_ScrollToTagFunc == null) {
                        _ScrollToTagFunc =
                            (_ScrollToTag)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiMLTextCtrl_scrollToTag"), typeof(_ScrollToTag));
                    }

                    return _ScrollToTagFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCursorPosition__Args
                {

				   internal int newPos;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetCursorPosition(IntPtr _this, int newPos);
                internal delegate bool _SetCursorPosition(IntPtr _this, SetCursorPosition__Args args);
                private static _SetCursorPosition _SetCursorPositionFunc;
                internal static _SetCursorPosition SetCursorPosition() {
                    if (_SetCursorPositionFunc == null) {
                        _SetCursorPositionFunc =
                            (_SetCursorPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiMLTextCtrl_setCursorPosition"), typeof(_SetCursorPosition));
                    }

                    return _SetCursorPositionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct AddText__Args
                {

				   internal string text;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool reformat;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _AddText(IntPtr _this, string text, [MarshalAs(UnmanagedType.I1)]bool reformat);
                internal delegate void _AddText(IntPtr _this, AddText__Args args);
                private static _AddText _AddTextFunc;
                internal static _AddText AddText() {
                    if (_AddTextFunc == null) {
                        _AddTextFunc =
                            (_AddText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiMLTextCtrl_addText"), typeof(_AddText));
                    }

                    return _AddTextFunc;
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
                                    "fnGuiMLTextCtrl_getText"), typeof(_GetText));
                    }

                    return _GetTextFunc;
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
                                    "fnGuiMLTextCtrl_setText"), typeof(_SetText));
                    }

                    return _SetTextFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnResize__Args
                {

				   internal int width;

				   internal int maxY;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnResize(IntPtr _this, int width, int maxY);
                internal delegate void _OnResize(IntPtr _this, OnResize__Args args);
                private static _OnResize _OnResizeFunc;
                internal static _OnResize OnResize() {
                    if (_OnResizeFunc == null) {
                        _OnResizeFunc =
                            (_OnResize)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiMLTextCtrl_onResize"), typeof(_OnResize));
                    }

                    return _OnResizeFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnURL__Args
                {

				   internal string url;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnURL(IntPtr _this, string url);
                internal delegate void _OnURL(IntPtr _this, OnURL__Args args);
                private static _OnURL _OnURLFunc;
                internal static _OnURL OnURL() {
                    if (_OnURLFunc == null) {
                        _OnURLFunc =
                            (_OnURL)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiMLTextCtrl_onURL"), typeof(_OnURL));
                    }

                    return _OnURLFunc;
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
                                    "fnGuiMLTextCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiMLTextCtrl_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void SetAlpha(float alphaVal) {

                                          InternalUnsafeMethods.SetAlpha__Args _args = new InternalUnsafeMethods.SetAlpha__Args() {
                        alphaVal = alphaVal,
                     };
                     InternalUnsafeMethods.SetAlpha()(ObjectPtr, _args);

                  }



                  public void ForceReflow() {

                     InternalUnsafeMethods.ForceReflow__Args _args = new InternalUnsafeMethods.ForceReflow__Args() {
                     };
                     InternalUnsafeMethods.ForceReflow()(ObjectPtr, _args);

                  }



                  public void ScrollToBottom() {

                     InternalUnsafeMethods.ScrollToBottom__Args _args = new InternalUnsafeMethods.ScrollToBottom__Args() {
                     };
                     InternalUnsafeMethods.ScrollToBottom()(ObjectPtr, _args);

                  }



                  public void ScrollToTop() {

                     InternalUnsafeMethods.ScrollToTop__Args _args = new InternalUnsafeMethods.ScrollToTop__Args() {
                     };
                     InternalUnsafeMethods.ScrollToTop()(ObjectPtr, _args);

                  }



                  public void ScrollToTag(int tagID) {

                                          InternalUnsafeMethods.ScrollToTag__Args _args = new InternalUnsafeMethods.ScrollToTag__Args() {
                        tagID = tagID,
                     };
                     InternalUnsafeMethods.ScrollToTag()(ObjectPtr, _args);

                  }



                  public bool SetCursorPosition(int newPos) {

                                          InternalUnsafeMethods.SetCursorPosition__Args _args = new InternalUnsafeMethods.SetCursorPosition__Args() {
                        newPos = newPos,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetCursorPosition()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void AddText(string text, bool reformat = true) {

                                                               InternalUnsafeMethods.AddText__Args _args = new InternalUnsafeMethods.AddText__Args() {
                        text = text,
                        reformat = reformat,
                     };
                     InternalUnsafeMethods.AddText()(ObjectPtr, _args);

                  }



                  public string GetText() {

                     InternalUnsafeMethods.GetText__Args _args = new InternalUnsafeMethods.GetText__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetText()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void SetText(string text) {

                                          InternalUnsafeMethods.SetText__Args _args = new InternalUnsafeMethods.SetText__Args() {
                        text = text,
                     };
                     InternalUnsafeMethods.SetText()(ObjectPtr, _args);

                  }



                  public void OnResize(int width, int maxY) {

                                                               InternalUnsafeMethods.OnResize__Args _args = new InternalUnsafeMethods.OnResize__Args() {
                        width = width,
                        maxY = maxY,
                     };
                     InternalUnsafeMethods.OnResize()(ObjectPtr, _args);

                  }



                  public void OnURL(string url) {

                                          InternalUnsafeMethods.OnURL__Args _args = new InternalUnsafeMethods.OnURL__Args() {
                        url = url,
                     };
                     InternalUnsafeMethods.OnURL()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public int LineSpacing {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lineSpacing"));
            set => SetFieldValue("lineSpacing", GenericMarshal.ToString(value));
        }


        public bool AllowColorChars {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowColorChars"));
            set => SetFieldValue("allowColorChars", GenericMarshal.ToString(value));
        }


        public int MaxChars {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxChars"));
            set => SetFieldValue("maxChars", GenericMarshal.ToString(value));
        }


        public SFXTrack DeniedSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("deniedSound"));
            set => SetFieldValue("deniedSound", GenericMarshal.ToString(value));
        }


        public string Text {
            get => GenericMarshal.StringTo<string>(GetFieldValue("text"));
            set => SetFieldValue("text", GenericMarshal.ToString(value));
        }


        public bool UseURLMouseCursor {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useURLMouseCursor"));
            set => SetFieldValue("useURLMouseCursor", GenericMarshal.ToString(value));
        }


    }
}
