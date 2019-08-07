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

    public unsafe class GuiGameListOptionsCtrl : GuiGameListMenuCtrl {



        public GuiGameListOptionsCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiGameListOptionsCtrl(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiGameListOptionsCtrl(string pName)
            : this(pName, false) {
        }

        public GuiGameListOptionsCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiGameListOptionsCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiGameListOptionsCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiGameListOptionsCtrl(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetOptions__Args
                {

				   internal int row;

				   internal string optionsList;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetOptions(IntPtr _this, int row, string optionsList);
                internal delegate void _SetOptions(IntPtr _this, SetOptions__Args args);
                private static _SetOptions _SetOptionsFunc;
                internal static _SetOptions SetOptions() {
                    if (_SetOptionsFunc == null) {
                        _SetOptionsFunc =
                            (_SetOptions)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiGameListOptionsCtrl_setOptions"), typeof(_SetOptions));
                    }

                    return _SetOptionsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SelectOption__Args
                {

				   internal int row;

				   internal string option;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SelectOption(IntPtr _this, int row, string option);
                internal delegate bool _SelectOption(IntPtr _this, SelectOption__Args args);
                private static _SelectOption _SelectOptionFunc;
                internal static _SelectOption SelectOption() {
                    if (_SelectOptionFunc == null) {
                        _SelectOptionFunc =
                            (_SelectOption)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiGameListOptionsCtrl_selectOption"), typeof(_SelectOption));
                    }

                    return _SelectOptionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetCurrentOption__Args
                {

				   internal int row;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetCurrentOption(IntPtr _this, int row);
                internal delegate IntPtr _GetCurrentOption(IntPtr _this, GetCurrentOption__Args args);
                private static _GetCurrentOption _GetCurrentOptionFunc;
                internal static _GetCurrentOption GetCurrentOption() {
                    if (_GetCurrentOptionFunc == null) {
                        _GetCurrentOptionFunc =
                            (_GetCurrentOption)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiGameListOptionsCtrl_getCurrentOption"), typeof(_GetCurrentOption));
                    }

                    return _GetCurrentOptionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct AddRow__Args
                {

				   internal string label;

				   internal string options;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool wrapOptions;

				   internal string callback;

				   internal int icon;

				   internal int yPad;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool enabled;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _AddRow(IntPtr _this, string label, string options, [MarshalAs(UnmanagedType.I1)]bool wrapOptions, string callback, int icon, int yPad, [MarshalAs(UnmanagedType.I1)]bool enabled);
                internal delegate void _AddRow(IntPtr _this, AddRow__Args args);
                private static _AddRow _AddRowFunc;
                internal static _AddRow AddRow() {
                    if (_AddRowFunc == null) {
                        _AddRowFunc =
                            (_AddRow)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiGameListOptionsCtrl_addRow"), typeof(_AddRow));
                    }

                    return _AddRowFunc;
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
                                    "fnGuiGameListOptionsCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiGameListOptionsCtrl_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void SetOptions(int row, string optionsList) {

                                                               InternalUnsafeMethods.SetOptions__Args _args = new InternalUnsafeMethods.SetOptions__Args() {
                        row = row,
                        optionsList = optionsList,
                     };
                     InternalUnsafeMethods.SetOptions()(ObjectPtr, _args);

                  }



                  public bool SelectOption(int row, string option) {

                                                               InternalUnsafeMethods.SelectOption__Args _args = new InternalUnsafeMethods.SelectOption__Args() {
                        row = row,
                        option = option,
                     };
                     bool _engineResult = InternalUnsafeMethods.SelectOption()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public string GetCurrentOption(int row) {

                                          InternalUnsafeMethods.GetCurrentOption__Args _args = new InternalUnsafeMethods.GetCurrentOption__Args() {
                        row = row,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetCurrentOption()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void AddRow(string label, string options, bool wrapOptions, string callback, int icon = -1, int yPad = 0, bool enabled = true) {

                                                                                                                                                                        InternalUnsafeMethods.AddRow__Args _args = new InternalUnsafeMethods.AddRow__Args() {
                        label = label,
                        options = options,
                        wrapOptions = wrapOptions,
                        callback = callback,
                        icon = icon,
                        yPad = yPad,
                        enabled = enabled,
                     };
                     InternalUnsafeMethods.AddRow()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
