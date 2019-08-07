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

    public unsafe class GuiCheckBoxCtrl : GuiButtonBaseCtrl {



        public GuiCheckBoxCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiCheckBoxCtrl(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiCheckBoxCtrl(string pName)
            : this(pName, false) {
        }

        public GuiCheckBoxCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiCheckBoxCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiCheckBoxCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiCheckBoxCtrl(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsStateOn__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsStateOn(IntPtr _this);
                internal delegate bool _IsStateOn(IntPtr _this, IsStateOn__Args args);
                private static _IsStateOn _IsStateOnFunc;
                internal static _IsStateOn IsStateOn() {
                    if (_IsStateOnFunc == null) {
                        _IsStateOnFunc =
                            (_IsStateOn)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCheckBoxCtrl_isStateOn"), typeof(_IsStateOn));
                    }

                    return _IsStateOnFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetStateOn__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool newState;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetStateOn(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool newState);
                internal delegate void _SetStateOn(IntPtr _this, SetStateOn__Args args);
                private static _SetStateOn _SetStateOnFunc;
                internal static _SetStateOn SetStateOn() {
                    if (_SetStateOnFunc == null) {
                        _SetStateOnFunc =
                            (_SetStateOn)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCheckBoxCtrl_setStateOn"), typeof(_SetStateOn));
                    }

                    return _SetStateOnFunc;
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
                                    "fnGuiCheckBoxCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiCheckBoxCtrl_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public bool IsStateOn() {

                     InternalUnsafeMethods.IsStateOn__Args _args = new InternalUnsafeMethods.IsStateOn__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsStateOn()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetStateOn(bool newState) {

                                          InternalUnsafeMethods.SetStateOn__Args _args = new InternalUnsafeMethods.SetStateOn__Args() {
                        newState = newState,
                     };
                     InternalUnsafeMethods.SetStateOn()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
