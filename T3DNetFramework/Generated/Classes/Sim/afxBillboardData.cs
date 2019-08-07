using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class afxBillboardData : GameBaseData {



        public afxBillboardData(bool pRegister = false)
            : base(pRegister) {
        }

        public afxBillboardData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public afxBillboardData(string pName)
            : this(pName, false) {
        }

        public afxBillboardData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxBillboardData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxBillboardData(SimObject pObj)
            : base(pObj) {
        }

        public afxBillboardData(IntPtr pObj)
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
                                    "fnafxBillboardData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnafxBillboardData_create"), typeof(_Create));
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






        public LinearColorF Color {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("color"));
            set => SetFieldValue("color", GenericMarshal.ToString(value));
        }


        public string Texture {
            get => GenericMarshal.StringTo<string>(GetFieldValue("texture"));
            set => SetFieldValue("texture", GenericMarshal.ToString(value));
        }


        public Point2F Dimensions {
            get => GenericMarshal.StringTo<Point2F>(GetFieldValue("dimensions"));
            set => SetFieldValue("dimensions", GenericMarshal.ToString(value));
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


        public afxBillboard_BlendStyle BlendStyle {
            get => GenericMarshal.StringTo<afxBillboard_BlendStyle>(GetFieldValue("blendStyle"));
            set => SetFieldValue("blendStyle", GenericMarshal.ToString(value));
        }


        public GFXBlend SrcBlendFactor {
            get => GenericMarshal.StringTo<GFXBlend>(GetFieldValue("srcBlendFactor"));
            set => SetFieldValue("srcBlendFactor", GenericMarshal.ToString(value));
        }


        public GFXBlend DstBlendFactor {
            get => GenericMarshal.StringTo<GFXBlend>(GetFieldValue("dstBlendFactor"));
            set => SetFieldValue("dstBlendFactor", GenericMarshal.ToString(value));
        }


        public afxBillboard_TexFuncType TextureFunction {
            get => GenericMarshal.StringTo<afxBillboard_TexFuncType>(GetFieldValue("textureFunction"));
            set => SetFieldValue("textureFunction", GenericMarshal.ToString(value));
        }


    }
}
