using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class SFXParameter : SimObject {



        public SFXParameter(bool pRegister = false)
            : base(pRegister) {
        }

        public SFXParameter(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public SFXParameter(string pName)
            : this(pName, false) {
        }

        public SFXParameter(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public SFXParameter(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public SFXParameter(SimObject pObj)
            : base(pObj) {
        }

        public SFXParameter(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct Reset__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Reset(IntPtr _this);
                internal delegate void _Reset(IntPtr _this, Reset__Args args);
                private static _Reset _ResetFunc;
                internal static _Reset Reset() {
                    if (_ResetFunc == null) {
                        _ResetFunc =
                            (_Reset)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXParameter_reset"), typeof(_Reset));
                    }

                    return _ResetFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetParameterName__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetParameterName(IntPtr _this);
                internal delegate IntPtr _GetParameterName(IntPtr _this, GetParameterName__Args args);
                private static _GetParameterName _GetParameterNameFunc;
                internal static _GetParameterName GetParameterName() {
                    if (_GetParameterNameFunc == null) {
                        _GetParameterNameFunc =
                            (_GetParameterName)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXParameter_getParameterName"), typeof(_GetParameterName));
                    }

                    return _GetParameterNameFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnUpdate__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnUpdate(IntPtr _this);
                internal delegate void _OnUpdate(IntPtr _this, OnUpdate__Args args);
                private static _OnUpdate _OnUpdateFunc;
                internal static _OnUpdate OnUpdate() {
                    if (_OnUpdateFunc == null) {
                        _OnUpdateFunc =
                            (_OnUpdate)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbSFXParameter_onUpdate"), typeof(_OnUpdate));
                    }

                    return _OnUpdateFunc;
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
                                    "fnSFXParameter_staticGetType"), typeof(_StaticGetType));
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
                                    "fnSFXParameter_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void Reset() {

                     InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
                     };
                     InternalUnsafeMethods.Reset()(ObjectPtr, _args);

                  }



                  public string GetParameterName() {

                     InternalUnsafeMethods.GetParameterName__Args _args = new InternalUnsafeMethods.GetParameterName__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetParameterName()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void OnUpdate() {

                     InternalUnsafeMethods.OnUpdate__Args _args = new InternalUnsafeMethods.OnUpdate__Args() {
                     };
                     InternalUnsafeMethods.OnUpdate()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public float Value {
            get => GenericMarshal.StringTo<float>(GetFieldValue("value"));
            set => SetFieldValue("value", GenericMarshal.ToString(value));
        }


        public Point2F Range {
            get => GenericMarshal.StringTo<Point2F>(GetFieldValue("range"));
            set => SetFieldValue("range", GenericMarshal.ToString(value));
        }


        public SFXChannel Channel {
            get => GenericMarshal.StringTo<SFXChannel>(GetFieldValue("channel"));
            set => SetFieldValue("channel", GenericMarshal.ToString(value));
        }


        public float DefaultValue {
            get => GenericMarshal.StringTo<float>(GetFieldValue("defaultValue"));
            set => SetFieldValue("defaultValue", GenericMarshal.ToString(value));
        }


        public string Description {
            get => GenericMarshal.StringTo<string>(GetFieldValue("description"));
            set => SetFieldValue("description", GenericMarshal.ToString(value));
        }


    }
}
