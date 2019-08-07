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

    public unsafe class afxZodiacData : GameBaseData {



        public afxZodiacData(bool pRegister = false)
            : base(pRegister) {
        }

        public afxZodiacData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public afxZodiacData(string pName)
            : this(pName, false) {
        }

        public afxZodiacData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxZodiacData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxZodiacData(SimObject pObj)
            : base(pObj) {
        }

        public afxZodiacData(IntPtr pObj)
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
                                    "fnafxZodiacData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnafxZodiacData_create"), typeof(_Create));
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






        public string Texture {
            get => GenericMarshal.StringTo<string>(GetFieldValue("texture"));
            set => SetFieldValue("texture", GenericMarshal.ToString(value));
        }


        public float Radius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("radius"));
            set => SetFieldValue("radius", GenericMarshal.ToString(value));
        }


        public Point2F VerticalRange {
            get => GenericMarshal.StringTo<Point2F>(GetFieldValue("verticalRange"));
            set => SetFieldValue("verticalRange", GenericMarshal.ToString(value));
        }


        public bool ScaleVerticalRange {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("scaleVerticalRange"));
            set => SetFieldValue("scaleVerticalRange", GenericMarshal.ToString(value));
        }


        public float StartAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("startAngle"));
            set => SetFieldValue("startAngle", GenericMarshal.ToString(value));
        }


        public float RotationRate {
            get => GenericMarshal.StringTo<float>(GetFieldValue("rotationRate"));
            set => SetFieldValue("rotationRate", GenericMarshal.ToString(value));
        }


        public float GrowInTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("growInTime"));
            set => SetFieldValue("growInTime", GenericMarshal.ToString(value));
        }


        public float ShrinkOutTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shrinkOutTime"));
            set => SetFieldValue("shrinkOutTime", GenericMarshal.ToString(value));
        }


        public float GrowthRate {
            get => GenericMarshal.StringTo<float>(GetFieldValue("growthRate"));
            set => SetFieldValue("growthRate", GenericMarshal.ToString(value));
        }


        public LinearColorF Color {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("color"));
            set => SetFieldValue("color", GenericMarshal.ToString(value));
        }


        public afxZodiac_BlendType Blend {
            get => GenericMarshal.StringTo<afxZodiac_BlendType>(GetFieldValue("blend"));
            set => SetFieldValue("blend", GenericMarshal.ToString(value));
        }


        public bool ShowOnTerrain {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showOnTerrain"));
            set => SetFieldValue("showOnTerrain", GenericMarshal.ToString(value));
        }


        public bool ShowOnInteriors {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showOnInteriors"));
            set => SetFieldValue("showOnInteriors", GenericMarshal.ToString(value));
        }


        public bool ShowInReflections {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showInReflections"));
            set => SetFieldValue("showInReflections", GenericMarshal.ToString(value));
        }


        public bool ShowInNonReflections {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showInNonReflections"));
            set => SetFieldValue("showInNonReflections", GenericMarshal.ToString(value));
        }


        public bool TrackOrientConstraint {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("trackOrientConstraint"));
            set => SetFieldValue("trackOrientConstraint", GenericMarshal.ToString(value));
        }


        public bool InteriorHorizontalOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("interiorHorizontalOnly"));
            set => SetFieldValue("interiorHorizontalOnly", GenericMarshal.ToString(value));
        }


        public bool InteriorIgnoreVertical {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("interiorIgnoreVertical"));
            set => SetFieldValue("interiorIgnoreVertical", GenericMarshal.ToString(value));
        }


        public bool InteriorIgnoreBackfaces {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("interiorIgnoreBackfaces"));
            set => SetFieldValue("interiorIgnoreBackfaces", GenericMarshal.ToString(value));
        }


        public bool InteriorIgnoreOpaque {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("interiorIgnoreOpaque"));
            set => SetFieldValue("interiorIgnoreOpaque", GenericMarshal.ToString(value));
        }


        public bool InteriorIgnoreTransparent {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("interiorIgnoreTransparent"));
            set => SetFieldValue("interiorIgnoreTransparent", GenericMarshal.ToString(value));
        }


        public float AltitudeMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("altitudeMax"));
            set => SetFieldValue("altitudeMax", GenericMarshal.ToString(value));
        }


        public float AltitudeFalloff {
            get => GenericMarshal.StringTo<float>(GetFieldValue("altitudeFalloff"));
            set => SetFieldValue("altitudeFalloff", GenericMarshal.ToString(value));
        }


        public bool AltitudeShrinks {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("altitudeShrinks"));
            set => SetFieldValue("altitudeShrinks", GenericMarshal.ToString(value));
        }


        public bool AltitudeFades {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("altitudeFades"));
            set => SetFieldValue("altitudeFades", GenericMarshal.ToString(value));
        }


        public float DistanceMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("distanceMax"));
            set => SetFieldValue("distanceMax", GenericMarshal.ToString(value));
        }


        public float DistanceFalloff {
            get => GenericMarshal.StringTo<float>(GetFieldValue("distanceFalloff"));
            set => SetFieldValue("distanceFalloff", GenericMarshal.ToString(value));
        }


        public bool UseGradientRange {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useGradientRange"));
            set => SetFieldValue("useGradientRange", GenericMarshal.ToString(value));
        }


        public bool PreferDestinationGradients {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("preferDestinationGradients"));
            set => SetFieldValue("preferDestinationGradients", GenericMarshal.ToString(value));
        }


        public Point2F GradientRange {
            get => GenericMarshal.StringTo<Point2F>(GetFieldValue("gradientRange"));
            set => SetFieldValue("gradientRange", GenericMarshal.ToString(value));
        }


        public bool InvertGradientRange {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("invertGradientRange"));
            set => SetFieldValue("invertGradientRange", GenericMarshal.ToString(value));
        }


    }
}
