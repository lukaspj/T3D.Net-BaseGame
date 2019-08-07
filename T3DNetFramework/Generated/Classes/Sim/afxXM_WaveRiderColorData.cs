using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class afxXM_WaveRiderColorData : afxXM_WaveRiderBaseData {



        public afxXM_WaveRiderColorData(bool pRegister = false)
            : base(pRegister) {
        }

        public afxXM_WaveRiderColorData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public afxXM_WaveRiderColorData(string pName)
            : this(pName, false) {
        }

        public afxXM_WaveRiderColorData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxXM_WaveRiderColorData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxXM_WaveRiderColorData(SimObject pObj)
            : base(pObj) {
        }

        public afxXM_WaveRiderColorData(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



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
                                    "fnafxXM_WaveRiderColorData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnafxXM_WaveRiderColorData_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public LinearColorF A {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("a"));
            set => SetFieldValue("a", GenericMarshal.ToString(value));
        }


        public LinearColorF B {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("b"));
            set => SetFieldValue("b", GenericMarshal.ToString(value));
        }


        public LinearColorF AVariance {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("aVariance"));
            set => SetFieldValue("aVariance", GenericMarshal.ToString(value));
        }


        public LinearColorF BVariance {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("bVariance"));
            set => SetFieldValue("bVariance", GenericMarshal.ToString(value));
        }


        public bool SyncVariances {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("syncVariances"));
            set => SetFieldValue("syncVariances", GenericMarshal.ToString(value));
        }


    }
}
