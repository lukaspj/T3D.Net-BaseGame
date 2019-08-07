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

    public unsafe class ReflectorDesc : SimDataBlock {



        public ReflectorDesc(bool pRegister = false)
            : base(pRegister) {
        }

        public ReflectorDesc(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public ReflectorDesc(string pName)
            : this(pName, false) {
        }

        public ReflectorDesc(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ReflectorDesc(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ReflectorDesc(SimObject pObj)
            : base(pObj) {
        }

        public ReflectorDesc(IntPtr pObj)
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
                                    "fnReflectorDesc_staticGetType"), typeof(_StaticGetType));
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
                                    "fnReflectorDesc_create"), typeof(_Create));
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






        public int TexSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("texSize"));
            set => SetFieldValue("texSize", GenericMarshal.ToString(value));
        }


        public float NearDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("nearDist"));
            set => SetFieldValue("nearDist", GenericMarshal.ToString(value));
        }


        public float FarDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("farDist"));
            set => SetFieldValue("farDist", GenericMarshal.ToString(value));
        }


        public int ObjectTypeMask {
            get => GenericMarshal.StringTo<int>(GetFieldValue("objectTypeMask"));
            set => SetFieldValue("objectTypeMask", GenericMarshal.ToString(value));
        }


        public float DetailAdjust {
            get => GenericMarshal.StringTo<float>(GetFieldValue("detailAdjust"));
            set => SetFieldValue("detailAdjust", GenericMarshal.ToString(value));
        }


        public float Priority {
            get => GenericMarshal.StringTo<float>(GetFieldValue("priority"));
            set => SetFieldValue("priority", GenericMarshal.ToString(value));
        }


        public int MaxRateMs {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxRateMs"));
            set => SetFieldValue("maxRateMs", GenericMarshal.ToString(value));
        }


        public bool UseOcclusionQuery {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useOcclusionQuery"));
            set => SetFieldValue("useOcclusionQuery", GenericMarshal.ToString(value));
        }


    }
}
