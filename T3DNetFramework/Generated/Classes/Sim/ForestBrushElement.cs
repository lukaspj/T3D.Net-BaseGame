using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class ForestBrushElement : SimObject {



        public ForestBrushElement(bool pRegister = false)
            : base(pRegister) {
        }

        public ForestBrushElement(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public ForestBrushElement(string pName)
            : this(pName, false) {
        }

        public ForestBrushElement(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ForestBrushElement(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ForestBrushElement(SimObject pObj)
            : base(pObj) {
        }

        public ForestBrushElement(IntPtr pObj)
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
                                    "fnForestBrushElement_staticGetType"), typeof(_StaticGetType));
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
                                    "fnForestBrushElement_create"), typeof(_Create));
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






        public ForestItemData ForestItemData {
            get => GenericMarshal.StringTo<ForestItemData>(GetFieldValue("ForestItemData"));
            set => SetFieldValue("ForestItemData", GenericMarshal.ToString(value));
        }


        public float Probability {
            get => GenericMarshal.StringTo<float>(GetFieldValue("probability"));
            set => SetFieldValue("probability", GenericMarshal.ToString(value));
        }


        public float RotationRange {
            get => GenericMarshal.StringTo<float>(GetFieldValue("rotationRange"));
            set => SetFieldValue("rotationRange", GenericMarshal.ToString(value));
        }


        public float ScaleMin {
            get => GenericMarshal.StringTo<float>(GetFieldValue("scaleMin"));
            set => SetFieldValue("scaleMin", GenericMarshal.ToString(value));
        }


        public float ScaleMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("scaleMax"));
            set => SetFieldValue("scaleMax", GenericMarshal.ToString(value));
        }


        public float ScaleExponent {
            get => GenericMarshal.StringTo<float>(GetFieldValue("scaleExponent"));
            set => SetFieldValue("scaleExponent", GenericMarshal.ToString(value));
        }


        public float SinkMin {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sinkMin"));
            set => SetFieldValue("sinkMin", GenericMarshal.ToString(value));
        }


        public float SinkMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sinkMax"));
            set => SetFieldValue("sinkMax", GenericMarshal.ToString(value));
        }


        public float SinkRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sinkRadius"));
            set => SetFieldValue("sinkRadius", GenericMarshal.ToString(value));
        }


        public float SlopeMin {
            get => GenericMarshal.StringTo<float>(GetFieldValue("slopeMin"));
            set => SetFieldValue("slopeMin", GenericMarshal.ToString(value));
        }


        public float SlopeMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("slopeMax"));
            set => SetFieldValue("slopeMax", GenericMarshal.ToString(value));
        }


        public float ElevationMin {
            get => GenericMarshal.StringTo<float>(GetFieldValue("elevationMin"));
            set => SetFieldValue("elevationMin", GenericMarshal.ToString(value));
        }


        public float ElevationMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("elevationMax"));
            set => SetFieldValue("elevationMax", GenericMarshal.ToString(value));
        }


    }
}
