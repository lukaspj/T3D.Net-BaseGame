using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class Precipitation : GameBase {



        public Precipitation(bool pRegister = false)
            : base(pRegister) {
        }

        public Precipitation(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public Precipitation(string pName)
            : this(pName, false) {
        }

        public Precipitation(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Precipitation(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Precipitation(SimObject pObj)
            : base(pObj) {
        }

        public Precipitation(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetTurbulence__Args
                {

				   internal float max;

				   internal float speed;

				   internal float seconds;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetTurbulence(IntPtr _this, float max, float speed, float seconds);
                internal delegate void _SetTurbulence(IntPtr _this, SetTurbulence__Args args);
                private static _SetTurbulence _SetTurbulenceFunc;
                internal static _SetTurbulence SetTurbulence() {
                    if (_SetTurbulenceFunc == null) {
                        _SetTurbulenceFunc =
                            (_SetTurbulence)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPrecipitation_setTurbulence"), typeof(_SetTurbulence));
                    }

                    return _SetTurbulenceFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ModifyStorm__Args
                {

				   internal float percentage;

				   internal float seconds;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ModifyStorm(IntPtr _this, float percentage, float seconds);
                internal delegate void _ModifyStorm(IntPtr _this, ModifyStorm__Args args);
                private static _ModifyStorm _ModifyStormFunc;
                internal static _ModifyStorm ModifyStorm() {
                    if (_ModifyStormFunc == null) {
                        _ModifyStormFunc =
                            (_ModifyStorm)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPrecipitation_modifyStorm"), typeof(_ModifyStorm));
                    }

                    return _ModifyStormFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetPercentage__Args
                {

				   internal float percentage;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetPercentage(IntPtr _this, float percentage);
                internal delegate void _SetPercentage(IntPtr _this, SetPercentage__Args args);
                private static _SetPercentage _SetPercentageFunc;
                internal static _SetPercentage SetPercentage() {
                    if (_SetPercentageFunc == null) {
                        _SetPercentageFunc =
                            (_SetPercentage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPrecipitation_setPercentage"), typeof(_SetPercentage));
                    }

                    return _SetPercentageFunc;
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
                                    "fnPrecipitation_staticGetType"), typeof(_StaticGetType));
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
                                    "fnPrecipitation_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void SetTurbulence(float max = 1f, float speed = 5f, float seconds = 5f) {

                                                                                    InternalUnsafeMethods.SetTurbulence__Args _args = new InternalUnsafeMethods.SetTurbulence__Args() {
                        max = max,
                        speed = speed,
                        seconds = seconds,
                     };
                     InternalUnsafeMethods.SetTurbulence()(ObjectPtr, _args);

                  }



                  public void ModifyStorm(float percentage = 1f, float seconds = 5f) {

                                                               InternalUnsafeMethods.ModifyStorm__Args _args = new InternalUnsafeMethods.ModifyStorm__Args() {
                        percentage = percentage,
                        seconds = seconds,
                     };
                     InternalUnsafeMethods.ModifyStorm()(ObjectPtr, _args);

                  }



                  public void SetPercentage(float percentage = 1f) {

                                          InternalUnsafeMethods.SetPercentage__Args _args = new InternalUnsafeMethods.SetPercentage__Args() {
                        percentage = percentage,
                     };
                     InternalUnsafeMethods.SetPercentage()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public int NumDrops {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numDrops"));
            set => SetFieldValue("numDrops", GenericMarshal.ToString(value));
        }


        public float BoxWidth {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxWidth"));
            set => SetFieldValue("boxWidth", GenericMarshal.ToString(value));
        }


        public float BoxHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxHeight"));
            set => SetFieldValue("boxHeight", GenericMarshal.ToString(value));
        }


        public float DropSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dropSize"));
            set => SetFieldValue("dropSize", GenericMarshal.ToString(value));
        }


        public float SplashSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashSize"));
            set => SetFieldValue("splashSize", GenericMarshal.ToString(value));
        }


        public int SplashMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("splashMS"));
            set => SetFieldValue("splashMS", GenericMarshal.ToString(value));
        }


        public bool AnimateSplashes {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("animateSplashes"));
            set => SetFieldValue("animateSplashes", GenericMarshal.ToString(value));
        }


        public int DropAnimateMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("dropAnimateMS"));
            set => SetFieldValue("dropAnimateMS", GenericMarshal.ToString(value));
        }


        public float FadeDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeDist"));
            set => SetFieldValue("fadeDist", GenericMarshal.ToString(value));
        }


        public float FadeDistEnd {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeDistEnd"));
            set => SetFieldValue("fadeDistEnd", GenericMarshal.ToString(value));
        }


        public bool UseTrueBillboards {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useTrueBillboards"));
            set => SetFieldValue("useTrueBillboards", GenericMarshal.ToString(value));
        }


        public bool UseLighting {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useLighting"));
            set => SetFieldValue("useLighting", GenericMarshal.ToString(value));
        }


        public LinearColorF GlowIntensity {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("glowIntensity"));
            set => SetFieldValue("glowIntensity", GenericMarshal.ToString(value));
        }


        public bool Reflect {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("reflect"));
            set => SetFieldValue("reflect", GenericMarshal.ToString(value));
        }


        public bool RotateWithCamVel {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("rotateWithCamVel"));
            set => SetFieldValue("rotateWithCamVel", GenericMarshal.ToString(value));
        }


        public bool DoCollision {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("doCollision"));
            set => SetFieldValue("doCollision", GenericMarshal.ToString(value));
        }


        public bool HitPlayers {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("hitPlayers"));
            set => SetFieldValue("hitPlayers", GenericMarshal.ToString(value));
        }


        public bool HitVehicles {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("hitVehicles"));
            set => SetFieldValue("hitVehicles", GenericMarshal.ToString(value));
        }


        public bool FollowCam {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("followCam"));
            set => SetFieldValue("followCam", GenericMarshal.ToString(value));
        }


        public bool UseWind {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useWind"));
            set => SetFieldValue("useWind", GenericMarshal.ToString(value));
        }


        public float MinSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minSpeed"));
            set => SetFieldValue("minSpeed", GenericMarshal.ToString(value));
        }


        public float MaxSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSpeed"));
            set => SetFieldValue("maxSpeed", GenericMarshal.ToString(value));
        }


        public float MinMass {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minMass"));
            set => SetFieldValue("minMass", GenericMarshal.ToString(value));
        }


        public float MaxMass {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxMass"));
            set => SetFieldValue("maxMass", GenericMarshal.ToString(value));
        }


        public bool UseTurbulence {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useTurbulence"));
            set => SetFieldValue("useTurbulence", GenericMarshal.ToString(value));
        }


        public float MaxTurbulence {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxTurbulence"));
            set => SetFieldValue("maxTurbulence", GenericMarshal.ToString(value));
        }


        public float TurbulenceSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("turbulenceSpeed"));
            set => SetFieldValue("turbulenceSpeed", GenericMarshal.ToString(value));
        }


    }
}
