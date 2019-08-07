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

    public unsafe class SFXSound : SFXSource {



        public SFXSound(bool pRegister = false)
            : base(pRegister) {
        }

        public SFXSound(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public SFXSound(string pName)
            : this(pName, false) {
        }

        public SFXSound(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public SFXSound(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public SFXSound(SimObject pObj)
            : base(pObj) {
        }

        public SFXSound(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetDuration__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetDuration(IntPtr _this);
                internal delegate float _GetDuration(IntPtr _this, GetDuration__Args args);
                private static _GetDuration _GetDurationFunc;
                internal static _GetDuration GetDuration() {
                    if (_GetDurationFunc == null) {
                        _GetDurationFunc =
                            (_GetDuration)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSound_getDuration"), typeof(_GetDuration));
                    }

                    return _GetDurationFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetPosition__Args
                {

				   internal float position;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetPosition(IntPtr _this, float position);
                internal delegate void _SetPosition(IntPtr _this, SetPosition__Args args);
                private static _SetPosition _SetPositionFunc;
                internal static _SetPosition SetPosition() {
                    if (_SetPositionFunc == null) {
                        _SetPositionFunc =
                            (_SetPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSound_setPosition"), typeof(_SetPosition));
                    }

                    return _SetPositionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetPosition__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetPosition(IntPtr _this);
                internal delegate float _GetPosition(IntPtr _this, GetPosition__Args args);
                private static _GetPosition _GetPositionFunc;
                internal static _GetPosition GetPosition() {
                    if (_GetPositionFunc == null) {
                        _GetPositionFunc =
                            (_GetPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSound_getPosition"), typeof(_GetPosition));
                    }

                    return _GetPositionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsReady__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsReady(IntPtr _this);
                internal delegate bool _IsReady(IntPtr _this, IsReady__Args args);
                private static _IsReady _IsReadyFunc;
                internal static _IsReady IsReady() {
                    if (_IsReadyFunc == null) {
                        _IsReadyFunc =
                            (_IsReady)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSound_isReady"), typeof(_IsReady));
                    }

                    return _IsReadyFunc;
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
                                    "fnSFXSound_staticGetType"), typeof(_StaticGetType));
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
                                    "fnSFXSound_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public float GetDuration() {

                     InternalUnsafeMethods.GetDuration__Args _args = new InternalUnsafeMethods.GetDuration__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetDuration()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetPosition(float position) {

                                          InternalUnsafeMethods.SetPosition__Args _args = new InternalUnsafeMethods.SetPosition__Args() {
                        position = position,
                     };
                     InternalUnsafeMethods.SetPosition()(ObjectPtr, _args);

                  }



                  public float GetPosition() {

                     InternalUnsafeMethods.GetPosition__Args _args = new InternalUnsafeMethods.GetPosition__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetPosition()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsReady() {

                     InternalUnsafeMethods.IsReady__Args _args = new InternalUnsafeMethods.IsReady__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsReady()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
