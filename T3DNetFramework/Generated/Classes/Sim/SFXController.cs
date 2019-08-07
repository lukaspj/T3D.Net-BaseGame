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

    public unsafe class SFXController : SFXSource {



        public SFXController(bool pRegister = false)
            : base(pRegister) {
        }

        public SFXController(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public SFXController(string pName)
            : this(pName, false) {
        }

        public SFXController(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public SFXController(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public SFXController(SimObject pObj)
            : base(pObj) {
        }

        public SFXController(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCurrentSlot__Args
                {

				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetCurrentSlot(IntPtr _this, int index);
                internal delegate void _SetCurrentSlot(IntPtr _this, SetCurrentSlot__Args args);
                private static _SetCurrentSlot _SetCurrentSlotFunc;
                internal static _SetCurrentSlot SetCurrentSlot() {
                    if (_SetCurrentSlotFunc == null) {
                        _SetCurrentSlotFunc =
                            (_SetCurrentSlot)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXController_setCurrentSlot"), typeof(_SetCurrentSlot));
                    }

                    return _SetCurrentSlotFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetCurrentSlot__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetCurrentSlot(IntPtr _this);
                internal delegate int _GetCurrentSlot(IntPtr _this, GetCurrentSlot__Args args);
                private static _GetCurrentSlot _GetCurrentSlotFunc;
                internal static _GetCurrentSlot GetCurrentSlot() {
                    if (_GetCurrentSlotFunc == null) {
                        _GetCurrentSlotFunc =
                            (_GetCurrentSlot)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXController_getCurrentSlot"), typeof(_GetCurrentSlot));
                    }

                    return _GetCurrentSlotFunc;
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
                                    "fnSFXController_staticGetType"), typeof(_StaticGetType));
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
                                    "fnSFXController_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void SetCurrentSlot(int index) {

                                          InternalUnsafeMethods.SetCurrentSlot__Args _args = new InternalUnsafeMethods.SetCurrentSlot__Args() {
                        index = index,
                     };
                     InternalUnsafeMethods.SetCurrentSlot()(ObjectPtr, _args);

                  }



                  public int GetCurrentSlot() {

                     InternalUnsafeMethods.GetCurrentSlot__Args _args = new InternalUnsafeMethods.GetCurrentSlot__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetCurrentSlot()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public bool Trace {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("trace"));
            set => SetFieldValue("trace", GenericMarshal.ToString(value));
        }


    }
}
