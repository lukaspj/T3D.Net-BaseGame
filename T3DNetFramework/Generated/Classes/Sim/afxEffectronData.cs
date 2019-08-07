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

    public unsafe class afxEffectronData : afxChoreographerData {



        public afxEffectronData(bool pRegister = false)
            : base(pRegister) {
        }

        public afxEffectronData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public afxEffectronData(string pName)
            : this(pName, false) {
        }

        public afxEffectronData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxEffectronData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxEffectronData(SimObject pObj)
            : base(pObj) {
        }

        public afxEffectronData(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct PushEffect__Args
                {

				   internal IntPtr effect;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _PushEffect(IntPtr _this, IntPtr effect);
                internal delegate void _PushEffect(IntPtr _this, PushEffect__Args args);
                private static _PushEffect _PushEffectFunc;
                internal static _PushEffect PushEffect() {
                    if (_PushEffectFunc == null) {
                        _PushEffectFunc =
                            (_PushEffect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxEffectronData_pushEffect"), typeof(_PushEffect));
                    }

                    return _PushEffectFunc;
                }



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
                                    "fnafxEffectronData_reset"), typeof(_Reset));
                    }

                    return _ResetFunc;
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
                                    "fnafxEffectronData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnafxEffectronData_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void PushEffect(afxEffectBaseData effect) {

                                          InternalUnsafeMethods.PushEffect__Args _args = new InternalUnsafeMethods.PushEffect__Args() {
                        effect = effect.ObjectPtr,
                     };
                     InternalUnsafeMethods.PushEffect()(ObjectPtr, _args);

                  }



                  public void Reset() {

                     InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
                     };
                     InternalUnsafeMethods.Reset()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public float Duration {
            get => GenericMarshal.StringTo<float>(GetFieldValue("duration"));
            set => SetFieldValue("duration", GenericMarshal.ToString(value));
        }


        public int NumLoops {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numLoops"));
            set => SetFieldValue("numLoops", GenericMarshal.ToString(value));
        }


        public afxEffectBaseData AddEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addEffect"));
            set => SetFieldValue("addEffect", GenericMarshal.ToString(value));
        }


    }
}
