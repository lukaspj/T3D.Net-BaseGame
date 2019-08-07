using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Global {

    public unsafe class EngineObject : ConsoleObjectBase {



        public EngineObject(bool pRegister = false)
            : base(pRegister) {
        }

        public EngineObject(ConsoleObjectBase pObj)
            : base(pObj) {
        }

        public EngineObject(IntPtr pObj)
            : base(pObj) {
        }






        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetUserData__Args
                {

				   internal IntPtr ptr;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetUserData(IntPtr _this, IntPtr ptr);
                internal delegate void _SetUserData(IntPtr _this, SetUserData__Args args);
                private static _SetUserData _SetUserDataFunc;
                internal static _SetUserData SetUserData() {
                    if (_SetUserDataFunc == null) {
                        _SetUserDataFunc =
                            (_SetUserData)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEngineObject_setUserData"), typeof(_SetUserData));
                    }

                    return _SetUserDataFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetUserData__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetUserData(IntPtr _this);
                internal delegate IntPtr _GetUserData(IntPtr _this, GetUserData__Args args);
                private static _GetUserData _GetUserDataFunc;
                internal static _GetUserData GetUserData() {
                    if (_GetUserDataFunc == null) {
                        _GetUserDataFunc =
                            (_GetUserData)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEngineObject_getUserData"), typeof(_GetUserData));
                    }

                    return _GetUserDataFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Release__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Release(IntPtr _this);
                internal delegate void _Release(IntPtr _this, Release__Args args);
                private static _Release _ReleaseFunc;
                internal static _Release Release() {
                    if (_ReleaseFunc == null) {
                        _ReleaseFunc =
                            (_Release)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEngineObject_release"), typeof(_Release));
                    }

                    return _ReleaseFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct AddRef__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _AddRef(IntPtr _this);
                internal delegate void _AddRef(IntPtr _this, AddRef__Args args);
                private static _AddRef _AddRefFunc;
                internal static _AddRef AddRef() {
                    if (_AddRefFunc == null) {
                        _AddRefFunc =
                            (_AddRef)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEngineObject_addRef"), typeof(_AddRef));
                    }

                    return _AddRefFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetType__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetType(IntPtr _this);
                internal delegate IntPtr _GetType(IntPtr _this, GetType__Args args);
                private static _GetType _GetTypeFunc;
                internal static _GetType GetType() {
                    if (_GetTypeFunc == null) {
                        _GetTypeFunc =
                            (_GetType)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEngineObject_getType"), typeof(_GetType));
                    }

                    return _GetTypeFunc;
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
                                    "fnEngineObject_staticGetType"), typeof(_StaticGetType));
                    }

                    return _StaticGetTypeFunc;
                }

        }
        #endregion



                  public void SetUserData(IntPtr ptr) {

                                          InternalUnsafeMethods.SetUserData__Args _args = new InternalUnsafeMethods.SetUserData__Args() {
                        ptr = ptr,
                     };
                     InternalUnsafeMethods.SetUserData()(ObjectPtr, _args);

                  }



                  public IntPtr GetUserData() {

                     InternalUnsafeMethods.GetUserData__Args _args = new InternalUnsafeMethods.GetUserData__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetUserData()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void Release() {

                     InternalUnsafeMethods.Release__Args _args = new InternalUnsafeMethods.Release__Args() {
                     };
                     InternalUnsafeMethods.Release()(ObjectPtr, _args);

                  }



                  public void AddRef() {

                     InternalUnsafeMethods.AddRef__Args _args = new InternalUnsafeMethods.AddRef__Args() {
                     };
                     InternalUnsafeMethods.AddRef()(ObjectPtr, _args);

                  }



                  public EngineTypeInfo GetType() {

                     InternalUnsafeMethods.GetType__Args _args = new InternalUnsafeMethods.GetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetType()(ObjectPtr, _args);

                     return new EngineTypeInfo(_engineResult);
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }




    }
}
