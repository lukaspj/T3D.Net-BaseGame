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
    public unsafe class ParticleEmitterData : GameBaseData {
        public ParticleEmitterData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ParticleEmitterData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ParticleEmitterData(string pName) 
            : this(pName, false) {
        }
        
        public ParticleEmitterData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ParticleEmitterData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ParticleEmitterData(SimObject pObj) 
            : base(pObj) {
        }
        
        public ParticleEmitterData(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Reload__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reload(IntPtr _this, Reload__Args args);
            private static _Reload _ReloadFunc;
            internal static _Reload Reload() {
                if (_ReloadFunc == null) {
                    _ReloadFunc =
                        (_Reload)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnParticleEmitterData_reload"), typeof(_Reload));
                }
                
                return _ReloadFunc;
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
                                "fnParticleEmitterData_staticGetType"), typeof(_StaticGetType));
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
                                "fnParticleEmitterData_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void Reload() {
             InternalUnsafeMethods.Reload__Args _args = new InternalUnsafeMethods.Reload__Args() {
             };
             InternalUnsafeMethods.Reload()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public int EjectionPeriodMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("ejectionPeriodMS"));
            set => SetFieldValue("ejectionPeriodMS", GenericMarshal.ToString(value));
        }

        public int PeriodVarianceMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("periodVarianceMS"));
            set => SetFieldValue("periodVarianceMS", GenericMarshal.ToString(value));
        }

        public float EjectionVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("ejectionVelocity"));
            set => SetFieldValue("ejectionVelocity", GenericMarshal.ToString(value));
        }

        public float VelocityVariance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("velocityVariance"));
            set => SetFieldValue("velocityVariance", GenericMarshal.ToString(value));
        }

        public float EjectionOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("ejectionOffset"));
            set => SetFieldValue("ejectionOffset", GenericMarshal.ToString(value));
        }

        public float EjectionOffsetVariance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("ejectionOffsetVariance"));
            set => SetFieldValue("ejectionOffsetVariance", GenericMarshal.ToString(value));
        }

        public float ThetaMin {
            get => GenericMarshal.StringTo<float>(GetFieldValue("thetaMin"));
            set => SetFieldValue("thetaMin", GenericMarshal.ToString(value));
        }

        public float ThetaMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("thetaMax"));
            set => SetFieldValue("thetaMax", GenericMarshal.ToString(value));
        }

        public float PhiReferenceVel {
            get => GenericMarshal.StringTo<float>(GetFieldValue("phiReferenceVel"));
            set => SetFieldValue("phiReferenceVel", GenericMarshal.ToString(value));
        }

        public float PhiVariance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("phiVariance"));
            set => SetFieldValue("phiVariance", GenericMarshal.ToString(value));
        }

        public float SoftnessDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("softnessDistance"));
            set => SetFieldValue("softnessDistance", GenericMarshal.ToString(value));
        }

        public float AmbientFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("ambientFactor"));
            set => SetFieldValue("ambientFactor", GenericMarshal.ToString(value));
        }

        public bool OverrideAdvance {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("overrideAdvance"));
            set => SetFieldValue("overrideAdvance", GenericMarshal.ToString(value));
        }

        public bool OrientParticles {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("orientParticles"));
            set => SetFieldValue("orientParticles", GenericMarshal.ToString(value));
        }

        public bool OrientOnVelocity {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("orientOnVelocity"));
            set => SetFieldValue("orientOnVelocity", GenericMarshal.ToString(value));
        }

        public string Particles {
            get => GenericMarshal.StringTo<string>(GetFieldValue("particles"));
            set => SetFieldValue("particles", GenericMarshal.ToString(value));
        }

        public int LifetimeMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lifetimeMS"));
            set => SetFieldValue("lifetimeMS", GenericMarshal.ToString(value));
        }

        public int LifetimeVarianceMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lifetimeVarianceMS"));
            set => SetFieldValue("lifetimeVarianceMS", GenericMarshal.ToString(value));
        }

        public bool UseEmitterSizes {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useEmitterSizes"));
            set => SetFieldValue("useEmitterSizes", GenericMarshal.ToString(value));
        }

        public bool UseEmitterColors {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useEmitterColors"));
            set => SetFieldValue("useEmitterColors", GenericMarshal.ToString(value));
        }

        public ParticleBlendStyle BlendStyle {
            get => GenericMarshal.StringTo<ParticleBlendStyle>(GetFieldValue("blendStyle"));
            set => SetFieldValue("blendStyle", GenericMarshal.ToString(value));
        }

        public bool SortParticles {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("sortParticles"));
            set => SetFieldValue("sortParticles", GenericMarshal.ToString(value));
        }

        public bool ReverseOrder {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("reverseOrder"));
            set => SetFieldValue("reverseOrder", GenericMarshal.ToString(value));
        }

        public string TextureName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("textureName"));
            set => SetFieldValue("textureName", GenericMarshal.ToString(value));
        }

        public bool AlignParticles {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("alignParticles"));
            set => SetFieldValue("alignParticles", GenericMarshal.ToString(value));
        }

        public Point3F AlignDirection {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("alignDirection"));
            set => SetFieldValue("alignDirection", GenericMarshal.ToString(value));
        }

        public bool HighResOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("highResOnly"));
            set => SetFieldValue("highResOnly", GenericMarshal.ToString(value));
        }

        public bool RenderReflection {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderReflection"));
            set => SetFieldValue("renderReflection", GenericMarshal.ToString(value));
        }

        public bool Glow {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("glow"));
            set => SetFieldValue("glow", GenericMarshal.ToString(value));
        }

        public bool EjectionInvert {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ejectionInvert"));
            set => SetFieldValue("ejectionInvert", GenericMarshal.ToString(value));
        }

        public bool FadeColor {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fadeColor"));
            set => SetFieldValue("fadeColor", GenericMarshal.ToString(value));
        }

        public bool FadeAlpha {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fadeAlpha"));
            set => SetFieldValue("fadeAlpha", GenericMarshal.ToString(value));
        }

        public bool FadeSize {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fadeSize"));
            set => SetFieldValue("fadeSize", GenericMarshal.ToString(value));
        }

        public bool UseEmitterTransform {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useEmitterTransform"));
            set => SetFieldValue("useEmitterTransform", GenericMarshal.ToString(value));
        }

        public afxParticlePoolData PoolData {
            get => GenericMarshal.StringTo<afxParticlePoolData>(GetFieldValue("poolData"));
            set => SetFieldValue("poolData", GenericMarshal.ToString(value));
        }

        public int PoolIndex {
            get => GenericMarshal.StringTo<int>(GetFieldValue("poolIndex"));
            set => SetFieldValue("poolIndex", GenericMarshal.ToString(value));
        }

        public bool PoolDepthFade {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("poolDepthFade"));
            set => SetFieldValue("poolDepthFade", GenericMarshal.ToString(value));
        }

        public bool PoolRadialFade {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("poolRadialFade"));
            set => SetFieldValue("poolRadialFade", GenericMarshal.ToString(value));
        }
    }
}