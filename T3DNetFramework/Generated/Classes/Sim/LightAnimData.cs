using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class LightAnimData : SimDataBlock {



        public LightAnimData(bool pRegister = false)
            : base(pRegister) {
        }

        public LightAnimData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public LightAnimData(string pName)
            : this(pName, false) {
        }

        public LightAnimData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public LightAnimData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public LightAnimData(SimObject pObj)
            : base(pObj) {
        }

        public LightAnimData(IntPtr pObj)
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
                                    "fnLightAnimData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnLightAnimData_create"), typeof(_Create));
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






        public DynamicFieldVector<float> OffsetA {
            get => new DynamicFieldVector<float>(
                    this,
                    "offsetA",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> OffsetZ {
            get => new DynamicFieldVector<float>(
                    this,
                    "OffsetZ",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> OffsetPeriod {
            get => new DynamicFieldVector<float>(
                    this,
                    "offsetPeriod",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<string> OffsetKeys {
            get => new DynamicFieldVector<string>(
                    this,
                    "offsetKeys",
                    3,
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<bool> OffsetSmooth {
            get => new DynamicFieldVector<bool>(
                    this,
                    "offsetSmooth",
                    3,
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> RotA {
            get => new DynamicFieldVector<float>(
                    this,
                    "rotA",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> RotZ {
            get => new DynamicFieldVector<float>(
                    this,
                    "rotZ",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> RotPeriod {
            get => new DynamicFieldVector<float>(
                    this,
                    "rotPeriod",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<string> RotKeys {
            get => new DynamicFieldVector<string>(
                    this,
                    "rotKeys",
                    3,
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<bool> RotSmooth {
            get => new DynamicFieldVector<bool>(
                    this,
                    "rotSmooth",
                    3,
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> ColorA {
            get => new DynamicFieldVector<float>(
                    this,
                    "colorA",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> ColorZ {
            get => new DynamicFieldVector<float>(
                    this,
                    "colorZ",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> ColorPeriod {
            get => new DynamicFieldVector<float>(
                    this,
                    "colorPeriod",
                    3,
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<string> ColorKeys {
            get => new DynamicFieldVector<string>(
                    this,
                    "colorKeys",
                    3,
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<bool> ColorSmooth {
            get => new DynamicFieldVector<bool>(
                    this,
                    "colorSmooth",
                    3,
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public float BrightnessA {
            get => GenericMarshal.StringTo<float>(GetFieldValue("brightnessA"));
            set => SetFieldValue("brightnessA", GenericMarshal.ToString(value));
        }


        public float BrightnessZ {
            get => GenericMarshal.StringTo<float>(GetFieldValue("brightnessZ"));
            set => SetFieldValue("brightnessZ", GenericMarshal.ToString(value));
        }


        public float BrightnessPeriod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("brightnessPeriod"));
            set => SetFieldValue("brightnessPeriod", GenericMarshal.ToString(value));
        }


        public string BrightnessKeys {
            get => GenericMarshal.StringTo<string>(GetFieldValue("brightnessKeys"));
            set => SetFieldValue("brightnessKeys", GenericMarshal.ToString(value));
        }


        public bool BrightnessSmooth {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("brightnessSmooth"));
            set => SetFieldValue("brightnessSmooth", GenericMarshal.ToString(value));
        }


    }
}
