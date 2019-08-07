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

    public unsafe class TerrainMaterial : SimObject {



        public TerrainMaterial(bool pRegister = false)
            : base(pRegister) {
        }

        public TerrainMaterial(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public TerrainMaterial(string pName)
            : this(pName, false) {
        }

        public TerrainMaterial(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public TerrainMaterial(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public TerrainMaterial(SimObject pObj)
            : base(pObj) {
        }

        public TerrainMaterial(IntPtr pObj)
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
                                    "fnTerrainMaterial_staticGetType"), typeof(_StaticGetType));
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
                                    "fnTerrainMaterial_create"), typeof(_Create));
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






        public string DiffuseMap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("diffuseMap"));
            set => SetFieldValue("diffuseMap", GenericMarshal.ToString(value));
        }


        public float DiffuseSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("diffuseSize"));
            set => SetFieldValue("diffuseSize", GenericMarshal.ToString(value));
        }


        public string NormalMap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("normalMap"));
            set => SetFieldValue("normalMap", GenericMarshal.ToString(value));
        }


        public string DetailMap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("detailMap"));
            set => SetFieldValue("detailMap", GenericMarshal.ToString(value));
        }


        public float DetailSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("detailSize"));
            set => SetFieldValue("detailSize", GenericMarshal.ToString(value));
        }


        public float DetailStrength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("detailStrength"));
            set => SetFieldValue("detailStrength", GenericMarshal.ToString(value));
        }


        public float DetailDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("detailDistance"));
            set => SetFieldValue("detailDistance", GenericMarshal.ToString(value));
        }


        public bool UseSideProjection {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useSideProjection"));
            set => SetFieldValue("useSideProjection", GenericMarshal.ToString(value));
        }


        public string MacroMap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("macroMap"));
            set => SetFieldValue("macroMap", GenericMarshal.ToString(value));
        }


        public float MacroSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("macroSize"));
            set => SetFieldValue("macroSize", GenericMarshal.ToString(value));
        }


        public float MacroStrength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("macroStrength"));
            set => SetFieldValue("macroStrength", GenericMarshal.ToString(value));
        }


        public float MacroDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("macroDistance"));
            set => SetFieldValue("macroDistance", GenericMarshal.ToString(value));
        }


        public float ParallaxScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("parallaxScale"));
            set => SetFieldValue("parallaxScale", GenericMarshal.ToString(value));
        }


    }
}
