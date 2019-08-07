using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class SplashData : GameBaseData {



        public SplashData(bool pRegister = false)
            : base(pRegister) {
        }

        public SplashData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public SplashData(string pName)
            : this(pName, false) {
        }

        public SplashData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public SplashData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public SplashData(SimObject pObj)
            : base(pObj) {
        }

        public SplashData(IntPtr pObj)
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
                                    "fnSplashData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnSplashData_create"), typeof(_Create));
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






        public SFXProfile SoundProfile {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("soundProfile"));
            set => SetFieldValue("soundProfile", GenericMarshal.ToString(value));
        }


        public Point3F Scale {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("scale"));
            set => SetFieldValue("scale", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<ParticleEmitterData> Emitter {
            get => new DynamicFieldVector<ParticleEmitterData>(
                    this,
                    "emitter",
                    3,
                    val => GenericMarshal.StringTo<ParticleEmitterData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public int DelayMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("delayMS"));
            set => SetFieldValue("delayMS", GenericMarshal.ToString(value));
        }


        public int DelayVariance {
            get => GenericMarshal.StringTo<int>(GetFieldValue("delayVariance"));
            set => SetFieldValue("delayVariance", GenericMarshal.ToString(value));
        }


        public int LifetimeMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lifetimeMS"));
            set => SetFieldValue("lifetimeMS", GenericMarshal.ToString(value));
        }


        public int LifetimeVariance {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lifetimeVariance"));
            set => SetFieldValue("lifetimeVariance", GenericMarshal.ToString(value));
        }


        public float Width {
            get => GenericMarshal.StringTo<float>(GetFieldValue("width"));
            set => SetFieldValue("width", GenericMarshal.ToString(value));
        }


        public int NumSegments {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numSegments"));
            set => SetFieldValue("numSegments", GenericMarshal.ToString(value));
        }


        public float Velocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("velocity"));
            set => SetFieldValue("velocity", GenericMarshal.ToString(value));
        }


        public float Height {
            get => GenericMarshal.StringTo<float>(GetFieldValue("height"));
            set => SetFieldValue("height", GenericMarshal.ToString(value));
        }


        public float Acceleration {
            get => GenericMarshal.StringTo<float>(GetFieldValue("acceleration"));
            set => SetFieldValue("acceleration", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<float> Times {
            get => new DynamicFieldVector<float>(
                    this,
                    "times",
                    4,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<LinearColorF> Colors {
            get => new DynamicFieldVector<LinearColorF>(
                    this,
                    "colors",
                    4,
                    val => GenericMarshal.StringTo<LinearColorF>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<string> Texture {
            get => new DynamicFieldVector<string>(
                    this,
                    "texture",
                    2,
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public float TexWrap {
            get => GenericMarshal.StringTo<float>(GetFieldValue("texWrap"));
            set => SetFieldValue("texWrap", GenericMarshal.ToString(value));
        }


        public float TexFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("texFactor"));
            set => SetFieldValue("texFactor", GenericMarshal.ToString(value));
        }


        public float EjectionFreq {
            get => GenericMarshal.StringTo<float>(GetFieldValue("ejectionFreq"));
            set => SetFieldValue("ejectionFreq", GenericMarshal.ToString(value));
        }


        public float EjectionAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("ejectionAngle"));
            set => SetFieldValue("ejectionAngle", GenericMarshal.ToString(value));
        }


        public float RingLifetime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("ringLifetime"));
            set => SetFieldValue("ringLifetime", GenericMarshal.ToString(value));
        }


        public float StartRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("startRadius"));
            set => SetFieldValue("startRadius", GenericMarshal.ToString(value));
        }


        public ExplosionData Explosion {
            get => GenericMarshal.StringTo<ExplosionData>(GetFieldValue("Explosion"));
            set => SetFieldValue("Explosion", GenericMarshal.ToString(value));
        }


    }
}
