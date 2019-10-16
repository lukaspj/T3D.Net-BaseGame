using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;

namespace T3DNetFramework.Generated.Classes.Sim {
    /// <summary>Base properties shared by all Vehicles (FlyingVehicle, HoverVehicle, WheeledVehicle).</summary>
    /// <description>
    /// This datablock defines properties shared by all Vehicle types, but should not be instantiated directly. Instead, set the desired properties in the FlyingVehicleData, HoverVehicleData or WheeledVehicleData datablock.
    /// </description>
    /// <code>
    /// // damage from collisions
    /// collDamageMultiplier = 0.05;
    /// collDamageThresholdVel = 15;
    /// 
    /// // damage levels
    /// damageLevelTolerance[0] = 0.5;
    /// damageEmitter[0] = GraySmokeEmitter;     // emitter used when damage is >= 50%
    /// damageLevelTolerance[1] = 0.85;
    /// damageEmitter[1] = BlackSmokeEmitter;    // emitter used when damage is >= 85%
    /// damageEmitter[2] = DamageBubbleEmitter;  // emitter used instead of damageEmitter[0:1]
    ///                                          // when offset point is underwater
    /// // emit offsets (used for all active damage level emitters)
    /// damageEmitterOffset[0] = "0.5 3 1";
    /// damageEmitterOffset[1] = "-0.5 3 1";
    /// numDmgEmitterAreas = 2;
    /// </code>
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
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
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
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
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

