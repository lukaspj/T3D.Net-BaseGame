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

    public unsafe class ParticleData : SimDataBlock {



        public ParticleData(bool pRegister = false)
            : base(pRegister) {
        }

        public ParticleData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public ParticleData(string pName)
            : this(pName, false) {
        }

        public ParticleData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ParticleData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ParticleData(SimObject pObj)
            : base(pObj) {
        }

        public ParticleData(IntPtr pObj)
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

                //internal delegate void _Reload(IntPtr _this);
                internal delegate void _Reload(IntPtr _this, Reload__Args args);
                private static _Reload _ReloadFunc;
                internal static _Reload Reload() {
                    if (_ReloadFunc == null) {
                        _ReloadFunc =
                            (_Reload)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnParticleData_reload"), typeof(_Reload));
                    }

                    return _ReloadFunc;
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
                                    "fnParticleData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnParticleData_create"), typeof(_Create));
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






        public float DragCoefficient {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dragCoefficient"));
            set => SetFieldValue("dragCoefficient", GenericMarshal.ToString(value));
        }


        public float WindCoefficient {
            get => GenericMarshal.StringTo<float>(GetFieldValue("windCoefficient"));
            set => SetFieldValue("windCoefficient", GenericMarshal.ToString(value));
        }


        public float GravityCoefficient {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gravityCoefficient"));
            set => SetFieldValue("gravityCoefficient", GenericMarshal.ToString(value));
        }


        public float InheritedVelFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("inheritedVelFactor"));
            set => SetFieldValue("inheritedVelFactor", GenericMarshal.ToString(value));
        }


        public float ConstantAcceleration {
            get => GenericMarshal.StringTo<float>(GetFieldValue("constantAcceleration"));
            set => SetFieldValue("constantAcceleration", GenericMarshal.ToString(value));
        }


        public int LifetimeMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lifetimeMS"));
            set => SetFieldValue("lifetimeMS", GenericMarshal.ToString(value));
        }


        public int LifetimeVarianceMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lifetimeVarianceMS"));
            set => SetFieldValue("lifetimeVarianceMS", GenericMarshal.ToString(value));
        }


        public float SpinSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("spinSpeed"));
            set => SetFieldValue("spinSpeed", GenericMarshal.ToString(value));
        }


        public float SpinRandomMin {
            get => GenericMarshal.StringTo<float>(GetFieldValue("spinRandomMin"));
            set => SetFieldValue("spinRandomMin", GenericMarshal.ToString(value));
        }


        public float SpinRandomMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("spinRandomMax"));
            set => SetFieldValue("spinRandomMax", GenericMarshal.ToString(value));
        }


        public bool UseInvAlpha {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useInvAlpha"));
            set => SetFieldValue("useInvAlpha", GenericMarshal.ToString(value));
        }


        public bool AnimateTexture {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("animateTexture"));
            set => SetFieldValue("animateTexture", GenericMarshal.ToString(value));
        }


        public int FramesPerSec {
            get => GenericMarshal.StringTo<int>(GetFieldValue("framesPerSec"));
            set => SetFieldValue("framesPerSec", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<Point2F> TextureCoords {
            get => new DynamicFieldVector<Point2F>(
                    this,
                    "textureCoords",
                    4,
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public Point2I AnimTexTiling {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("animTexTiling"));
            set => SetFieldValue("animTexTiling", GenericMarshal.ToString(value));
        }


        public string AnimTexFrames {
            get => GenericMarshal.StringTo<string>(GetFieldValue("animTexFrames"));
            set => SetFieldValue("animTexFrames", GenericMarshal.ToString(value));
        }


        public string TextureName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("textureName"));
            set => SetFieldValue("textureName", GenericMarshal.ToString(value));
        }


        public string AnimTexName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("animTexName"));
            set => SetFieldValue("animTexName", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<LinearColorF> Colors {
            get => new DynamicFieldVector<LinearColorF>(
                    this,
                    "colors",
                    8,
                    val => GenericMarshal.StringTo<LinearColorF>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> Sizes {
            get => new DynamicFieldVector<float>(
                    this,
                    "sizes",
                    8,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> Times {
            get => new DynamicFieldVector<float>(
                    this,
                    "times",
                    8,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public string TextureExtName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("textureExtName"));
            set => SetFieldValue("textureExtName", GenericMarshal.ToString(value));
        }


        public bool ConstrainPos {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("constrainPos"));
            set => SetFieldValue("constrainPos", GenericMarshal.ToString(value));
        }


        public float Angle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("angle"));
            set => SetFieldValue("angle", GenericMarshal.ToString(value));
        }


        public float AngleVariance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("angleVariance"));
            set => SetFieldValue("angleVariance", GenericMarshal.ToString(value));
        }


        public float SizeBias {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sizeBias"));
            set => SetFieldValue("sizeBias", GenericMarshal.ToString(value));
        }


        public float SpinBias {
            get => GenericMarshal.StringTo<float>(GetFieldValue("spinBias"));
            set => SetFieldValue("spinBias", GenericMarshal.ToString(value));
        }


        public bool RandomizeSpinDir {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("randomizeSpinDir"));
            set => SetFieldValue("randomizeSpinDir", GenericMarshal.ToString(value));
        }


    }
}
