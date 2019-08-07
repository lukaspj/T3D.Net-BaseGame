using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Math;
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

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class Projectile : GameBase {



        public Projectile(bool pRegister = false)
            : base(pRegister) {
        }

        public Projectile(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public Projectile(string pName)
            : this(pName, false) {
        }

        public Projectile(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Projectile(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Projectile(SimObject pObj)
            : base(pObj) {
        }

        public Projectile(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct Presimulate__Args
                {

				   internal float seconds;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Presimulate(IntPtr _this, float seconds);
                internal delegate void _Presimulate(IntPtr _this, Presimulate__Args args);
                private static _Presimulate _PresimulateFunc;
                internal static _Presimulate Presimulate() {
                    if (_PresimulateFunc == null) {
                        _PresimulateFunc =
                            (_Presimulate)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnProjectile_presimulate"), typeof(_Presimulate));
                    }

                    return _PresimulateFunc;
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
                                    "fnProjectile_staticGetType"), typeof(_StaticGetType));
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
                                    "fnProjectile_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void Presimulate(float seconds = 1f) {

                                          InternalUnsafeMethods.Presimulate__Args _args = new InternalUnsafeMethods.Presimulate__Args() {
                        seconds = seconds,
                     };
                     InternalUnsafeMethods.Presimulate()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public Point3F InitialPosition {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("initialPosition"));
            set => SetFieldValue("initialPosition", GenericMarshal.ToString(value));
        }


        public Point3F InitialVelocity {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("initialVelocity"));
            set => SetFieldValue("initialVelocity", GenericMarshal.ToString(value));
        }


        public int SourceObject {
            get => GenericMarshal.StringTo<int>(GetFieldValue("sourceObject"));
            set => SetFieldValue("sourceObject", GenericMarshal.ToString(value));
        }


        public int SourceSlot {
            get => GenericMarshal.StringTo<int>(GetFieldValue("sourceSlot"));
            set => SetFieldValue("sourceSlot", GenericMarshal.ToString(value));
        }


        public bool IgnoreSourceTimeout {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreSourceTimeout"));
            set => SetFieldValue("ignoreSourceTimeout", GenericMarshal.ToString(value));
        }


    }
}
