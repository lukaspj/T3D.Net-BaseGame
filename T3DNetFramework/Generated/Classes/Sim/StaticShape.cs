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

    public unsafe class StaticShape : ShapeBase {



        public StaticShape(bool pRegister = false)
            : base(pRegister) {
        }

        public StaticShape(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public StaticShape(string pName)
            : this(pName, false) {
        }

        public StaticShape(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public StaticShape(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public StaticShape(SimObject pObj)
            : base(pObj) {
        }

        public StaticShape(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetPoweredState__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetPoweredState(IntPtr _this);
                internal delegate bool _GetPoweredState(IntPtr _this, GetPoweredState__Args args);
                private static _GetPoweredState _GetPoweredStateFunc;
                internal static _GetPoweredState GetPoweredState() {
                    if (_GetPoweredStateFunc == null) {
                        _GetPoweredStateFunc =
                            (_GetPoweredState)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStaticShape_getPoweredState"), typeof(_GetPoweredState));
                    }

                    return _GetPoweredStateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetPoweredState__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool isPowered;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetPoweredState(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool isPowered);
                internal delegate void _SetPoweredState(IntPtr _this, SetPoweredState__Args args);
                private static _SetPoweredState _SetPoweredStateFunc;
                internal static _SetPoweredState SetPoweredState() {
                    if (_SetPoweredStateFunc == null) {
                        _SetPoweredStateFunc =
                            (_SetPoweredState)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStaticShape_setPoweredState"), typeof(_SetPoweredState));
                    }

                    return _SetPoweredStateFunc;
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
                                    "fnStaticShape_staticGetType"), typeof(_StaticGetType));
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
                                    "fnStaticShape_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public bool GetPoweredState() {

                     InternalUnsafeMethods.GetPoweredState__Args _args = new InternalUnsafeMethods.GetPoweredState__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.GetPoweredState()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetPoweredState(bool isPowered) {

                                          InternalUnsafeMethods.SetPoweredState__Args _args = new InternalUnsafeMethods.SetPoweredState__Args() {
                        isPowered = isPowered,
                     };
                     InternalUnsafeMethods.SetPoweredState()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
