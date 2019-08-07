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

    public unsafe class afxModelData : GameBaseData {



        public afxModelData(bool pRegister = false)
            : base(pRegister) {
        }

        public afxModelData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public afxModelData(string pName)
            : this(pName, false) {
        }

        public afxModelData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxModelData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxModelData(SimObject pObj)
            : base(pObj) {
        }

        public afxModelData(IntPtr pObj)
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
                                    "fnafxModelData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnafxModelData_create"), typeof(_Create));
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






        public string ShapeFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("shapeFile"));
            set => SetFieldValue("shapeFile", GenericMarshal.ToString(value));
        }


        public string Sequence {
            get => GenericMarshal.StringTo<string>(GetFieldValue("sequence"));
            set => SetFieldValue("sequence", GenericMarshal.ToString(value));
        }


        public float SequenceRate {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sequenceRate"));
            set => SetFieldValue("sequenceRate", GenericMarshal.ToString(value));
        }


        public float SequenceOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sequenceOffset"));
            set => SetFieldValue("sequenceOffset", GenericMarshal.ToString(value));
        }


        public float AlphaMult {
            get => GenericMarshal.StringTo<float>(GetFieldValue("alphaMult"));
            set => SetFieldValue("alphaMult", GenericMarshal.ToString(value));
        }


        public float FogMult {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fogMult"));
            set => SetFieldValue("fogMult", GenericMarshal.ToString(value));
        }


        public string RemapTextureTags {
            get => GenericMarshal.StringTo<string>(GetFieldValue("remapTextureTags"));
            set => SetFieldValue("remapTextureTags", GenericMarshal.ToString(value));
        }


        public bool ShadowEnable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("shadowEnable"));
            set => SetFieldValue("shadowEnable", GenericMarshal.ToString(value));
        }


        public bool UseVertexAlpha {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useVertexAlpha"));
            set => SetFieldValue("useVertexAlpha", GenericMarshal.ToString(value));
        }


        public int ForceOnMaterialFlags {
            get => GenericMarshal.StringTo<int>(GetFieldValue("forceOnMaterialFlags"));
            set => SetFieldValue("forceOnMaterialFlags", GenericMarshal.ToString(value));
        }


        public int ForceOffMaterialFlags {
            get => GenericMarshal.StringTo<int>(GetFieldValue("forceOffMaterialFlags"));
            set => SetFieldValue("forceOffMaterialFlags", GenericMarshal.ToString(value));
        }


        public bool TextureFiltering {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("textureFiltering"));
            set => SetFieldValue("textureFiltering", GenericMarshal.ToString(value));
        }


        public bool OverrideLightingOptions {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("overrideLightingOptions"));
            set => SetFieldValue("overrideLightingOptions", GenericMarshal.ToString(value));
        }


        public bool ReceiveSunLight {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("receiveSunLight"));
            set => SetFieldValue("receiveSunLight", GenericMarshal.ToString(value));
        }


        public bool ReceiveLMLighting {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("receiveLMLighting"));
            set => SetFieldValue("receiveLMLighting", GenericMarshal.ToString(value));
        }


        public bool UseAdaptiveSelfIllumination {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useAdaptiveSelfIllumination"));
            set => SetFieldValue("useAdaptiveSelfIllumination", GenericMarshal.ToString(value));
        }


        public bool UseCustomAmbientLighting {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useCustomAmbientLighting"));
            set => SetFieldValue("useCustomAmbientLighting", GenericMarshal.ToString(value));
        }


        public bool CustomAmbientSelfIllumination {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("customAmbientSelfIllumination"));
            set => SetFieldValue("customAmbientSelfIllumination", GenericMarshal.ToString(value));
        }


        public LinearColorF CustomAmbientLighting {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("customAmbientLighting"));
            set => SetFieldValue("customAmbientLighting", GenericMarshal.ToString(value));
        }


        public int ShadowSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("shadowSize"));
            set => SetFieldValue("shadowSize", GenericMarshal.ToString(value));
        }


        public float ShadowMaxVisibleDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shadowMaxVisibleDistance"));
            set => SetFieldValue("shadowMaxVisibleDistance", GenericMarshal.ToString(value));
        }


        public float ShadowProjectionDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shadowProjectionDistance"));
            set => SetFieldValue("shadowProjectionDistance", GenericMarshal.ToString(value));
        }


        public float ShadowSphereAdjust {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shadowSphereAdjust"));
            set => SetFieldValue("shadowSphereAdjust", GenericMarshal.ToString(value));
        }


    }
}
