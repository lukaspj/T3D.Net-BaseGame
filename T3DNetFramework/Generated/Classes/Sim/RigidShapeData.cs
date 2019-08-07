using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DSharpFramework.Engine;
using T3DSharpFramework.Engine.Util;
using T3DSharpFramework.Generated.Classes.Global;
using T3DSharpFramework.Generated.Classes.Reflection;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Classes.Sim.Net;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Enums.Reflection;
using T3DSharpFramework.Generated.Structs.Global;
using T3DSharpFramework.Generated.Structs.Gui;
using T3DSharpFramework.Generated.Structs.Math;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Generated.Classes.Sim {    

    public unsafe class RigidShapeData : ShapeBaseData {



        public RigidShapeData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public RigidShapeData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public RigidShapeData(string pName) 
            : this(pName, false) {
        }
        
        public RigidShapeData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public RigidShapeData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public RigidShapeData(SimObject pObj) 
            : base(pObj) {
        }
        
        public RigidShapeData(IntPtr pObj) 
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
                                    "fnRigidShapeData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnRigidShapeData_create"), typeof(_Create));
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


        public float DragForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dragForce"));
            set => SetFieldValue("dragForce", GenericMarshal.ToString(value));
        }


        public float VertFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("vertFactor"));
            set => SetFieldValue("vertFactor", GenericMarshal.ToString(value));
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


        public ParticleEmitterData DustTrailEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("dustTrailEmitter"));
            set => SetFieldValue("dustTrailEmitter", GenericMarshal.ToString(value));
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


        public SFXTrack SoftImpactSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("softImpactSound"));
            set => SetFieldValue("softImpactSound", GenericMarshal.ToString(value));
        }


        public SFXTrack HardImpactSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("hardImpactSound"));
            set => SetFieldValue("hardImpactSound", GenericMarshal.ToString(value));
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


        public SFXTrack ExitingWater {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("exitingWater"));
            set => SetFieldValue("exitingWater", GenericMarshal.ToString(value));
        }


        public SFXTrack ImpactWaterEasy {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("impactWaterEasy"));
            set => SetFieldValue("impactWaterEasy", GenericMarshal.ToString(value));
        }


        public SFXTrack ImpactWaterMedium {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("impactWaterMedium"));
            set => SetFieldValue("impactWaterMedium", GenericMarshal.ToString(value));
        }


        public SFXTrack ImpactWaterHard {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("impactWaterHard"));
            set => SetFieldValue("impactWaterHard", GenericMarshal.ToString(value));
        }


        public SFXTrack WaterWakeSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("waterWakeSound"));
            set => SetFieldValue("waterWakeSound", GenericMarshal.ToString(value));
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


    }
}