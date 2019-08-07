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

    public unsafe class WheeledVehicleTire : SimDataBlock {



        public WheeledVehicleTire(bool pRegister = false)
            : base(pRegister) {
        }

        public WheeledVehicleTire(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public WheeledVehicleTire(string pName)
            : this(pName, false) {
        }

        public WheeledVehicleTire(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public WheeledVehicleTire(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public WheeledVehicleTire(SimObject pObj)
            : base(pObj) {
        }

        public WheeledVehicleTire(IntPtr pObj)
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
                                    "fnWheeledVehicleTire_staticGetType"), typeof(_StaticGetType));
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
                                    "fnWheeledVehicleTire_create"), typeof(_Create));
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






        public string ShapeFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("shapeFile"));
            set => SetFieldValue("shapeFile", GenericMarshal.ToString(value));
        }


        public float Mass {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mass"));
            set => SetFieldValue("mass", GenericMarshal.ToString(value));
        }


        public float Radius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("radius"));
            set => SetFieldValue("radius", GenericMarshal.ToString(value));
        }


        public float StaticFriction {
            get => GenericMarshal.StringTo<float>(GetFieldValue("staticFriction"));
            set => SetFieldValue("staticFriction", GenericMarshal.ToString(value));
        }


        public float KineticFriction {
            get => GenericMarshal.StringTo<float>(GetFieldValue("kineticFriction"));
            set => SetFieldValue("kineticFriction", GenericMarshal.ToString(value));
        }


        public float Restitution {
            get => GenericMarshal.StringTo<float>(GetFieldValue("restitution"));
            set => SetFieldValue("restitution", GenericMarshal.ToString(value));
        }


        public float LateralForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lateralForce"));
            set => SetFieldValue("lateralForce", GenericMarshal.ToString(value));
        }


        public float LateralDamping {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lateralDamping"));
            set => SetFieldValue("lateralDamping", GenericMarshal.ToString(value));
        }


        public float LateralRelaxation {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lateralRelaxation"));
            set => SetFieldValue("lateralRelaxation", GenericMarshal.ToString(value));
        }


        public float LongitudinalForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("longitudinalForce"));
            set => SetFieldValue("longitudinalForce", GenericMarshal.ToString(value));
        }


        public float LongitudinalDamping {
            get => GenericMarshal.StringTo<float>(GetFieldValue("longitudinalDamping"));
            set => SetFieldValue("longitudinalDamping", GenericMarshal.ToString(value));
        }


        public float LongitudinalRelaxation {
            get => GenericMarshal.StringTo<float>(GetFieldValue("longitudinalRelaxation"));
            set => SetFieldValue("longitudinalRelaxation", GenericMarshal.ToString(value));
        }


    }
}
