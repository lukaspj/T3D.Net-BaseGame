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

    public unsafe class WaterObject : SceneObject {



        public WaterObject(bool pRegister = false)
            : base(pRegister) {
        }

        public WaterObject(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public WaterObject(string pName)
            : this(pName, false) {
        }

        public WaterObject(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public WaterObject(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public WaterObject(SimObject pObj)
            : base(pObj) {
        }

        public WaterObject(IntPtr pObj)
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
                                    "fnWaterObject_staticGetType"), typeof(_StaticGetType));
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
                                    "fnWaterObject_create"), typeof(_Create));
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






        public float Density {
            get => GenericMarshal.StringTo<float>(GetFieldValue("density"));
            set => SetFieldValue("density", GenericMarshal.ToString(value));
        }


        public float Viscosity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("viscosity"));
            set => SetFieldValue("viscosity", GenericMarshal.ToString(value));
        }


        public string LiquidType {
            get => GenericMarshal.StringTo<string>(GetFieldValue("liquidType"));
            set => SetFieldValue("liquidType", GenericMarshal.ToString(value));
        }


        public ColorI BaseColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("baseColor"));
            set => SetFieldValue("baseColor", GenericMarshal.ToString(value));
        }


        public float FresnelBias {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fresnelBias"));
            set => SetFieldValue("fresnelBias", GenericMarshal.ToString(value));
        }


        public float FresnelPower {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fresnelPower"));
            set => SetFieldValue("fresnelPower", GenericMarshal.ToString(value));
        }


        public float SpecularPower {
            get => GenericMarshal.StringTo<float>(GetFieldValue("specularPower"));
            set => SetFieldValue("specularPower", GenericMarshal.ToString(value));
        }


        public LinearColorF SpecularColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("specularColor"));
            set => SetFieldValue("specularColor", GenericMarshal.ToString(value));
        }


        public bool Emissive {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("emissive"));
            set => SetFieldValue("emissive", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<Point2F> WaveDir {
            get => new DynamicFieldVector<Point2F>(
                    this,
                    "waveDir",
                    3,
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> WaveSpeed {
            get => new DynamicFieldVector<float>(
                    this,
                    "waveSpeed",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> WaveMagnitude {
            get => new DynamicFieldVector<float>(
                    this,
                    "waveMagnitude",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public float OverallWaveMagnitude {
            get => GenericMarshal.StringTo<float>(GetFieldValue("overallWaveMagnitude"));
            set => SetFieldValue("overallWaveMagnitude", GenericMarshal.ToString(value));
        }


        public string RippleTex {
            get => GenericMarshal.StringTo<string>(GetFieldValue("rippleTex"));
            set => SetFieldValue("rippleTex", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<Point2F> RippleDir {
            get => new DynamicFieldVector<Point2F>(
                    this,
                    "rippleDir",
                    3,
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> RippleSpeed {
            get => new DynamicFieldVector<float>(
                    this,
                    "rippleSpeed",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<Point2F> RippleTexScale {
            get => new DynamicFieldVector<Point2F>(
                    this,
                    "rippleTexScale",
                    3,
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> RippleMagnitude {
            get => new DynamicFieldVector<float>(
                    this,
                    "rippleMagnitude",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public float OverallRippleMagnitude {
            get => GenericMarshal.StringTo<float>(GetFieldValue("overallRippleMagnitude"));
            set => SetFieldValue("overallRippleMagnitude", GenericMarshal.ToString(value));
        }


        public string FoamTex {
            get => GenericMarshal.StringTo<string>(GetFieldValue("foamTex"));
            set => SetFieldValue("foamTex", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<Point2F> FoamDir {
            get => new DynamicFieldVector<Point2F>(
                    this,
                    "foamDir",
                    2,
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> FoamSpeed {
            get => new DynamicFieldVector<float>(
                    this,
                    "foamSpeed",
                    2,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<Point2F> FoamTexScale {
            get => new DynamicFieldVector<Point2F>(
                    this,
                    "foamTexScale",
                    2,
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> FoamOpacity {
            get => new DynamicFieldVector<float>(
                    this,
                    "foamOpacity",
                    2,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public float OverallFoamOpacity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("overallFoamOpacity"));
            set => SetFieldValue("overallFoamOpacity", GenericMarshal.ToString(value));
        }


        public float FoamMaxDepth {
            get => GenericMarshal.StringTo<float>(GetFieldValue("foamMaxDepth"));
            set => SetFieldValue("foamMaxDepth", GenericMarshal.ToString(value));
        }


        public float FoamAmbientLerp {
            get => GenericMarshal.StringTo<float>(GetFieldValue("foamAmbientLerp"));
            set => SetFieldValue("foamAmbientLerp", GenericMarshal.ToString(value));
        }


        public float FoamRippleInfluence {
            get => GenericMarshal.StringTo<float>(GetFieldValue("foamRippleInfluence"));
            set => SetFieldValue("foamRippleInfluence", GenericMarshal.ToString(value));
        }


        public string Cubemap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("cubemap"));
            set => SetFieldValue("cubemap", GenericMarshal.ToString(value));
        }


        public bool FullReflect {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fullReflect"));
            set => SetFieldValue("fullReflect", GenericMarshal.ToString(value));
        }


        public float Reflectivity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reflectivity"));
            set => SetFieldValue("reflectivity", GenericMarshal.ToString(value));
        }


        public float ReflectPriority {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reflectPriority"));
            set => SetFieldValue("reflectPriority", GenericMarshal.ToString(value));
        }


        public int ReflectMaxRateMs {
            get => GenericMarshal.StringTo<int>(GetFieldValue("reflectMaxRateMs"));
            set => SetFieldValue("reflectMaxRateMs", GenericMarshal.ToString(value));
        }


        public float ReflectDetailAdjust {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reflectDetailAdjust"));
            set => SetFieldValue("reflectDetailAdjust", GenericMarshal.ToString(value));
        }


        public bool ReflectNormalUp {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("reflectNormalUp"));
            set => SetFieldValue("reflectNormalUp", GenericMarshal.ToString(value));
        }


        public bool UseOcclusionQuery {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useOcclusionQuery"));
            set => SetFieldValue("useOcclusionQuery", GenericMarshal.ToString(value));
        }


        public int ReflectTexSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("reflectTexSize"));
            set => SetFieldValue("reflectTexSize", GenericMarshal.ToString(value));
        }


        public float WaterFogDensity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("waterFogDensity"));
            set => SetFieldValue("waterFogDensity", GenericMarshal.ToString(value));
        }


        public float WaterFogDensityOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("waterFogDensityOffset"));
            set => SetFieldValue("waterFogDensityOffset", GenericMarshal.ToString(value));
        }


        public float WetDepth {
            get => GenericMarshal.StringTo<float>(GetFieldValue("wetDepth"));
            set => SetFieldValue("wetDepth", GenericMarshal.ToString(value));
        }


        public float WetDarkening {
            get => GenericMarshal.StringTo<float>(GetFieldValue("wetDarkening"));
            set => SetFieldValue("wetDarkening", GenericMarshal.ToString(value));
        }


        public string DepthGradientTex {
            get => GenericMarshal.StringTo<string>(GetFieldValue("depthGradientTex"));
            set => SetFieldValue("depthGradientTex", GenericMarshal.ToString(value));
        }


        public float DepthGradientMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("depthGradientMax"));
            set => SetFieldValue("depthGradientMax", GenericMarshal.ToString(value));
        }


        public float DistortStartDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("distortStartDist"));
            set => SetFieldValue("distortStartDist", GenericMarshal.ToString(value));
        }


        public float DistortEndDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("distortEndDist"));
            set => SetFieldValue("distortEndDist", GenericMarshal.ToString(value));
        }


        public float DistortFullDepth {
            get => GenericMarshal.StringTo<float>(GetFieldValue("distortFullDepth"));
            set => SetFieldValue("distortFullDepth", GenericMarshal.ToString(value));
        }


        public float Clarity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("clarity"));
            set => SetFieldValue("clarity", GenericMarshal.ToString(value));
        }


        public ColorI UnderwaterColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("underwaterColor"));
            set => SetFieldValue("underwaterColor", GenericMarshal.ToString(value));
        }


        public SFXAmbience SoundAmbience {
            get => GenericMarshal.StringTo<SFXAmbience>(GetFieldValue("soundAmbience"));
            set => SetFieldValue("soundAmbience", GenericMarshal.ToString(value));
        }


    }
}
