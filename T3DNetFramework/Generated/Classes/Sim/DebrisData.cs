using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class DebrisData : GameBaseData {



        public DebrisData(bool pRegister = false)
            : base(pRegister) {
        }

        public DebrisData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public DebrisData(string pName)
            : this(pName, false) {
        }

        public DebrisData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public DebrisData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public DebrisData(SimObject pObj)
            : base(pObj) {
        }

        public DebrisData(IntPtr pObj)
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
                                    "fnDebrisData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnDebrisData_create"), typeof(_Create));
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






        public string Texture {
            get => GenericMarshal.StringTo<string>(GetFieldValue("texture"));
            set => SetFieldValue("texture", GenericMarshal.ToString(value));
        }


        public string ShapeFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("shapeFile"));
            set => SetFieldValue("shapeFile", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<ParticleEmitterData> Emitters {
            get => new DynamicFieldVector<ParticleEmitterData>(
                    this,
                    "emitters",
                    2,
                    val => GenericMarshal.StringTo<ParticleEmitterData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public ExplosionData Explosion {
            get => GenericMarshal.StringTo<ExplosionData>(GetFieldValue("Explosion"));
            set => SetFieldValue("Explosion", GenericMarshal.ToString(value));
        }


        public float Elasticity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("elasticity"));
            set => SetFieldValue("elasticity", GenericMarshal.ToString(value));
        }


        public float Friction {
            get => GenericMarshal.StringTo<float>(GetFieldValue("friction"));
            set => SetFieldValue("friction", GenericMarshal.ToString(value));
        }


        public int NumBounces {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numBounces"));
            set => SetFieldValue("numBounces", GenericMarshal.ToString(value));
        }


        public int BounceVariance {
            get => GenericMarshal.StringTo<int>(GetFieldValue("bounceVariance"));
            set => SetFieldValue("bounceVariance", GenericMarshal.ToString(value));
        }


        public float MinSpinSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minSpinSpeed"));
            set => SetFieldValue("minSpinSpeed", GenericMarshal.ToString(value));
        }


        public float MaxSpinSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSpinSpeed"));
            set => SetFieldValue("maxSpinSpeed", GenericMarshal.ToString(value));
        }


        public float GravModifier {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gravModifier"));
            set => SetFieldValue("gravModifier", GenericMarshal.ToString(value));
        }


        public float TerminalVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("terminalVelocity"));
            set => SetFieldValue("terminalVelocity", GenericMarshal.ToString(value));
        }


        public float Velocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("velocity"));
            set => SetFieldValue("velocity", GenericMarshal.ToString(value));
        }


        public float VelocityVariance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("velocityVariance"));
            set => SetFieldValue("velocityVariance", GenericMarshal.ToString(value));
        }


        public float Lifetime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lifetime"));
            set => SetFieldValue("lifetime", GenericMarshal.ToString(value));
        }


        public float LifetimeVariance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lifetimeVariance"));
            set => SetFieldValue("lifetimeVariance", GenericMarshal.ToString(value));
        }


        public bool UseRadiusMass {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useRadiusMass"));
            set => SetFieldValue("useRadiusMass", GenericMarshal.ToString(value));
        }


        public float BaseRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("baseRadius"));
            set => SetFieldValue("baseRadius", GenericMarshal.ToString(value));
        }


        public bool ExplodeOnMaxBounce {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("explodeOnMaxBounce"));
            set => SetFieldValue("explodeOnMaxBounce", GenericMarshal.ToString(value));
        }


        public bool StaticOnMaxBounce {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("staticOnMaxBounce"));
            set => SetFieldValue("staticOnMaxBounce", GenericMarshal.ToString(value));
        }


        public bool SnapOnMaxBounce {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("snapOnMaxBounce"));
            set => SetFieldValue("snapOnMaxBounce", GenericMarshal.ToString(value));
        }


        public bool Fade {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fade"));
            set => SetFieldValue("fade", GenericMarshal.ToString(value));
        }


        public bool IgnoreWater {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreWater"));
            set => SetFieldValue("ignoreWater", GenericMarshal.ToString(value));
        }


    }
}
