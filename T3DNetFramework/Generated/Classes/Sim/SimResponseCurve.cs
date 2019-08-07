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

    public unsafe class SimResponseCurve : SimObject {



        public SimResponseCurve(bool pRegister = false)
            : base(pRegister) {
        }

        public SimResponseCurve(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public SimResponseCurve(string pName)
            : this(pName, false) {
        }

        public SimResponseCurve(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public SimResponseCurve(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public SimResponseCurve(SimObject pObj)
            : base(pObj) {
        }

        public SimResponseCurve(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct Clear__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Clear(IntPtr _this);
                internal delegate void _Clear(IntPtr _this, Clear__Args args);
                private static _Clear _ClearFunc;
                internal static _Clear Clear() {
                    if (_ClearFunc == null) {
                        _ClearFunc =
                            (_Clear)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimResponseCurve_clear"), typeof(_Clear));
                    }

                    return _ClearFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetValue__Args
                {

				   internal float time;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetValue(IntPtr _this, float time);
                internal delegate float _GetValue(IntPtr _this, GetValue__Args args);
                private static _GetValue _GetValueFunc;
                internal static _GetValue GetValue() {
                    if (_GetValueFunc == null) {
                        _GetValueFunc =
                            (_GetValue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimResponseCurve_getValue"), typeof(_GetValue));
                    }

                    return _GetValueFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct AddPoint__Args
                {

				   internal float value;

				   internal float time;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _AddPoint(IntPtr _this, float value, float time);
                internal delegate void _AddPoint(IntPtr _this, AddPoint__Args args);
                private static _AddPoint _AddPointFunc;
                internal static _AddPoint AddPoint() {
                    if (_AddPointFunc == null) {
                        _AddPointFunc =
                            (_AddPoint)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimResponseCurve_addPoint"), typeof(_AddPoint));
                    }

                    return _AddPointFunc;
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
                                    "fnSimResponseCurve_staticGetType"), typeof(_StaticGetType));
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
                                    "fnSimResponseCurve_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void Clear() {

                     InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
                     };
                     InternalUnsafeMethods.Clear()(ObjectPtr, _args);

                  }



                  public float GetValue(float time) {

                                          InternalUnsafeMethods.GetValue__Args _args = new InternalUnsafeMethods.GetValue__Args() {
                        time = time,
                     };
                     float _engineResult = InternalUnsafeMethods.GetValue()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void AddPoint(float value, float time) {

                                                               InternalUnsafeMethods.AddPoint__Args _args = new InternalUnsafeMethods.AddPoint__Args() {
                        value = value,
                        time = time,
                     };
                     InternalUnsafeMethods.AddPoint()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
