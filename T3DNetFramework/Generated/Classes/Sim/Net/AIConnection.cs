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

namespace T3DNetFramework.Generated.Classes.Sim.Net {

    public unsafe class AIConnection : GameConnection {



        public AIConnection(bool pRegister = false)
            : base(pRegister) {
        }

        public AIConnection(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public AIConnection(string pName)
            : this(pName, false) {
        }

        public AIConnection(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public AIConnection(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public AIConnection(SimObject pObj)
            : base(pObj) {
        }

        public AIConnection(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetAddress__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetAddress(IntPtr _this);
                internal delegate IntPtr _GetAddress(IntPtr _this, GetAddress__Args args);
                private static _GetAddress _GetAddressFunc;
                internal static _GetAddress GetAddress() {
                    if (_GetAddressFunc == null) {
                        _GetAddressFunc =
                            (_GetAddress)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIConnection_getAddress"), typeof(_GetAddress));
                    }

                    return _GetAddressFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetTrigger__Args
                {

				   internal int idx;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetTrigger(IntPtr _this, int idx);
                internal delegate bool _GetTrigger(IntPtr _this, GetTrigger__Args args);
                private static _GetTrigger _GetTriggerFunc;
                internal static _GetTrigger GetTrigger() {
                    if (_GetTriggerFunc == null) {
                        _GetTriggerFunc =
                            (_GetTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIConnection_getTrigger"), typeof(_GetTrigger));
                    }

                    return _GetTriggerFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetTrigger__Args
                {

				   internal int idx;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool set;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetTrigger(IntPtr _this, int idx, [MarshalAs(UnmanagedType.I1)]bool set);
                internal delegate void _SetTrigger(IntPtr _this, SetTrigger__Args args);
                private static _SetTrigger _SetTriggerFunc;
                internal static _SetTrigger SetTrigger() {
                    if (_SetTriggerFunc == null) {
                        _SetTriggerFunc =
                            (_SetTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIConnection_setTrigger"), typeof(_SetTrigger));
                    }

                    return _SetTriggerFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetFreeLook__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetFreeLook(IntPtr _this);
                internal delegate bool _GetFreeLook(IntPtr _this, GetFreeLook__Args args);
                private static _GetFreeLook _GetFreeLookFunc;
                internal static _GetFreeLook GetFreeLook() {
                    if (_GetFreeLookFunc == null) {
                        _GetFreeLookFunc =
                            (_GetFreeLook)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIConnection_getFreeLook"), typeof(_GetFreeLook));
                    }

                    return _GetFreeLookFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetFreeLook__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool isFreeLook;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetFreeLook(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool isFreeLook);
                internal delegate void _SetFreeLook(IntPtr _this, SetFreeLook__Args args);
                private static _SetFreeLook _SetFreeLookFunc;
                internal static _SetFreeLook SetFreeLook() {
                    if (_SetFreeLookFunc == null) {
                        _SetFreeLookFunc =
                            (_SetFreeLook)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIConnection_setFreeLook"), typeof(_SetFreeLook));
                    }

                    return _SetFreeLookFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMove__Args
                {

				   internal string field;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetMove(IntPtr _this, string field);
                internal delegate float _GetMove(IntPtr _this, GetMove__Args args);
                private static _GetMove _GetMoveFunc;
                internal static _GetMove GetMove() {
                    if (_GetMoveFunc == null) {
                        _GetMoveFunc =
                            (_GetMove)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIConnection_getMove"), typeof(_GetMove));
                    }

                    return _GetMoveFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMove__Args
                {

				   internal string field;

				   internal float value;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetMove(IntPtr _this, string field, float value);
                internal delegate void _SetMove(IntPtr _this, SetMove__Args args);
                private static _SetMove _SetMoveFunc;
                internal static _SetMove SetMove() {
                    if (_SetMoveFunc == null) {
                        _SetMoveFunc =
                            (_SetMove)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIConnection_setMove"), typeof(_SetMove));
                    }

                    return _SetMoveFunc;
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
                                    "fnAIConnection_staticGetType"), typeof(_StaticGetType));
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
                                    "fnAIConnection_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public string GetAddress() {

                     InternalUnsafeMethods.GetAddress__Args _args = new InternalUnsafeMethods.GetAddress__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetAddress()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public bool GetTrigger(int idx) {

                                          InternalUnsafeMethods.GetTrigger__Args _args = new InternalUnsafeMethods.GetTrigger__Args() {
                        idx = idx,
                     };
                     bool _engineResult = InternalUnsafeMethods.GetTrigger()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetTrigger(int idx, bool set) {

                                                               InternalUnsafeMethods.SetTrigger__Args _args = new InternalUnsafeMethods.SetTrigger__Args() {
                        idx = idx,
                        set = set,
                     };
                     InternalUnsafeMethods.SetTrigger()(ObjectPtr, _args);

                  }



                  public bool GetFreeLook() {

                     InternalUnsafeMethods.GetFreeLook__Args _args = new InternalUnsafeMethods.GetFreeLook__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.GetFreeLook()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetFreeLook(bool isFreeLook) {

                                          InternalUnsafeMethods.SetFreeLook__Args _args = new InternalUnsafeMethods.SetFreeLook__Args() {
                        isFreeLook = isFreeLook,
                     };
                     InternalUnsafeMethods.SetFreeLook()(ObjectPtr, _args);

                  }



                  public float GetMove(string field) {

                                          InternalUnsafeMethods.GetMove__Args _args = new InternalUnsafeMethods.GetMove__Args() {
                        field = field,
                     };
                     float _engineResult = InternalUnsafeMethods.GetMove()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetMove(string field, float value) {

                                                               InternalUnsafeMethods.SetMove__Args _args = new InternalUnsafeMethods.SetMove__Args() {
                        field = field,
                        value = value,
                     };
                     InternalUnsafeMethods.SetMove()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