        /// <description>
        /// Called when the vehicle leaves liquid.
        /// </description>
        /// <param name="obj">the Vehicle object</param>
        /// <param name="type">type of liquid the vehicle has left</param>
        public virtual void OnLeaveLiquid(Vehicle obj, string type) {
             InternalUnsafeMethods.OnLeaveLiquid__Args _args = new InternalUnsafeMethods.OnLeaveLiquid__Args() {
                obj = obj.ObjectPtr,
                type = type,
             };
             InternalUnsafeMethods.OnLeaveLiquid()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the vehicle enters liquid.
        /// </description>
        /// <param name="obj">the Vehicle object</param>
        /// <param name="coverage">percentage of the vehicle's bounding box covered by the liquid</param>
        /// <param name="type">type of liquid the vehicle has entered</param>
        public virtual void OnEnterLiquid(Vehicle obj, float coverage, string type) {
             InternalUnsafeMethods.OnEnterLiquid__Args _args = new InternalUnsafeMethods.OnEnterLiquid__Args() {
                obj = obj.ObjectPtr,
                coverage = coverage,
                type = type,
             };
             InternalUnsafeMethods.OnEnterLiquid()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the VehicleData class.
        /// </description>
        /// <returns>The type info object for VehicleData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>Creates a representation of the object in the physics plugin.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public bool EnablePhysicsRep {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("enablePhysicsRep"));
            set => SetFieldValue("enablePhysicsRep", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Additional force applied to the vehicle when it is jetting.</summary>
        /// <description>
        /// For WheeledVehicles, the force is applied in the forward direction. For FlyingVehicles, the force is applied in the thrust direction.
        /// </description>
        /// </value>
        public float JetForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetForce"));
            set => SetFieldValue("jetForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Energy amount to drain for each tick the vehicle is jetting.</summary>
        /// <description>
        /// Once the vehicle's energy level reaches 0, it will no longer be able to jet.
        /// </description>
        /// </value>
        public float JetEnergyDrain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetEnergyDrain"));
            set => SetFieldValue("jetEnergyDrain", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum vehicle energy level to begin jetting.
        /// </description>
        /// </value>
        public float MinJetEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minJetEnergy"));
            set => SetFieldValue("minJetEnergy", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Rate at which the vehicle's steering returns to forwards when it is moving.
        /// </description>
        /// </value>
        public float SteeringReturn {
            get => GenericMarshal.StringTo<float>(GetFieldValue("steeringReturn"));
            set => SetFieldValue("steeringReturn", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Amount of effect the vehicle's speed has on its rate of steering return.
        /// </description>
        /// </value>
        public float SteeringReturnSpeedScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("steeringReturnSpeedScale"));
            set => SetFieldValue("steeringReturnSpeedScale", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, steering does not auto-centre while the vehicle is being steered by its driver.
        /// </description>
        /// </value>
        public bool PowerSteering {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("powerSteering"));
            set => SetFieldValue("powerSteering", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Defines the vehicle's center of mass (offset from the origin of the model).
        /// </description>
        /// </value>
        public Point3F MassCenter {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("massCenter"));
            set => SetFieldValue("massCenter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Define the box used to estimate the vehicle's moment of inertia.</summary>
        /// <description>
        /// Currently only used by WheeledVehicle; other vehicle types use a unit sphere to compute inertia.
        /// </description>
        /// </value>
        public Point3F MassBox {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("massBox"));
            set => SetFieldValue("massBox", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Collision 'bounciness'.
        /// Normally in the range 0 (not bouncy at all) to 1 (100% bounciness).
        /// </description>
        /// </value>
        public float BodyRestitution {
            get => GenericMarshal.StringTo<float>(GetFieldValue("bodyRestitution"));
            set => SetFieldValue("bodyRestitution", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Collision friction coefficient.
        /// How well this object will slide against objects it collides with.
        /// </description>
        /// </value>
        public float BodyFriction {
            get => GenericMarshal.StringTo<float>(GetFieldValue("bodyFriction"));
            set => SetFieldValue("bodyFriction", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Sound to play on a 'soft' impact.</summary>
        /// <description>
        /// This sound is played if the impact speed is < hardImpactSpeed and >= softImpactSpeed.
        /// </description>
        /// <see cref="softImpactSpeed" />
        /// </value>
        public SFXProfile SoftImpactSound {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("softImpactSound"));
            set => SetFieldValue("softImpactSound", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Sound to play on a 'hard' impact.</summary>
        /// <description>
        /// This sound is played if the impact speed >= hardImpactSpeed.
        /// </description>
        /// <see cref="hardImpactSpeed" />
        /// </value>
        public SFXProfile HardImpactSound {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("hardImpactSound"));
            set => SetFieldValue("hardImpactSound", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum collision speed for the onImpact callback to be invoked.
        /// </description>
        /// </value>
        public float MinImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minImpactSpeed"));
            set => SetFieldValue("minImpactSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum collision speed for the softImpactSound to be played.
        /// </description>
        /// </value>
        public float SoftImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("softImpactSpeed"));
            set => SetFieldValue("softImpactSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum collision speed for the hardImpactSound to be played.
        /// </description>
        /// </value>
        public float HardImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("hardImpactSpeed"));
            set => SetFieldValue("hardImpactSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Unused
        /// </description>
        /// </value>
        public float MinRollSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minRollSpeed"));
            set => SetFieldValue("minRollSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Maximum yaw (horizontal) and pitch (vertical) steering angle in radians.
        /// </description>
        /// </value>
        public float MaxSteeringAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSteeringAngle"));
            set => SetFieldValue("maxSteeringAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Maximum drag coefficient.
        /// Currently unused.
        /// </description>
        /// </value>
        public float MaxDrag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxDrag"));
            set => SetFieldValue("maxDrag", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum drag coefficient.
        /// Currently only used by FlyingVehicle.
        /// </description>
        /// </value>
        public float MinDrag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minDrag"));
            set => SetFieldValue("minDrag", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Number of integration steps per tick.
        /// Increase this to improve simulation stability (also increases simulation processing time).
        /// </description>
        /// </value>
        public int Integration {
            get => GenericMarshal.StringTo<int>(GetFieldValue("integration"));
            set => SetFieldValue("integration", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum distance between objects for them to be considered as colliding.
        /// </description>
        /// </value>
        public float CollisionTol {
            get => GenericMarshal.StringTo<float>(GetFieldValue("collisionTol"));
            set => SetFieldValue("collisionTol", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Maximum relative velocity between objects for collisions to be resolved as contacts.
        /// Velocities greater than this are handled as collisions.
        /// </description>
        /// </value>
        public float ContactTol {
            get => GenericMarshal.StringTo<float>(GetFieldValue("contactTol"));
            set => SetFieldValue("contactTol", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, the camera will roll with the vehicle. If false, the camera will always have the positive Z axis as up.
        /// </description>
        /// </value>
        public bool CameraRoll {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("cameraRoll"));
            set => SetFieldValue("cameraRoll", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>How much the camera lags behind the vehicle depending on vehicle speed.</summary>
        /// <description>
        /// Increasing this value will make the camera fall further behind the vehicle as it accelerates away.
        /// </description>
        /// <see cref="cameraDecay." />
        /// </value>
        public float CameraLag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraLag"));
            set => SetFieldValue("cameraLag", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// How quickly the camera moves back towards the vehicle when stopped.
        /// </description>
        /// <see cref="cameraLag." />
        /// </value>
        public float CameraDecay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraDecay"));
            set => SetFieldValue("cameraDecay", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Vertical (Z axis) height of the camera above the vehicle.
        /// </description>
        /// </value>
        public float CameraOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraOffset"));
            set => SetFieldValue("cameraOffset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Dust particle emitter.
        /// </description>
        /// <see cref="triggerDustHeight" />
        /// <see cref="dustHeight" />
        /// </value>
        public ParticleEmitterData DustEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("dustEmitter"));
            set => SetFieldValue("dustEmitter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum height above surface to emit dust particles.</summary>
        /// <description>
        /// If the vehicle is less than triggerDustHeight above a static surface with a material that has 'showDust' set to true, the vehicle will emit particles from the dustEmitter.
        /// </description>
        /// </value>
        public float TriggerDustHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("triggerDustHeight"));
            set => SetFieldValue("triggerDustHeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Height above ground at which to emit particles from the dustEmitter.
        /// </description>
        /// </value>
        public float DustHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dustHeight"));
            set => SetFieldValue("dustHeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Array of particle emitters used to generate damage (dust, smoke etc) effects.</summary>
        /// <description>
        /// Currently, the first two emitters (indices 0 and 1) are used when the damage level exceeds the associated damageLevelTolerance. The 3rd emitter is used when the emitter point is underwater.
        /// </description>
        /// <see cref="damageEmitterOffset" />
        /// </value>
        public DynamicFieldVector<ParticleEmitterData> DamageEmitter {
            get => new DynamicFieldVector<ParticleEmitterData>(
                    this, 
                    "damageEmitter", 
                    3, 
                    val => GenericMarshal.StringTo<ParticleEmitterData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>Object space "x y z" offsets used to emit particles for the active damageEmitter.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // damage levels
        /// damageLevelTolerance[0] = 0.5;
        /// damageEmitter[0] = SmokeEmitter;
        /// // emit offsets (used for all active damage level emitters)
        /// damageEmitterOffset[0] = "0.5 3 1";
        /// damageEmitterOffset[1] = "-0.5 3 1";
        /// numDmgEmitterAreas = 2;
        /// </code>
        /// </value>
        public DynamicFieldVector<Point3F> DamageEmitterOffset {
            get => new DynamicFieldVector<Point3F>(
                    this, 
                    "damageEmitterOffset", 
                    2, 
                    val => GenericMarshal.StringTo<Point3F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>Damage levels (as a percentage of maxDamage) above which to begin emitting particles from the associated damageEmitter.</summary>
        /// <description>
        /// Levels should be in order of increasing damage.
        /// </description>
        /// <see cref="damageEmitterOffset" />
        /// </value>
        public DynamicFieldVector<float> DamageLevelTolerance {
            get => new DynamicFieldVector<float>(
                    this, 
                    "damageLevelTolerance", 
                    2, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Number of damageEmitterOffset values to use for each damageEmitter.
        /// </description>
        /// <see cref="damageEmitterOffset" />
        /// </value>
        public float NumDmgEmitterAreas {
            get => GenericMarshal.StringTo<float>(GetFieldValue("numDmgEmitterAreas"));
            set => SetFieldValue("numDmgEmitterAreas", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Array of particle emitters used to generate splash effects.
        /// </description>
        /// </value>
        public DynamicFieldVector<ParticleEmitterData> SplashEmitter {
            get => new DynamicFieldVector<ParticleEmitterData>(
                    this, 
                    "splashEmitter", 
                    2, 
                    val => GenericMarshal.StringTo<ParticleEmitterData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>Number of splash particles to generate based on vehicle speed.</summary>
        /// <description>
        /// This value is multiplied by the current speed to determine how many particles to generate each frame.
        /// </description>
        /// </value>
        public float SplashFreqMod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashFreqMod"));
            set => SetFieldValue("splashFreqMod", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum speed when moving through water to generate splash particles.
        /// </description>
        /// </value>
        public float SplashVelEpsilon {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashVelEpsilon"));
            set => SetFieldValue("splashVelEpsilon", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum velocity when leaving the water for the exitingWater sound to play.
        /// </description>
        /// </value>
        public float ExitSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("exitSplashSoundVelocity"));
            set => SetFieldValue("exitSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum velocity when entering the water for the imapactWaterEasy sound to play.
        /// </description>
        /// <see cref="impactWaterEasy" />
        /// </value>
        public float SoftSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("softSplashSoundVelocity"));
            set => SetFieldValue("softSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum velocity when entering the water for the imapactWaterMedium sound to play.
        /// </description>
        /// <see cref="impactWaterMedium" />
        /// </value>
        public float MediumSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mediumSplashSoundVelocity"));
            set => SetFieldValue("mediumSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum velocity when entering the water for the imapactWaterHard sound to play.
        /// </description>
        /// <see cref="impactWaterHard" />
        /// </value>
        public float HardSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("hardSplashSoundVelocity"));
            set => SetFieldValue("hardSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Sound to play when exiting the water.
        /// </description>
        /// </value>
        public SFXProfile ExitingWater {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("exitingWater"));
            set => SetFieldValue("exitingWater", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Sound to play when entering the water with speed >= softSplashSoundVelocity and < mediumSplashSoundVelocity.
        /// </description>
        /// </value>
        public SFXProfile ImpactWaterEasy {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("impactWaterEasy"));
            set => SetFieldValue("impactWaterEasy", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Sound to play when entering the water with speed >= mediumSplashSoundVelocity and < hardSplashSoundVelocity.
        /// </description>
        /// </value>
        public SFXProfile ImpactWaterMedium {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("impactWaterMedium"));
            set => SetFieldValue("impactWaterMedium", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Sound to play when entering the water with speed >= hardSplashSoundVelocity.
        /// </description>
        /// </value>
        public SFXProfile ImpactWaterHard {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("impactWaterHard"));
            set => SetFieldValue("impactWaterHard", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Looping sound to play while moving through the water.
        /// </description>
        /// </value>
        public SFXProfile WaterWakeSound {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("waterWakeSound"));
            set => SetFieldValue("waterWakeSound", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum collision velocity to cause damage to this vehicle.
        /// Currently unused.
        /// </description>
        /// </value>
        public float CollDamageThresholdVel {
            get => GenericMarshal.StringTo<float>(GetFieldValue("collDamageThresholdVel"));
            set => SetFieldValue("collDamageThresholdVel", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Damage to this vehicle after a collision (multiplied by collision velocity).</summary>
        /// <description>
        /// Currently unused.
        /// </description>
        /// </value>
        public float CollDamageMultiplier {
            get => GenericMarshal.StringTo<float>(GetFieldValue("collDamageMultiplier"));
            set => SetFieldValue("collDamageMultiplier", GenericMarshal.ToString(value));
        }
    }
}