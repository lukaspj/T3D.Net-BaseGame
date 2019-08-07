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

    public unsafe class Zone : SceneObject {



        public Zone(bool pRegister = false)
            : base(pRegister) {
        }

        public Zone(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public Zone(string pName)
            : this(pName, false) {
        }

        public Zone(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Zone(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Zone(SimObject pObj)
            : base(pObj) {
        }

        public Zone(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct DumpZoneState__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool updateFirst;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _DumpZoneState(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool updateFirst);
                internal delegate void _DumpZoneState(IntPtr _this, DumpZoneState__Args args);
                private static _DumpZoneState _DumpZoneStateFunc;
                internal static _DumpZoneState DumpZoneState() {
                    if (_DumpZoneStateFunc == null) {
                        _DumpZoneStateFunc =
                            (_DumpZoneState)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnZone_dumpZoneState"), typeof(_DumpZoneState));
                    }

                    return _DumpZoneStateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetZoneId__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetZoneId(IntPtr _this);
                internal delegate int _GetZoneId(IntPtr _this, GetZoneId__Args args);
                private static _GetZoneId _GetZoneIdFunc;
                internal static _GetZoneId GetZoneId() {
                    if (_GetZoneIdFunc == null) {
                        _GetZoneIdFunc =
                            (_GetZoneId)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnZone_getZoneId"), typeof(_GetZoneId));
                    }

                    return _GetZoneIdFunc;
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
                                    "fnZone_staticGetType"), typeof(_StaticGetType));
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
                                    "fnZone_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void DumpZoneState(bool updateFirst = true) {

                                          InternalUnsafeMethods.DumpZoneState__Args _args = new InternalUnsafeMethods.DumpZoneState__Args() {
                        updateFirst = updateFirst,
                     };
                     InternalUnsafeMethods.DumpZoneState()(ObjectPtr, _args);

                  }



                  public int GetZoneId() {

                     InternalUnsafeMethods.GetZoneId__Args _args = new InternalUnsafeMethods.GetZoneId__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetZoneId()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public SFXAmbience SoundAmbience {
            get => GenericMarshal.StringTo<SFXAmbience>(GetFieldValue("soundAmbience"));
            set => SetFieldValue("soundAmbience", GenericMarshal.ToString(value));
        }


        public string Plane {
            get => GenericMarshal.StringTo<string>(GetFieldValue("plane"));
            set => SetFieldValue("plane", GenericMarshal.ToString(value));
        }


        public string Point {
            get => GenericMarshal.StringTo<string>(GetFieldValue("point"));
            set => SetFieldValue("point", GenericMarshal.ToString(value));
        }


        public string Edge {
            get => GenericMarshal.StringTo<string>(GetFieldValue("edge"));
            set => SetFieldValue("edge", GenericMarshal.ToString(value));
        }


        public bool UseAmbientLightColor {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useAmbientLightColor"));
            set => SetFieldValue("useAmbientLightColor", GenericMarshal.ToString(value));
        }


        public LinearColorF AmbientLightColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("ambientLightColor"));
            set => SetFieldValue("ambientLightColor", GenericMarshal.ToString(value));
        }


        public int ZoneGroup {
            get => GenericMarshal.StringTo<int>(GetFieldValue("zoneGroup"));
            set => SetFieldValue("zoneGroup", GenericMarshal.ToString(value));
        }


    }
}
