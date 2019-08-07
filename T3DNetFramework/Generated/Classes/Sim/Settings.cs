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

    public unsafe class Settings : SimObject {



        public Settings(bool pRegister = false)
            : base(pRegister) {
        }

        public Settings(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public Settings(string pName)
            : this(pName, false) {
        }

        public Settings(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Settings(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Settings(SimObject pObj)
            : base(pObj) {
        }

        public Settings(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetCurrentGroups__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetCurrentGroups(IntPtr _this);
                internal delegate IntPtr _GetCurrentGroups(IntPtr _this, GetCurrentGroups__Args args);
                private static _GetCurrentGroups _GetCurrentGroupsFunc;
                internal static _GetCurrentGroups GetCurrentGroups() {
                    if (_GetCurrentGroupsFunc == null) {
                        _GetCurrentGroupsFunc =
                            (_GetCurrentGroups)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSettings_getCurrentGroups"), typeof(_GetCurrentGroups));
                    }

                    return _GetCurrentGroupsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearGroups__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ClearGroups(IntPtr _this);
                internal delegate void _ClearGroups(IntPtr _this, ClearGroups__Args args);
                private static _ClearGroups _ClearGroupsFunc;
                internal static _ClearGroups ClearGroups() {
                    if (_ClearGroupsFunc == null) {
                        _ClearGroupsFunc =
                            (_ClearGroups)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSettings_clearGroups"), typeof(_ClearGroups));
                    }

                    return _ClearGroupsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct EndGroup__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _EndGroup(IntPtr _this);
                internal delegate void _EndGroup(IntPtr _this, EndGroup__Args args);
                private static _EndGroup _EndGroupFunc;
                internal static _EndGroup EndGroup() {
                    if (_EndGroupFunc == null) {
                        _EndGroupFunc =
                            (_EndGroup)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSettings_endGroup"), typeof(_EndGroup));
                    }

                    return _EndGroupFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct BeginGroup__Args
                {

				   internal string groupName;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool includeDefaults;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _BeginGroup(IntPtr _this, string groupName, [MarshalAs(UnmanagedType.I1)]bool includeDefaults);
                internal delegate void _BeginGroup(IntPtr _this, BeginGroup__Args args);
                private static _BeginGroup _BeginGroupFunc;
                internal static _BeginGroup BeginGroup() {
                    if (_BeginGroupFunc == null) {
                        _BeginGroupFunc =
                            (_BeginGroup)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSettings_beginGroup"), typeof(_BeginGroup));
                    }

                    return _BeginGroupFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Read__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _Read(IntPtr _this);
                internal delegate bool _Read(IntPtr _this, Read__Args args);
                private static _Read _ReadFunc;
                internal static _Read Read() {
                    if (_ReadFunc == null) {
                        _ReadFunc =
                            (_Read)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSettings_read"), typeof(_Read));
                    }

                    return _ReadFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Write__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _Write(IntPtr _this);
                internal delegate bool _Write(IntPtr _this, Write__Args args);
                private static _Write _WriteFunc;
                internal static _Write Write() {
                    if (_WriteFunc == null) {
                        _WriteFunc =
                            (_Write)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSettings_write"), typeof(_Write));
                    }

                    return _WriteFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Remove__Args
                {

				   internal string settingName;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool includeDefaults;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Remove(IntPtr _this, string settingName, [MarshalAs(UnmanagedType.I1)]bool includeDefaults);
                internal delegate void _Remove(IntPtr _this, Remove__Args args);
                private static _Remove _RemoveFunc;
                internal static _Remove Remove() {
                    if (_RemoveFunc == null) {
                        _RemoveFunc =
                            (_Remove)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSettings_remove"), typeof(_Remove));
                    }

                    return _RemoveFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Value__Args
                {

				   internal string settingName;

				   internal string defaultValue;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _Value(IntPtr _this, string settingName, string defaultValue);
                internal delegate IntPtr _Value(IntPtr _this, Value__Args args);
                private static _Value _ValueFunc;
                internal static _Value Value() {
                    if (_ValueFunc == null) {
                        _ValueFunc =
                            (_Value)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSettings_value"), typeof(_Value));
                    }

                    return _ValueFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetDefaultValue__Args
                {

				   internal string settingName;

				   internal string value;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetDefaultValue(IntPtr _this, string settingName, string value);
                internal delegate void _SetDefaultValue(IntPtr _this, SetDefaultValue__Args args);
                private static _SetDefaultValue _SetDefaultValueFunc;
                internal static _SetDefaultValue SetDefaultValue() {
                    if (_SetDefaultValueFunc == null) {
                        _SetDefaultValueFunc =
                            (_SetDefaultValue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSettings_setDefaultValue"), typeof(_SetDefaultValue));
                    }

                    return _SetDefaultValueFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetValue__Args
                {

				   internal string settingName;

				   internal string value;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetValue(IntPtr _this, string settingName, string value);
                internal delegate void _SetValue(IntPtr _this, SetValue__Args args);
                private static _SetValue _SetValueFunc;
                internal static _SetValue SetValue() {
                    if (_SetValueFunc == null) {
                        _SetValueFunc =
                            (_SetValue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSettings_setValue"), typeof(_SetValue));
                    }

                    return _SetValueFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct FindNextValue__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _FindNextValue(IntPtr _this);
                internal delegate IntPtr _FindNextValue(IntPtr _this, FindNextValue__Args args);
                private static _FindNextValue _FindNextValueFunc;
                internal static _FindNextValue FindNextValue() {
                    if (_FindNextValueFunc == null) {
                        _FindNextValueFunc =
                            (_FindNextValue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSettings_findNextValue"), typeof(_FindNextValue));
                    }

                    return _FindNextValueFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct FindFirstValue__Args
                {

				   internal string pattern;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool deepSearch;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool includeDefaults;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _FindFirstValue(IntPtr _this, string pattern, [MarshalAs(UnmanagedType.I1)]bool deepSearch, [MarshalAs(UnmanagedType.I1)]bool includeDefaults);
                internal delegate IntPtr _FindFirstValue(IntPtr _this, FindFirstValue__Args args);
                private static _FindFirstValue _FindFirstValueFunc;
                internal static _FindFirstValue FindFirstValue() {
                    if (_FindFirstValueFunc == null) {
                        _FindFirstValueFunc =
                            (_FindFirstValue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSettings_findFirstValue"), typeof(_FindFirstValue));
                    }

                    return _FindFirstValueFunc;
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
                                    "fnSettings_staticGetType"), typeof(_StaticGetType));
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
                                    "fnSettings_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public string GetCurrentGroups() {

                     InternalUnsafeMethods.GetCurrentGroups__Args _args = new InternalUnsafeMethods.GetCurrentGroups__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetCurrentGroups()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void ClearGroups() {

                     InternalUnsafeMethods.ClearGroups__Args _args = new InternalUnsafeMethods.ClearGroups__Args() {
                     };
                     InternalUnsafeMethods.ClearGroups()(ObjectPtr, _args);

                  }



                  public void EndGroup() {

                     InternalUnsafeMethods.EndGroup__Args _args = new InternalUnsafeMethods.EndGroup__Args() {
                     };
                     InternalUnsafeMethods.EndGroup()(ObjectPtr, _args);

                  }



                  public void BeginGroup(string groupName, bool includeDefaults = false) {

                                                               InternalUnsafeMethods.BeginGroup__Args _args = new InternalUnsafeMethods.BeginGroup__Args() {
                        groupName = groupName,
                        includeDefaults = includeDefaults,
                     };
                     InternalUnsafeMethods.BeginGroup()(ObjectPtr, _args);

                  }



                  public bool Read() {

                     InternalUnsafeMethods.Read__Args _args = new InternalUnsafeMethods.Read__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.Read()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool Write() {

                     InternalUnsafeMethods.Write__Args _args = new InternalUnsafeMethods.Write__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.Write()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void Remove(string settingName, bool includeDefaults = false) {

                                                               InternalUnsafeMethods.Remove__Args _args = new InternalUnsafeMethods.Remove__Args() {
                        settingName = settingName,
                        includeDefaults = includeDefaults,
                     };
                     InternalUnsafeMethods.Remove()(ObjectPtr, _args);

                  }



                  public string Value(string settingName, string defaultValue = "") {

                                                               InternalUnsafeMethods.Value__Args _args = new InternalUnsafeMethods.Value__Args() {
                        settingName = settingName,
                        defaultValue = defaultValue,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.Value()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void SetDefaultValue(string settingName, string value) {

                                                               InternalUnsafeMethods.SetDefaultValue__Args _args = new InternalUnsafeMethods.SetDefaultValue__Args() {
                        settingName = settingName,
                        value = value,
                     };
                     InternalUnsafeMethods.SetDefaultValue()(ObjectPtr, _args);

                  }



                  public void SetValue(string settingName, string value = "") {

                                                               InternalUnsafeMethods.SetValue__Args _args = new InternalUnsafeMethods.SetValue__Args() {
                        settingName = settingName,
                        value = value,
                     };
                     InternalUnsafeMethods.SetValue()(ObjectPtr, _args);

                  }



                  public string FindNextValue() {

                     InternalUnsafeMethods.FindNextValue__Args _args = new InternalUnsafeMethods.FindNextValue__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.FindNextValue()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public string FindFirstValue(string pattern = "", bool deepSearch = false, bool includeDefaults = false) {

                                                                                    InternalUnsafeMethods.FindFirstValue__Args _args = new InternalUnsafeMethods.FindFirstValue__Args() {
                        pattern = pattern,
                        deepSearch = deepSearch,
                        includeDefaults = includeDefaults,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.FindFirstValue()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public string File {
            get => GenericMarshal.StringTo<string>(GetFieldValue("file"));
            set => SetFieldValue("file", GenericMarshal.ToString(value));
        }


    }
}
