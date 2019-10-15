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
    public unsafe class GuiTextEditCtrl : GuiTextCtrl {
        public GuiTextEditCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiTextEditCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiTextEditCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiTextEditCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiTextEditCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiTextEditCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiTextEditCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct IsValidText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsValidText(IntPtr _this, IsValidText__Args args);
            private static _IsValidText _IsValidTextFunc;
            internal static _IsValidText IsValidText() {
                if (_IsValidTextFunc == null) {
                    _IsValidTextFunc =
                        (_IsValidText)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextEditCtrl_isValidText"), typeof(_IsValidText));
                }
                
                return _IsValidTextFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ValidText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ValidText(IntPtr _this, ValidText__Args args);
            private static _ValidText _ValidTextFunc;
            internal static _ValidText ValidText() {
                if (_ValidTextFunc == null) {
                    _ValidTextFunc =
                        (_ValidText)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextEditCtrl_validText"), typeof(_ValidText));
                }
                
                return _ValidTextFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct InvalidText__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool playSound;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _InvalidText(IntPtr _this, InvalidText__Args args);
            private static _InvalidText _InvalidTextFunc;
            internal static _InvalidText InvalidText() {
                if (_InvalidTextFunc == null) {
                    _InvalidTextFunc =
                        (_InvalidText)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextEditCtrl_invalidText"), typeof(_InvalidText));
                }
                
                return _InvalidTextFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ForceValidateText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ForceValidateText(IntPtr _this, ForceValidateText__Args args);
            private static _ForceValidateText _ForceValidateTextFunc;
            internal static _ForceValidateText ForceValidateText() {
                if (_ForceValidateTextFunc == null) {
                    _ForceValidateTextFunc =
                        (_ForceValidateText)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextEditCtrl_forceValidateText"), typeof(_ForceValidateText));
                }
                
                return _ForceValidateTextFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearSelectedText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearSelectedText(IntPtr _this, ClearSelectedText__Args args);
            private static _ClearSelectedText _ClearSelectedTextFunc;
            internal static _ClearSelectedText ClearSelectedText() {
                if (_ClearSelectedTextFunc == null) {
                    _ClearSelectedTextFunc =
                        (_ClearSelectedText)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextEditCtrl_clearSelectedText"), typeof(_ClearSelectedText));
                }
                
                return _ClearSelectedTextFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectAllText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SelectAllText(IntPtr _this, SelectAllText__Args args);
            private static _SelectAllText _SelectAllTextFunc;
            internal static _SelectAllText SelectAllText() {
                if (_SelectAllTextFunc == null) {
                    _SelectAllTextFunc =
                        (_SelectAllText)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextEditCtrl_selectAllText"), typeof(_SelectAllText));
                }
                
                return _SelectAllTextFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsAllTextSelected__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsAllTextSelected(IntPtr _this, IsAllTextSelected__Args args);
            private static _IsAllTextSelected _IsAllTextSelectedFunc;
            internal static _IsAllTextSelected IsAllTextSelected() {
                if (_IsAllTextSelectedFunc == null) {
                    _IsAllTextSelectedFunc =
                        (_IsAllTextSelected)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextEditCtrl_isAllTextSelected"), typeof(_IsAllTextSelected));
                }
                
                return _IsAllTextSelectedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCursorPos__Args
            {
                internal int position;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCursorPos(IntPtr _this, SetCursorPos__Args args);
            private static _SetCursorPos _SetCursorPosFunc;
            internal static _SetCursorPos SetCursorPos() {
                if (_SetCursorPosFunc == null) {
                    _SetCursorPosFunc =
                        (_SetCursorPos)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextEditCtrl_setCursorPos"), typeof(_SetCursorPos));
                }
                
                return _SetCursorPosFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCursorPos__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetCursorPos(IntPtr _this, GetCursorPos__Args args);
            private static _GetCursorPos _GetCursorPosFunc;
            internal static _GetCursorPos GetCursorPos() {
                if (_GetCursorPosFunc == null) {
                    _GetCursorPosFunc =
                        (_GetCursorPos)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextEditCtrl_getCursorPos"), typeof(_GetCursorPos));
                }
                
                return _GetCursorPosFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetText__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string text;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetText(IntPtr _this, SetText__Args args);
            private static _SetText _SetTextFunc;
            internal static _SetText SetText() {
                if (_SetTextFunc == null) {
                    _SetTextFunc =
                        (_SetText)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextEditCtrl_setText"), typeof(_SetText));
                }
                
                return _SetTextFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetText(IntPtr _this, GetText__Args args);
            private static _GetText _GetTextFunc;
            internal static _GetText GetText() {
                if (_GetTextFunc == null) {
                    _GetTextFunc =
                        (_GetText)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextEditCtrl_getText"), typeof(_GetText));
                }
                
                return _GetTextFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnValidate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnValidate(IntPtr _this, OnValidate__Args args);
            private static _OnValidate _OnValidateFunc;
            internal static _OnValidate OnValidate() {
                if (_OnValidateFunc == null) {
                    _OnValidateFunc =
                        (_OnValidate)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiTextEditCtrl_onValidate"), typeof(_OnValidate));
                }
                
                return _OnValidateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnReturn__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnReturn(IntPtr _this, OnReturn__Args args);
            private static _OnReturn _OnReturnFunc;
            internal static _OnReturn OnReturn() {
                if (_OnReturnFunc == null) {
                    _OnReturnFunc =
                        (_OnReturn)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiTextEditCtrl_onReturn"), typeof(_OnReturn));
                }
                
                return _OnReturnFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnTabComplete__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string val;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnTabComplete(IntPtr _this, OnTabComplete__Args args);
            private static _OnTabComplete _OnTabCompleteFunc;
            internal static _OnTabComplete OnTabComplete() {
                if (_OnTabCompleteFunc == null) {
                    _OnTabCompleteFunc =
                        (_OnTabComplete)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiTextEditCtrl_onTabComplete"), typeof(_OnTabComplete));
                }
                
                return _OnTabCompleteFunc;
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
                                "fnGuiTextEditCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiTextEditCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public bool IsValidText() {
             InternalUnsafeMethods.IsValidText__Args _args = new InternalUnsafeMethods.IsValidText__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsValidText()(ObjectPtr, _args);
             return _engineResult;
        }

        public void ValidText() {
             InternalUnsafeMethods.ValidText__Args _args = new InternalUnsafeMethods.ValidText__Args() {
             };
             InternalUnsafeMethods.ValidText()(ObjectPtr, _args);
        }

        public void InvalidText(bool playSound = true) {
             InternalUnsafeMethods.InvalidText__Args _args = new InternalUnsafeMethods.InvalidText__Args() {
                playSound = playSound,
             };
             InternalUnsafeMethods.InvalidText()(ObjectPtr, _args);
        }

        public void ForceValidateText() {
             InternalUnsafeMethods.ForceValidateText__Args _args = new InternalUnsafeMethods.ForceValidateText__Args() {
             };
             InternalUnsafeMethods.ForceValidateText()(ObjectPtr, _args);
        }

        public void ClearSelectedText() {
             InternalUnsafeMethods.ClearSelectedText__Args _args = new InternalUnsafeMethods.ClearSelectedText__Args() {
             };
             InternalUnsafeMethods.ClearSelectedText()(ObjectPtr, _args);
        }

        public void SelectAllText() {
             InternalUnsafeMethods.SelectAllText__Args _args = new InternalUnsafeMethods.SelectAllText__Args() {
             };
             InternalUnsafeMethods.SelectAllText()(ObjectPtr, _args);
        }

        public bool IsAllTextSelected() {
             InternalUnsafeMethods.IsAllTextSelected__Args _args = new InternalUnsafeMethods.IsAllTextSelected__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsAllTextSelected()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetCursorPos(int position) {
             InternalUnsafeMethods.SetCursorPos__Args _args = new InternalUnsafeMethods.SetCursorPos__Args() {
                position = position,
             };
             InternalUnsafeMethods.SetCursorPos()(ObjectPtr, _args);
        }

        public int GetCursorPos() {
             InternalUnsafeMethods.GetCursorPos__Args _args = new InternalUnsafeMethods.GetCursorPos__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetCursorPos()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetText(string text) {
             InternalUnsafeMethods.SetText__Args _args = new InternalUnsafeMethods.SetText__Args() {
                text = text,
             };
             InternalUnsafeMethods.SetText()(ObjectPtr, _args);
        }

        public string GetText() {
             InternalUnsafeMethods.GetText__Args _args = new InternalUnsafeMethods.GetText__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetText()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public virtual void OnValidate() {
             InternalUnsafeMethods.OnValidate__Args _args = new InternalUnsafeMethods.OnValidate__Args() {
             };
             InternalUnsafeMethods.OnValidate()(ObjectPtr, _args);
        }

        public virtual void OnReturn() {
             InternalUnsafeMethods.OnReturn__Args _args = new InternalUnsafeMethods.OnReturn__Args() {
             };
             InternalUnsafeMethods.OnReturn()(ObjectPtr, _args);
        }

        public virtual void OnTabComplete(string val) {
             InternalUnsafeMethods.OnTabComplete__Args _args = new InternalUnsafeMethods.OnTabComplete__Args() {
                val = val,
             };
             InternalUnsafeMethods.OnTabComplete()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string Validate {
            get => GenericMarshal.StringTo<string>(GetFieldValue("validate"));
            set => SetFieldValue("validate", GenericMarshal.ToString(value));
        }

        public string EscapeCommand {
            get => GenericMarshal.StringTo<string>(GetFieldValue("escapeCommand"));
            set => SetFieldValue("escapeCommand", GenericMarshal.ToString(value));
        }

        public int HistorySize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("historySize"));
            set => SetFieldValue("historySize", GenericMarshal.ToString(value));
        }

        public bool TabComplete {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("tabComplete"));
            set => SetFieldValue("tabComplete", GenericMarshal.ToString(value));
        }

        public SFXTrack DeniedSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("deniedSound"));
            set => SetFieldValue("deniedSound", GenericMarshal.ToString(value));
        }

        public bool SinkAllKeyEvents {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("sinkAllKeyEvents"));
            set => SetFieldValue("sinkAllKeyEvents", GenericMarshal.ToString(value));
        }

        public bool Password {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("password"));
            set => SetFieldValue("password", GenericMarshal.ToString(value));
        }

        public string PasswordMask {
            get => GenericMarshal.StringTo<string>(GetFieldValue("passwordMask"));
            set => SetFieldValue("passwordMask", GenericMarshal.ToString(value));
        }
    }
}