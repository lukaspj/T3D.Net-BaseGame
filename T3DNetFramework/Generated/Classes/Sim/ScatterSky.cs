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

    public unsafe class ScatterSky : SceneObject {



        public ScatterSky(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ScatterSky(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ScatterSky(string pName) 
            : this(pName, false) {
        }
        
        public ScatterSky(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ScatterSky(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ScatterSky(SimObject pObj) 
            : base(pObj) {
        }
        
        public ScatterSky(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ApplyChanges__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ApplyChanges(IntPtr _this);
                internal delegate void _ApplyChanges(IntPtr _this, ApplyChanges__Args args);
                private static _ApplyChanges _ApplyChangesFunc;
                internal static _ApplyChanges ApplyChanges() {
                    if (_ApplyChangesFunc == null) {
                        _ApplyChangesFunc =
                            (_ApplyChanges)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnScatterSky_applyChanges"), typeof(_ApplyChanges));
                    }
                    
                    return _ApplyChangesFunc;
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
                                    "fnScatterSky_staticGetType"), typeof(_StaticGetType));
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
                                    "fnScatterSky_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void ApplyChanges() {
        
                     InternalUnsafeMethods.ApplyChanges__Args _args = new InternalUnsafeMethods.ApplyChanges__Args() {
                     };
                     InternalUnsafeMethods.ApplyChanges()(ObjectPtr, _args);
                                 
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public float SkyBrightness {
            get => GenericMarshal.StringTo<float>(GetFieldValue("skyBrightness"));
            set => SetFieldValue("skyBrightness", GenericMarshal.ToString(value));
        }


        public float SunSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sunSize"));
            set => SetFieldValue("sunSize", GenericMarshal.ToString(value));
        }


        public float ColorizeAmount {
            get => GenericMarshal.StringTo<float>(GetFieldValue("colorizeAmount"));
            set => SetFieldValue("colorizeAmount", GenericMarshal.ToString(value));
        }


        public LinearColorF Colorize {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("colorize"));
            set => SetFieldValue("colorize", GenericMarshal.ToString(value));
        }


        public float RayleighScattering {
            get => GenericMarshal.StringTo<float>(GetFieldValue("rayleighScattering"));
            set => SetFieldValue("rayleighScattering", GenericMarshal.ToString(value));
        }


        public LinearColorF SunScale {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("sunScale"));
            set => SetFieldValue("sunScale", GenericMarshal.ToString(value));
        }


        public LinearColorF AmbientScale {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("ambientScale"));
            set => SetFieldValue("ambientScale", GenericMarshal.ToString(value));
        }


        public LinearColorF FogScale {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("fogScale"));
            set => SetFieldValue("fogScale", GenericMarshal.ToString(value));
        }


        public float Exposure {
            get => GenericMarshal.StringTo<float>(GetFieldValue("exposure"));
            set => SetFieldValue("exposure", GenericMarshal.ToString(value));
        }


        public float ZOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("zOffset"));
            set => SetFieldValue("zOffset", GenericMarshal.ToString(value));
        }


        public float Azimuth {
            get => GenericMarshal.StringTo<float>(GetFieldValue("azimuth"));
            set => SetFieldValue("azimuth", GenericMarshal.ToString(value));
        }


        public float Elevation {
            get => GenericMarshal.StringTo<float>(GetFieldValue("elevation"));
            set => SetFieldValue("elevation", GenericMarshal.ToString(value));
        }


        public float MoonAzimuth {
            get => GenericMarshal.StringTo<float>(GetFieldValue("moonAzimuth"));
            set => SetFieldValue("moonAzimuth", GenericMarshal.ToString(value));
        }


        public float MoonElevation {
            get => GenericMarshal.StringTo<float>(GetFieldValue("moonElevation"));
            set => SetFieldValue("moonElevation", GenericMarshal.ToString(value));
        }


        public bool CastShadows {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("castShadows"));
            set => SetFieldValue("castShadows", GenericMarshal.ToString(value));
        }


        public int StaticRefreshFreq {
            get => GenericMarshal.StringTo<int>(GetFieldValue("staticRefreshFreq"));
            set => SetFieldValue("staticRefreshFreq", GenericMarshal.ToString(value));
        }


        public int DynamicRefreshFreq {
            get => GenericMarshal.StringTo<int>(GetFieldValue("dynamicRefreshFreq"));
            set => SetFieldValue("dynamicRefreshFreq", GenericMarshal.ToString(value));
        }


        public float Brightness {
            get => GenericMarshal.StringTo<float>(GetFieldValue("brightness"));
            set => SetFieldValue("brightness", GenericMarshal.ToString(value));
        }


        public LightFlareData FlareType {
            get => GenericMarshal.StringTo<LightFlareData>(GetFieldValue("flareType"));
            set => SetFieldValue("flareType", GenericMarshal.ToString(value));
        }


        public float FlareScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("flareScale"));
            set => SetFieldValue("flareScale", GenericMarshal.ToString(value));
        }


        public LinearColorF NightColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("nightColor"));
            set => SetFieldValue("nightColor", GenericMarshal.ToString(value));
        }


        public LinearColorF NightFogColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("nightFogColor"));
            set => SetFieldValue("nightFogColor", GenericMarshal.ToString(value));
        }


        public bool MoonEnabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("moonEnabled"));
            set => SetFieldValue("moonEnabled", GenericMarshal.ToString(value));
        }


        public string MoonMat {
            get => GenericMarshal.StringTo<string>(GetFieldValue("moonMat"));
            set => SetFieldValue("moonMat", GenericMarshal.ToString(value));
        }


        public float MoonScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("moonScale"));
            set => SetFieldValue("moonScale", GenericMarshal.ToString(value));
        }


        public LinearColorF MoonLightColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("moonLightColor"));
            set => SetFieldValue("moonLightColor", GenericMarshal.ToString(value));
        }


        public bool UseNightCubemap {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useNightCubemap"));
            set => SetFieldValue("useNightCubemap", GenericMarshal.ToString(value));
        }


        public string NightCubemap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("nightCubemap"));
            set => SetFieldValue("nightCubemap", GenericMarshal.ToString(value));
        }


        public Point3F AttenuationRatio {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("attenuationRatio"));
            set => SetFieldValue("attenuationRatio", GenericMarshal.ToString(value));
        }


        public ShadowType ShadowType {
            get => GenericMarshal.StringTo<ShadowType>(GetFieldValue("shadowType"));
            set => SetFieldValue("shadowType", GenericMarshal.ToString(value));
        }


        public string Cookie {
            get => GenericMarshal.StringTo<string>(GetFieldValue("cookie"));
            set => SetFieldValue("cookie", GenericMarshal.ToString(value));
        }


        public int TexSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("texSize"));
            set => SetFieldValue("texSize", GenericMarshal.ToString(value));
        }


        public Point4F OverDarkFactor {
            get => GenericMarshal.StringTo<Point4F>(GetFieldValue("overDarkFactor"));
            set => SetFieldValue("overDarkFactor", GenericMarshal.ToString(value));
        }


        public float ShadowDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shadowDistance"));
            set => SetFieldValue("shadowDistance", GenericMarshal.ToString(value));
        }


        public float ShadowSoftness {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shadowSoftness"));
            set => SetFieldValue("shadowSoftness", GenericMarshal.ToString(value));
        }


        public int NumSplits {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numSplits"));
            set => SetFieldValue("numSplits", GenericMarshal.ToString(value));
        }


        public float LogWeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("logWeight"));
            set => SetFieldValue("logWeight", GenericMarshal.ToString(value));
        }


        public float FadeStartDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeStartDistance"));
            set => SetFieldValue("fadeStartDistance", GenericMarshal.ToString(value));
        }


        public bool LastSplitTerrainOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("lastSplitTerrainOnly"));
            set => SetFieldValue("lastSplitTerrainOnly", GenericMarshal.ToString(value));
        }


        public bool RepresentedInLightmap {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("representedInLightmap"));
            set => SetFieldValue("representedInLightmap", GenericMarshal.ToString(value));
        }


        public LinearColorF ShadowDarkenColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("shadowDarkenColor"));
            set => SetFieldValue("shadowDarkenColor", GenericMarshal.ToString(value));
        }


        public bool IncludeLightmappedGeometryInShadow {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("includeLightmappedGeometryInShadow"));
            set => SetFieldValue("includeLightmappedGeometryInShadow", GenericMarshal.ToString(value));
        }


    }
}