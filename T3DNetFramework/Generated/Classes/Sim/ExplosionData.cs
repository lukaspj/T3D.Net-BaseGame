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
    public unsafe class ExplosionData : GameBaseData {
        public ExplosionData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ExplosionData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ExplosionData(string pName) 
            : this(pName, false) {
        }
        
        public ExplosionData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ExplosionData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ExplosionData(SimObject pObj) 
            : base(pObj) {
        }
        
        public ExplosionData(IntPtr pObj) 
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
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
                if (_StaticGetTypeFunc == null) {
                    _StaticGetTypeFunc =
                        (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnExplosionData_staticGetType"), typeof(_StaticGetType));
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
                                "fnExplosionData_create"), typeof(_Create));
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

        public string ExplosionShape {
            get => GenericMarshal.StringTo<string>(GetFieldValue("explosionShape"));
            set => SetFieldValue("explosionShape", GenericMarshal.ToString(value));
        }

        public Point3F ExplosionScale {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("explosionScale"));
            set => SetFieldValue("explosionScale", GenericMarshal.ToString(value));
        }

        public float PlaySpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("playSpeed"));
            set => SetFieldValue("playSpeed", GenericMarshal.ToString(value));
        }

        public SFXTrack SoundProfile {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("soundProfile"));
            set => SetFieldValue("soundProfile", GenericMarshal.ToString(value));
        }

        public bool FaceViewer {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("faceViewer"));
            set => SetFieldValue("faceViewer", GenericMarshal.ToString(value));
        }

        public ParticleEmitterData ParticleEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("ParticleEmitter"));
            set => SetFieldValue("ParticleEmitter", GenericMarshal.ToString(value));
        }

        public int ParticleDensity {
            get => GenericMarshal.StringTo<int>(GetFieldValue("particleDensity"));
            set => SetFieldValue("particleDensity", GenericMarshal.ToString(value));
        }

        public float ParticleRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("particleRadius"));
            set => SetFieldValue("particleRadius", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<ParticleEmitterData> Emitter {
            get => new DynamicFieldVector<ParticleEmitterData>(
                    this, 
                    "emitter", 
                    4, 
                    val => GenericMarshal.StringTo<ParticleEmitterData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DebrisData Debris {
            get => GenericMarshal.StringTo<DebrisData>(GetFieldValue("Debris"));
            set => SetFieldValue("Debris", GenericMarshal.ToString(value));
        }

        public float DebrisThetaMin {
            get => GenericMarshal.StringTo<float>(GetFieldValue("debrisThetaMin"));
            set => SetFieldValue("debrisThetaMin", GenericMarshal.ToString(value));
        }

        public float DebrisThetaMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("debrisThetaMax"));
            set => SetFieldValue("debrisThetaMax", GenericMarshal.ToString(value));
        }

        public float DebrisPhiMin {
            get => GenericMarshal.StringTo<float>(GetFieldValue("debrisPhiMin"));
            set => SetFieldValue("debrisPhiMin", GenericMarshal.ToString(value));
        }

        public float DebrisPhiMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("debrisPhiMax"));
            set => SetFieldValue("debrisPhiMax", GenericMarshal.ToString(value));
        }

        public int DebrisNum {
            get => GenericMarshal.StringTo<int>(GetFieldValue("debrisNum"));
            set => SetFieldValue("debrisNum", GenericMarshal.ToString(value));
        }

        public int DebrisNumVariance {
            get => GenericMarshal.StringTo<int>(GetFieldValue("debrisNumVariance"));
            set => SetFieldValue("debrisNumVariance", GenericMarshal.ToString(value));
        }

        public float DebrisVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("debrisVelocity"));
            set => SetFieldValue("debrisVelocity", GenericMarshal.ToString(value));
        }

        public float DebrisVelocityVariance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("debrisVelocityVariance"));
            set => SetFieldValue("debrisVelocityVariance", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<ExplosionData> SubExplosion {
            get => new DynamicFieldVector<ExplosionData>(
                    this, 
                    "subExplosion", 
                    5, 
                    val => GenericMarshal.StringTo<ExplosionData>(val),
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

        public float Offset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("offset"));
            set => SetFieldValue("offset", GenericMarshal.ToString(value));
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

        public DynamicFieldVector<Point3F> Sizes {
            get => new DynamicFieldVector<Point3F>(
                    this, 
                    "sizes", 
                    4, 
                    val => GenericMarshal.StringTo<Point3F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public bool ShakeCamera {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("shakeCamera"));
            set => SetFieldValue("shakeCamera", GenericMarshal.ToString(value));
        }

        public Point3F CamShakeFreq {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("camShakeFreq"));
            set => SetFieldValue("camShakeFreq", GenericMarshal.ToString(value));
        }

        public Point3F CamShakeAmp {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("camShakeAmp"));
            set => SetFieldValue("camShakeAmp", GenericMarshal.ToString(value));
        }

        public float CamShakeDuration {
            get => GenericMarshal.StringTo<float>(GetFieldValue("camShakeDuration"));
            set => SetFieldValue("camShakeDuration", GenericMarshal.ToString(value));
        }

        public float CamShakeRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("camShakeRadius"));
            set => SetFieldValue("camShakeRadius", GenericMarshal.ToString(value));
        }

        public float CamShakeFalloff {
            get => GenericMarshal.StringTo<float>(GetFieldValue("camShakeFalloff"));
            set => SetFieldValue("camShakeFalloff", GenericMarshal.ToString(value));
        }

        public float LightStartRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lightStartRadius"));
            set => SetFieldValue("lightStartRadius", GenericMarshal.ToString(value));
        }

        public float LightEndRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lightEndRadius"));
            set => SetFieldValue("lightEndRadius", GenericMarshal.ToString(value));
        }

        public LinearColorF LightStartColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("lightStartColor"));
            set => SetFieldValue("lightStartColor", GenericMarshal.ToString(value));
        }

        public LinearColorF LightEndColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("lightEndColor"));
            set => SetFieldValue("lightEndColor", GenericMarshal.ToString(value));
        }

        public float LightStartBrightness {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lightStartBrightness"));
            set => SetFieldValue("lightStartBrightness", GenericMarshal.ToString(value));
        }

        public float LightEndBrightness {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lightEndBrightness"));
            set => SetFieldValue("lightEndBrightness", GenericMarshal.ToString(value));
        }

        public float LightNormalOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lightNormalOffset"));
            set => SetFieldValue("lightNormalOffset", GenericMarshal.ToString(value));
        }
    }
}