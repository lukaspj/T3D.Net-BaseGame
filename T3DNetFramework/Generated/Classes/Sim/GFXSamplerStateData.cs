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

    public unsafe class GFXSamplerStateData : SimObject {



        public GFXSamplerStateData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GFXSamplerStateData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GFXSamplerStateData(string pName) 
            : this(pName, false) {
        }
        
        public GFXSamplerStateData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GFXSamplerStateData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GFXSamplerStateData(SimObject pObj) 
            : base(pObj) {
        }
        
        public GFXSamplerStateData(IntPtr pObj) 
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
                                    "fnGFXSamplerStateData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGFXSamplerStateData_create"), typeof(_Create));
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
	





        public GFXTextureOp TextureColorOp {
            get => GenericMarshal.StringTo<GFXTextureOp>(GetFieldValue("textureColorOp"));
            set => SetFieldValue("textureColorOp", GenericMarshal.ToString(value));
        }


        public GFXTextureArgument ColorArg1 {
            get => GenericMarshal.StringTo<GFXTextureArgument>(GetFieldValue("colorArg1"));
            set => SetFieldValue("colorArg1", GenericMarshal.ToString(value));
        }


        public GFXTextureArgument ColorArg2 {
            get => GenericMarshal.StringTo<GFXTextureArgument>(GetFieldValue("colorArg2"));
            set => SetFieldValue("colorArg2", GenericMarshal.ToString(value));
        }


        public GFXTextureArgument ColorArg3 {
            get => GenericMarshal.StringTo<GFXTextureArgument>(GetFieldValue("colorArg3"));
            set => SetFieldValue("colorArg3", GenericMarshal.ToString(value));
        }


        public GFXTextureOp AlphaOp {
            get => GenericMarshal.StringTo<GFXTextureOp>(GetFieldValue("alphaOp"));
            set => SetFieldValue("alphaOp", GenericMarshal.ToString(value));
        }


        public GFXTextureArgument AlphaArg1 {
            get => GenericMarshal.StringTo<GFXTextureArgument>(GetFieldValue("alphaArg1"));
            set => SetFieldValue("alphaArg1", GenericMarshal.ToString(value));
        }


        public GFXTextureArgument AlphaArg2 {
            get => GenericMarshal.StringTo<GFXTextureArgument>(GetFieldValue("alphaArg2"));
            set => SetFieldValue("alphaArg2", GenericMarshal.ToString(value));
        }


        public GFXTextureArgument AlphaArg3 {
            get => GenericMarshal.StringTo<GFXTextureArgument>(GetFieldValue("alphaArg3"));
            set => SetFieldValue("alphaArg3", GenericMarshal.ToString(value));
        }


        public GFXTextureAddressMode AddressModeU {
            get => GenericMarshal.StringTo<GFXTextureAddressMode>(GetFieldValue("addressModeU"));
            set => SetFieldValue("addressModeU", GenericMarshal.ToString(value));
        }


        public GFXTextureAddressMode AddressModeV {
            get => GenericMarshal.StringTo<GFXTextureAddressMode>(GetFieldValue("addressModeV"));
            set => SetFieldValue("addressModeV", GenericMarshal.ToString(value));
        }


        public GFXTextureAddressMode AddressModeW {
            get => GenericMarshal.StringTo<GFXTextureAddressMode>(GetFieldValue("addressModeW"));
            set => SetFieldValue("addressModeW", GenericMarshal.ToString(value));
        }


        public GFXTextureFilterType MagFilter {
            get => GenericMarshal.StringTo<GFXTextureFilterType>(GetFieldValue("magFilter"));
            set => SetFieldValue("magFilter", GenericMarshal.ToString(value));
        }


        public GFXTextureFilterType MinFilter {
            get => GenericMarshal.StringTo<GFXTextureFilterType>(GetFieldValue("minFilter"));
            set => SetFieldValue("minFilter", GenericMarshal.ToString(value));
        }


        public GFXTextureFilterType MipFilter {
            get => GenericMarshal.StringTo<GFXTextureFilterType>(GetFieldValue("mipFilter"));
            set => SetFieldValue("mipFilter", GenericMarshal.ToString(value));
        }


        public float MipLODBias {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mipLODBias"));
            set => SetFieldValue("mipLODBias", GenericMarshal.ToString(value));
        }


        public int MaxAnisotropy {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxAnisotropy"));
            set => SetFieldValue("maxAnisotropy", GenericMarshal.ToString(value));
        }


        public GFXTextureTransformFlags TextureTransform {
            get => GenericMarshal.StringTo<GFXTextureTransformFlags>(GetFieldValue("textureTransform"));
            set => SetFieldValue("textureTransform", GenericMarshal.ToString(value));
        }


        public GFXTextureArgument ResultArg {
            get => GenericMarshal.StringTo<GFXTextureArgument>(GetFieldValue("resultArg"));
            set => SetFieldValue("resultArg", GenericMarshal.ToString(value));
        }


        public GFXCmpFunc SamplerFunc {
            get => GenericMarshal.StringTo<GFXCmpFunc>(GetFieldValue("samplerFunc"));
            set => SetFieldValue("samplerFunc", GenericMarshal.ToString(value));
        }


    }
}