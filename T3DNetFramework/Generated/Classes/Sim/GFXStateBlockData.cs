using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class GFXStateBlockData : SimObject {



        public GFXStateBlockData(bool pRegister = false)
            : base(pRegister) {
        }

        public GFXStateBlockData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GFXStateBlockData(string pName)
            : this(pName, false) {
        }

        public GFXStateBlockData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GFXStateBlockData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GFXStateBlockData(SimObject pObj)
            : base(pObj) {
        }

        public GFXStateBlockData(IntPtr pObj)
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
                                    "fnGFXStateBlockData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGFXStateBlockData_create"), typeof(_Create));
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






        public bool BlendDefined {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("blendDefined"));
            set => SetFieldValue("blendDefined", GenericMarshal.ToString(value));
        }


        public bool BlendEnable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("blendEnable"));
            set => SetFieldValue("blendEnable", GenericMarshal.ToString(value));
        }


        public GFXBlend BlendSrc {
            get => GenericMarshal.StringTo<GFXBlend>(GetFieldValue("blendSrc"));
            set => SetFieldValue("blendSrc", GenericMarshal.ToString(value));
        }


        public GFXBlend BlendDest {
            get => GenericMarshal.StringTo<GFXBlend>(GetFieldValue("blendDest"));
            set => SetFieldValue("blendDest", GenericMarshal.ToString(value));
        }


        public GFXBlendOp BlendOp {
            get => GenericMarshal.StringTo<GFXBlendOp>(GetFieldValue("blendOp"));
            set => SetFieldValue("blendOp", GenericMarshal.ToString(value));
        }


        public bool SeparateAlphaBlendDefined {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("separateAlphaBlendDefined"));
            set => SetFieldValue("separateAlphaBlendDefined", GenericMarshal.ToString(value));
        }


        public bool SeparateAlphaBlendEnable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("separateAlphaBlendEnable"));
            set => SetFieldValue("separateAlphaBlendEnable", GenericMarshal.ToString(value));
        }


        public GFXBlend SeparateAlphaBlendSrc {
            get => GenericMarshal.StringTo<GFXBlend>(GetFieldValue("separateAlphaBlendSrc"));
            set => SetFieldValue("separateAlphaBlendSrc", GenericMarshal.ToString(value));
        }


        public GFXBlend SeparateAlphaBlendDest {
            get => GenericMarshal.StringTo<GFXBlend>(GetFieldValue("separateAlphaBlendDest"));
            set => SetFieldValue("separateAlphaBlendDest", GenericMarshal.ToString(value));
        }


        public GFXBlendOp SeparateAlphaBlendOp {
            get => GenericMarshal.StringTo<GFXBlendOp>(GetFieldValue("separateAlphaBlendOp"));
            set => SetFieldValue("separateAlphaBlendOp", GenericMarshal.ToString(value));
        }


        public bool AlphaDefined {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("alphaDefined"));
            set => SetFieldValue("alphaDefined", GenericMarshal.ToString(value));
        }


        public bool AlphaTestEnable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("alphaTestEnable"));
            set => SetFieldValue("alphaTestEnable", GenericMarshal.ToString(value));
        }


        public GFXCmpFunc AlphaTestFunc {
            get => GenericMarshal.StringTo<GFXCmpFunc>(GetFieldValue("alphaTestFunc"));
            set => SetFieldValue("alphaTestFunc", GenericMarshal.ToString(value));
        }


        public int AlphaTestRef {
            get => GenericMarshal.StringTo<int>(GetFieldValue("alphaTestRef"));
            set => SetFieldValue("alphaTestRef", GenericMarshal.ToString(value));
        }


        public bool ColorWriteDefined {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("colorWriteDefined"));
            set => SetFieldValue("colorWriteDefined", GenericMarshal.ToString(value));
        }


        public bool ColorWriteRed {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("colorWriteRed"));
            set => SetFieldValue("colorWriteRed", GenericMarshal.ToString(value));
        }


        public bool ColorWriteBlue {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("colorWriteBlue"));
            set => SetFieldValue("colorWriteBlue", GenericMarshal.ToString(value));
        }


        public bool ColorWriteGreen {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("colorWriteGreen"));
            set => SetFieldValue("colorWriteGreen", GenericMarshal.ToString(value));
        }


        public bool ColorWriteAlpha {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("colorWriteAlpha"));
            set => SetFieldValue("colorWriteAlpha", GenericMarshal.ToString(value));
        }


        public bool CullDefined {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("cullDefined"));
            set => SetFieldValue("cullDefined", GenericMarshal.ToString(value));
        }


        public GFXCullMode CullMode {
            get => GenericMarshal.StringTo<GFXCullMode>(GetFieldValue("cullMode"));
            set => SetFieldValue("cullMode", GenericMarshal.ToString(value));
        }


        public bool ZDefined {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("zDefined"));
            set => SetFieldValue("zDefined", GenericMarshal.ToString(value));
        }


        public bool ZEnable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("zEnable"));
            set => SetFieldValue("zEnable", GenericMarshal.ToString(value));
        }


        public bool ZWriteEnable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("zWriteEnable"));
            set => SetFieldValue("zWriteEnable", GenericMarshal.ToString(value));
        }


        public GFXCmpFunc ZFunc {
            get => GenericMarshal.StringTo<GFXCmpFunc>(GetFieldValue("zFunc"));
            set => SetFieldValue("zFunc", GenericMarshal.ToString(value));
        }


        public float ZBias {
            get => GenericMarshal.StringTo<float>(GetFieldValue("zBias"));
            set => SetFieldValue("zBias", GenericMarshal.ToString(value));
        }


        public float ZSlopeBias {
            get => GenericMarshal.StringTo<float>(GetFieldValue("zSlopeBias"));
            set => SetFieldValue("zSlopeBias", GenericMarshal.ToString(value));
        }


        public bool StencilDefined {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("stencilDefined"));
            set => SetFieldValue("stencilDefined", GenericMarshal.ToString(value));
        }


        public bool StencilEnable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("stencilEnable"));
            set => SetFieldValue("stencilEnable", GenericMarshal.ToString(value));
        }


        public GFXStencilOp StencilFailOp {
            get => GenericMarshal.StringTo<GFXStencilOp>(GetFieldValue("stencilFailOp"));
            set => SetFieldValue("stencilFailOp", GenericMarshal.ToString(value));
        }


        public GFXStencilOp StencilZFailOp {
            get => GenericMarshal.StringTo<GFXStencilOp>(GetFieldValue("stencilZFailOp"));
            set => SetFieldValue("stencilZFailOp", GenericMarshal.ToString(value));
        }


        public GFXStencilOp StencilPassOp {
            get => GenericMarshal.StringTo<GFXStencilOp>(GetFieldValue("stencilPassOp"));
            set => SetFieldValue("stencilPassOp", GenericMarshal.ToString(value));
        }


        public GFXCmpFunc StencilFunc {
            get => GenericMarshal.StringTo<GFXCmpFunc>(GetFieldValue("stencilFunc"));
            set => SetFieldValue("stencilFunc", GenericMarshal.ToString(value));
        }


        public int StencilRef {
            get => GenericMarshal.StringTo<int>(GetFieldValue("stencilRef"));
            set => SetFieldValue("stencilRef", GenericMarshal.ToString(value));
        }


        public int StencilMask {
            get => GenericMarshal.StringTo<int>(GetFieldValue("stencilMask"));
            set => SetFieldValue("stencilMask", GenericMarshal.ToString(value));
        }


        public int StencilWriteMask {
            get => GenericMarshal.StringTo<int>(GetFieldValue("stencilWriteMask"));
            set => SetFieldValue("stencilWriteMask", GenericMarshal.ToString(value));
        }


        public bool FfLighting {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ffLighting"));
            set => SetFieldValue("ffLighting", GenericMarshal.ToString(value));
        }


        public bool VertexColorEnable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("vertexColorEnable"));
            set => SetFieldValue("vertexColorEnable", GenericMarshal.ToString(value));
        }


        public bool SamplersDefined {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("samplersDefined"));
            set => SetFieldValue("samplersDefined", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<GFXSamplerStateData> SamplerStates {
            get => new DynamicFieldVector<GFXSamplerStateData>(
                    this,
                    "samplerStates",
                    16,
                    val => GenericMarshal.StringTo<GFXSamplerStateData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public ColorI TextureFactor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("textureFactor"));
            set => SetFieldValue("textureFactor", GenericMarshal.ToString(value));
        }


    }
}
