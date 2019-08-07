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

    public unsafe class LightBase : SceneObject {



        public LightBase(bool pRegister = false)
            : base(pRegister) {
        }

        public LightBase(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public LightBase(string pName)
            : this(pName, false) {
        }

        public LightBase(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public LightBase(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public LightBase(SimObject pObj)
            : base(pObj) {
        }

        public LightBase(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct PauseAnimation__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _PauseAnimation(IntPtr _this);
                internal delegate void _PauseAnimation(IntPtr _this, PauseAnimation__Args args);
                private static _PauseAnimation _PauseAnimationFunc;
                internal static _PauseAnimation PauseAnimation() {
                    if (_PauseAnimationFunc == null) {
                        _PauseAnimationFunc =
                            (_PauseAnimation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnLightBase_pauseAnimation"), typeof(_PauseAnimation));
                    }

                    return _PauseAnimationFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct PlayAnimation__Args
                {

				   internal string anim;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _PlayAnimation(IntPtr _this, string anim);
                internal delegate void _PlayAnimation(IntPtr _this, PlayAnimation__Args args);
                private static _PlayAnimation _PlayAnimationFunc;
                internal static _PlayAnimation PlayAnimation() {
                    if (_PlayAnimationFunc == null) {
                        _PlayAnimationFunc =
                            (_PlayAnimation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnLightBase_playAnimation"), typeof(_PlayAnimation));
                    }

                    return _PlayAnimationFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetLightEnabled__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetLightEnabled(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _SetLightEnabled(IntPtr _this, SetLightEnabled__Args args);
                private static _SetLightEnabled _SetLightEnabledFunc;
                internal static _SetLightEnabled SetLightEnabled() {
                    if (_SetLightEnabledFunc == null) {
                        _SetLightEnabledFunc =
                            (_SetLightEnabled)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnLightBase_setLightEnabled"), typeof(_SetLightEnabled));
                    }

                    return _SetLightEnabledFunc;
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
                                    "fnLightBase_staticGetType"), typeof(_StaticGetType));
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
                                    "fnLightBase_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void PauseAnimation() {

                     InternalUnsafeMethods.PauseAnimation__Args _args = new InternalUnsafeMethods.PauseAnimation__Args() {
                     };
                     InternalUnsafeMethods.PauseAnimation()(ObjectPtr, _args);

                  }



                  public void PlayAnimation(string anim = "") {

                                          InternalUnsafeMethods.PlayAnimation__Args _args = new InternalUnsafeMethods.PlayAnimation__Args() {
                        anim = anim,
                     };
                     InternalUnsafeMethods.PlayAnimation()(ObjectPtr, _args);

                  }



                  public void SetLightEnabled(bool state) {

                                          InternalUnsafeMethods.SetLightEnabled__Args _args = new InternalUnsafeMethods.SetLightEnabled__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.SetLightEnabled()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public bool IsEnabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isEnabled"));
            set => SetFieldValue("isEnabled", GenericMarshal.ToString(value));
        }


        public LinearColorF Color {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("color"));
            set => SetFieldValue("color", GenericMarshal.ToString(value));
        }


        public float Brightness {
            get => GenericMarshal.StringTo<float>(GetFieldValue("brightness"));
            set => SetFieldValue("brightness", GenericMarshal.ToString(value));
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


        public float Priority {
            get => GenericMarshal.StringTo<float>(GetFieldValue("priority"));
            set => SetFieldValue("priority", GenericMarshal.ToString(value));
        }


        public bool Animate {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("animate"));
            set => SetFieldValue("animate", GenericMarshal.ToString(value));
        }


        public LightAnimData AnimationType {
            get => GenericMarshal.StringTo<LightAnimData>(GetFieldValue("animationType"));
            set => SetFieldValue("animationType", GenericMarshal.ToString(value));
        }


        public float AnimationPeriod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("animationPeriod"));
            set => SetFieldValue("animationPeriod", GenericMarshal.ToString(value));
        }


        public float AnimationPhase {
            get => GenericMarshal.StringTo<float>(GetFieldValue("animationPhase"));
            set => SetFieldValue("animationPhase", GenericMarshal.ToString(value));
        }


        public LightFlareData FlareType {
            get => GenericMarshal.StringTo<LightFlareData>(GetFieldValue("flareType"));
            set => SetFieldValue("flareType", GenericMarshal.ToString(value));
        }


        public float FlareScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("flareScale"));
            set => SetFieldValue("flareScale", GenericMarshal.ToString(value));
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
