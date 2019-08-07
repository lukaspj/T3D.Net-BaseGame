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

    public unsafe class Portal : Zone {



        public Portal(bool pRegister = false)
            : base(pRegister) {
        }

        public Portal(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public Portal(string pName)
            : this(pName, false) {
        }

        public Portal(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Portal(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Portal(SimObject pObj)
            : base(pObj) {
        }

        public Portal(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsExteriorPortal__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsExteriorPortal(IntPtr _this);
                internal delegate bool _IsExteriorPortal(IntPtr _this, IsExteriorPortal__Args args);
                private static _IsExteriorPortal _IsExteriorPortalFunc;
                internal static _IsExteriorPortal IsExteriorPortal() {
                    if (_IsExteriorPortalFunc == null) {
                        _IsExteriorPortalFunc =
                            (_IsExteriorPortal)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPortal_isExteriorPortal"), typeof(_IsExteriorPortal));
                    }

                    return _IsExteriorPortalFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsInteriorPortal__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsInteriorPortal(IntPtr _this);
                internal delegate bool _IsInteriorPortal(IntPtr _this, IsInteriorPortal__Args args);
                private static _IsInteriorPortal _IsInteriorPortalFunc;
                internal static _IsInteriorPortal IsInteriorPortal() {
                    if (_IsInteriorPortalFunc == null) {
                        _IsInteriorPortalFunc =
                            (_IsInteriorPortal)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPortal_isInteriorPortal"), typeof(_IsInteriorPortal));
                    }

                    return _IsInteriorPortalFunc;
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
                                    "fnPortal_staticGetType"), typeof(_StaticGetType));
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
                                    "fnPortal_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public bool IsExteriorPortal() {

                     InternalUnsafeMethods.IsExteriorPortal__Args _args = new InternalUnsafeMethods.IsExteriorPortal__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsExteriorPortal()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsInteriorPortal() {

                     InternalUnsafeMethods.IsInteriorPortal__Args _args = new InternalUnsafeMethods.IsInteriorPortal__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsInteriorPortal()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public bool FrontSidePassable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("frontSidePassable"));
            set => SetFieldValue("frontSidePassable", GenericMarshal.ToString(value));
        }


        public bool BackSidePassable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("backSidePassable"));
            set => SetFieldValue("backSidePassable", GenericMarshal.ToString(value));
        }


    }
}
