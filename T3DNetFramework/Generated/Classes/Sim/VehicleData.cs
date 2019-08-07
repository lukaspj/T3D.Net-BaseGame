using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class VehicleData : ShapeBaseData {



        public VehicleData(bool pRegister = false)
            : base(pRegister) {
        }

        public VehicleData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public VehicleData(string pName)
            : this(pName, false) {
        }

        public VehicleData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public VehicleData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public VehicleData(SimObject pObj)
            : base(pObj) {
        }

        public VehicleData(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnLeaveLiquid__Args
                {

				   internal IntPtr obj;

				   internal string type;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnLeaveLiquid(IntPtr _this, IntPtr obj, string type);
                internal delegate void _OnLeaveLiquid(IntPtr _this, OnLeaveLiquid__Args args);
                private static _OnLeaveLiquid _OnLeaveLiquidFunc;
                internal static _OnLeaveLiquid OnLeaveLiquid() {
                    if (_OnLeaveLiquidFunc == null) {
                        _OnLeaveLiquidFunc =
                            (_OnLeaveLiquid)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbVehicleData_onLeaveLiquid"), typeof(_OnLeaveLiquid));
                    }

                    return _OnLeaveLiquidFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnEnterLiquid__Args
                {

				   internal IntPtr obj;

				   internal float coverage;

				   internal string type;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnEnterLiquid(IntPtr _this, IntPtr obj, float coverage, string type);
                internal delegate void _OnEnterLiquid(IntPtr _this, OnEnterLiquid__Args args);
                private static _OnEnterLiquid _OnEnterLiquidFunc;
                internal static _OnEnterLiquid OnEnterLiquid() {
                    if (_OnEnterLiquidFunc == null) {
                        _OnEnterLiquidFunc =
                            (_OnEnterLiquid)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbVehicleData_onEnterLiquid"), typeof(_OnEnterLiquid));
                    }

                    return _OnEnterLiquidFunc;
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
                                    "fnVehicleData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnVehicleData_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void OnLeaveLiquid(Vehicle obj, string type) {

                                                               InternalUnsafeMethods.OnLeaveLiquid__Args _args = new InternalUnsafeMethods.OnLeaveLiquid__Args() {
                        obj = obj.ObjectPtr,
                        type = type,
                     };
                     InternalUnsafeMethods.OnLeaveLiquid()(ObjectPtr, _args);

                  }



                  public void OnEnterLiquid(Vehicle obj, float coverage, string type) {

                                                                                    InternalUnsafeMethods.OnEnterLiquid__Args _args = new InternalUnsafeMethods.OnEnterLiquid__Args() {
                        obj = obj.ObjectPtr,
                        coverage = coverage,
                        type = type,
                     };
                     InternalUnsafeMethods.OnEnterLiquid()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public bool EnablePhysicsRep {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("enablePhysicsRep"));
            set => SetFieldValue("enablePhysicsRep", GenericMarshal.ToString(value));
        }


        public float JetForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetForce"));
            set => SetFieldValue("jetForce", GenericMarshal.ToString(value));
        }


        public float JetEnergyDrain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetEnergyDrain"));
            set => SetFieldValue("jetEnergyDrain", GenericMarshal.ToString(value));
        }


        public float MinJetEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minJetEnergy"));
            set => SetFieldValue("minJetEnergy", GenericMarshal.ToString(value));
        }


        public float SteeringReturn {
            get => GenericMarshal.StringTo<float>(GetFieldValue("steeringReturn"));
            set => SetFieldValue("steeringReturn", GenericMarshal.ToString(value));
        }


        public float SteeringReturnSpeedScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("steeringReturnSpeedScale"));
            set => SetFieldValue("steeringReturnSpeedScale", GenericMarshal.ToString(value));
        }


        public bool PowerSteering {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("powerSteering"));
            set => SetFieldValue("powerSteering", GenericMarshal.ToString(value));
        }


        public Point3F MassCenter {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("massCenter"));
            set => SetFieldValue("massCenter", GenericMarshal.ToString(value));
        }


        public Point3F MassBox {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("massBox"));
            set => SetFieldValue("massBox", GenericMarshal.ToString(value));
        }


        public float BodyRestitution {
            get => GenericMarshal.StringTo<float>(GetFieldValue("bodyRestitution"));
            set => SetFieldValue("bodyRestitution", GenericMarshal.ToString(value));
        }


        public float BodyFriction {
            get => GenericMarshal.StringTo<float>(GetFieldValue("bodyFriction"));
            set => SetFieldValue("bodyFriction", GenericMarshal.ToString(value));
        }


        public SFXProfile SoftImpactSound {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("softImpactSound"));
            set => SetFieldValue("softImpactSound", GenericMarshal.ToString(value));
        }


        public SFXProfile HardImpactSound {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("hardImpactSound"));
            set => SetFieldValue("hardImpactSound", GenericMarshal.ToString(value));
        }


        public float MinImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minImpactSpeed"));
            set => SetFieldValue("minImpactSpeed", GenericMarshal.ToString(value));
        }


        public float SoftImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("softImpactSpeed"));
            set => SetFieldValue("softImpactSpeed", GenericMarshal.ToString(value));
        }


        public float HardImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("hardImpactSpeed"));
            set => SetFieldValue("hardImpactSpeed", GenericMarshal.ToString(value));
        }


        public float MinRollSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minRollSpeed"));
            set => SetFieldValue("minRollSpeed", GenericMarshal.ToString(value));
        }


        public float MaxSteeringAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSteeringAngle"));
            set => SetFieldValue("maxSteeringAngle", GenericMarshal.ToString(value));
        }


        public float MaxDrag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxDrag"));
            set => SetFieldValue("maxDrag", GenericMarshal.ToString(value));
        }


        public float MinDrag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minDrag"));
            set => SetFieldValue("minDrag", GenericMarshal.ToString(value));
        }


        public int Integration {
            get => GenericMarshal.StringTo<int>(GetFieldValue("integration"));
            set => SetFieldValue("integration", GenericMarshal.ToString(value));
        }


        public float CollisionTol {
            get => GenericMarshal.StringTo<float>(GetFieldValue("collisionTol"));
            set => SetFieldValue("collisionTol", GenericMarshal.ToString(value));
        }


        public float ContactTol {
            get => GenericMarshal.StringTo<float>(GetFieldValue("contactTol"));
            set => SetFieldValue("contactTol", GenericMarshal.ToString(value));
        }


        public bool CameraRoll {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("cameraRoll"));
            set => SetFieldValue("cameraRoll", GenericMarshal.ToString(value));
        }


        public float CameraLag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraLag"));
            set => SetFieldValue("cameraLag", GenericMarshal.ToString(value));
        }


        public float CameraDecay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraDecay"));
            set => SetFieldValue("cameraDecay", GenericMarshal.ToString(value));
        }


        public float CameraOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraOffset"));
            set => SetFieldValue("cameraOffset", GenericMarshal.ToString(value));
        }


        public ParticleEmitterData DustEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("dustEmitter"));
            set => SetFieldValue("dustEmitter", GenericMarshal.ToString(value));
        }


        public float TriggerDustHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("triggerDustHeight"));
            set => SetFieldValue("triggerDustHeight", GenericMarshal.ToString(value));
        }


        public float DustHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dustHeight"));
            set => SetFieldValue("dustHeight", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<ParticleEmitterData> DamageEmitter {
            get => new DynamicFieldVector<ParticleEmitterData>(
                    this,
                    "damageEmitter",
                    3,
                    val => GenericMarshal.StringTo<ParticleEmitterData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<Point3F> DamageEmitterOffset {
            get => new DynamicFieldVector<Point3F>(
                    this,
                    "damageEmitterOffset",
                    2,
                    val => GenericMarshal.StringTo<Point3F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> DamageLevelTolerance {
            get => new DynamicFieldVector<float>(
                    this,
                    "damageLevelTolerance",
                    2,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public float NumDmgEmitterAreas {
            get => GenericMarshal.StringTo<float>(GetFieldValue("numDmgEmitterAreas"));
            set => SetFieldValue("numDmgEmitterAreas", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<ParticleEmitterData> SplashEmitter {
            get => new DynamicFieldVector<ParticleEmitterData>(
                    this,
                    "splashEmitter",
                    2,
                    val => GenericMarshal.StringTo<ParticleEmitterData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public float SplashFreqMod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashFreqMod"));
            set => SetFieldValue("splashFreqMod", GenericMarshal.ToString(value));
        }


        public float SplashVelEpsilon {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashVelEpsilon"));
            set => SetFieldValue("splashVelEpsilon", GenericMarshal.ToString(value));
        }


        public float ExitSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("exitSplashSoundVelocity"));
            set => SetFieldValue("exitSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        public float SoftSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("softSplashSoundVelocity"));
            set => SetFieldValue("softSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        public float MediumSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mediumSplashSoundVelocity"));
            set => SetFieldValue("mediumSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        public float HardSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("hardSplashSoundVelocity"));
            set => SetFieldValue("hardSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        public SFXProfile ExitingWater {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("exitingWater"));
            set => SetFieldValue("exitingWater", GenericMarshal.ToString(value));
        }


        public SFXProfile ImpactWaterEasy {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("impactWaterEasy"));
            set => SetFieldValue("impactWaterEasy", GenericMarshal.ToString(value));
        }


        public SFXProfile ImpactWaterMedium {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("impactWaterMedium"));
            set => SetFieldValue("impactWaterMedium", GenericMarshal.ToString(value));
        }


        public SFXProfile ImpactWaterHard {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("impactWaterHard"));
            set => SetFieldValue("impactWaterHard", GenericMarshal.ToString(value));
        }


        public SFXProfile WaterWakeSound {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("waterWakeSound"));
            set => SetFieldValue("waterWakeSound", GenericMarshal.ToString(value));
        }


        public float CollDamageThresholdVel {
            get => GenericMarshal.StringTo<float>(GetFieldValue("collDamageThresholdVel"));
            set => SetFieldValue("collDamageThresholdVel", GenericMarshal.ToString(value));
        }


        public float CollDamageMultiplier {
            get => GenericMarshal.StringTo<float>(GetFieldValue("collDamageMultiplier"));
            set => SetFieldValue("collDamageMultiplier", GenericMarshal.ToString(value));
        }


    }
}
