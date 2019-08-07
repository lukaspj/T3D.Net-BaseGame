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

    public unsafe class afxAnimClipData : GameBaseData {



        public afxAnimClipData(bool pRegister = false)
            : base(pRegister) {
        }

        public afxAnimClipData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public afxAnimClipData(string pName)
            : this(pName, false) {
        }

        public afxAnimClipData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxAnimClipData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxAnimClipData(SimObject pObj)
            : base(pObj) {
        }

        public afxAnimClipData(IntPtr pObj)
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
                                    "fnafxAnimClipData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnafxAnimClipData_create"), typeof(_Create));
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






        public string ClipName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("clipName"));
            set => SetFieldValue("clipName", GenericMarshal.ToString(value));
        }


        public float Rate {
            get => GenericMarshal.StringTo<float>(GetFieldValue("rate"));
            set => SetFieldValue("rate", GenericMarshal.ToString(value));
        }


        public float PosOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("posOffset"));
            set => SetFieldValue("posOffset", GenericMarshal.ToString(value));
        }


        public float TransitionTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("transitionTime"));
            set => SetFieldValue("transitionTime", GenericMarshal.ToString(value));
        }


        public bool IgnoreCorpse {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreCorpse"));
            set => SetFieldValue("ignoreCorpse", GenericMarshal.ToString(value));
        }


        public bool IgnoreLiving {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreLiving"));
            set => SetFieldValue("ignoreLiving", GenericMarshal.ToString(value));
        }


        public bool TreatAsDeathAnim {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("treatAsDeathAnim"));
            set => SetFieldValue("treatAsDeathAnim", GenericMarshal.ToString(value));
        }


        public bool LockAnimation {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("lockAnimation"));
            set => SetFieldValue("lockAnimation", GenericMarshal.ToString(value));
        }


        public bool IgnoreFirstPerson {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreFirstPerson"));
            set => SetFieldValue("ignoreFirstPerson", GenericMarshal.ToString(value));
        }


        public bool IgnoreThirdPerson {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreThirdPerson"));
            set => SetFieldValue("ignoreThirdPerson", GenericMarshal.ToString(value));
        }


        public bool IgnoreDisabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreDisabled"));
            set => SetFieldValue("ignoreDisabled", GenericMarshal.ToString(value));
        }


        public bool IgnoreEnabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreEnabled"));
            set => SetFieldValue("ignoreEnabled", GenericMarshal.ToString(value));
        }


    }
}
