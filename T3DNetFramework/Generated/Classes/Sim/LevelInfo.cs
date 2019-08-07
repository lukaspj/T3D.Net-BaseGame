using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class LevelInfo : NetObject {



        public LevelInfo(bool pRegister = false)
            : base(pRegister) {
        }

        public LevelInfo(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public LevelInfo(string pName)
            : this(pName, false) {
        }

        public LevelInfo(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public LevelInfo(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public LevelInfo(SimObject pObj)
            : base(pObj) {
        }

        public LevelInfo(IntPtr pObj)
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
                                    "fnLevelInfo_staticGetType"), typeof(_StaticGetType));
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
                                    "fnLevelInfo_create"), typeof(_Create));
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






        public float NearClip {
            get => GenericMarshal.StringTo<float>(GetFieldValue("nearClip"));
            set => SetFieldValue("nearClip", GenericMarshal.ToString(value));
        }


        public float VisibleDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("visibleDistance"));
            set => SetFieldValue("visibleDistance", GenericMarshal.ToString(value));
        }


        public float VisibleGhostDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("visibleGhostDistance"));
            set => SetFieldValue("visibleGhostDistance", GenericMarshal.ToString(value));
        }


        public float DecalBias {
            get => GenericMarshal.StringTo<float>(GetFieldValue("decalBias"));
            set => SetFieldValue("decalBias", GenericMarshal.ToString(value));
        }


        public LinearColorF FogColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("fogColor"));
            set => SetFieldValue("fogColor", GenericMarshal.ToString(value));
        }


        public float FogDensity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fogDensity"));
            set => SetFieldValue("fogDensity", GenericMarshal.ToString(value));
        }


        public float FogDensityOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fogDensityOffset"));
            set => SetFieldValue("fogDensityOffset", GenericMarshal.ToString(value));
        }


        public float FogAtmosphereHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fogAtmosphereHeight"));
            set => SetFieldValue("fogAtmosphereHeight", GenericMarshal.ToString(value));
        }


        public ColorI CanvasClearColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("canvasClearColor"));
            set => SetFieldValue("canvasClearColor", GenericMarshal.ToString(value));
        }


        public float AmbientLightBlendPhase {
            get => GenericMarshal.StringTo<float>(GetFieldValue("ambientLightBlendPhase"));
            set => SetFieldValue("ambientLightBlendPhase", GenericMarshal.ToString(value));
        }


        public EaseF AmbientLightBlendCurve {
            get => GenericMarshal.StringTo<EaseF>(GetFieldValue("ambientLightBlendCurve"));
            set => SetFieldValue("ambientLightBlendCurve", GenericMarshal.ToString(value));
        }


        public bool AdvancedLightmapSupport {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("advancedLightmapSupport"));
            set => SetFieldValue("advancedLightmapSupport", GenericMarshal.ToString(value));
        }


        public string AccuTexture {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AccuTexture"));
            set => SetFieldValue("AccuTexture", GenericMarshal.ToString(value));
        }


        public SFXAmbience SoundAmbience {
            get => GenericMarshal.StringTo<SFXAmbience>(GetFieldValue("soundAmbience"));
            set => SetFieldValue("soundAmbience", GenericMarshal.ToString(value));
        }


        public SFXDistanceModel SoundDistanceModel {
            get => GenericMarshal.StringTo<SFXDistanceModel>(GetFieldValue("soundDistanceModel"));
            set => SetFieldValue("soundDistanceModel", GenericMarshal.ToString(value));
        }


    }
}
