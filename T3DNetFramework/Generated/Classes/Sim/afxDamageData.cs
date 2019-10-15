using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;

namespace T3DNetFramework.Generated.Classes.Sim {    
    public unsafe class afxDamageData : GameBaseData {
        public afxDamageData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public afxDamageData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public afxDamageData(string pName) 
            : this(pName, false) {
        }
        
        public afxDamageData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public afxDamageData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public afxDamageData(SimObject pObj) 
            : base(pObj) {
        }
        
        public afxDamageData(IntPtr pObj) 
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
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
                if (_StaticGetTypeFunc == null) {
                    _StaticGetTypeFunc =
                        (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnafxDamageData_staticGetType"), typeof(_StaticGetType));
                }
                
                return _StaticGetTypeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Create__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _Create(Create__Args args);
            private static _Create _CreateFunc;
            internal static _Create Create() {
                if (_CreateFunc == null) {
                    _CreateFunc =
                        (_Create)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnafxDamageData_create"), typeof(_Create));
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

        public string Label {
            get => GenericMarshal.StringTo<string>(GetFieldValue("label"));
            set => SetFieldValue("label", GenericMarshal.ToString(value));
        }

        public string Flavor {
            get => GenericMarshal.StringTo<string>(GetFieldValue("flavor"));
            set => SetFieldValue("flavor", GenericMarshal.ToString(value));
        }

        public float DirectDamage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("directDamage"));
            set => SetFieldValue("directDamage", GenericMarshal.ToString(value));
        }

        public sbyte DirectDamageRepeats {
            get => GenericMarshal.StringTo<sbyte>(GetFieldValue("directDamageRepeats"));
            set => SetFieldValue("directDamageRepeats", GenericMarshal.ToString(value));
        }

        public float AreaDamage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("areaDamage"));
            set => SetFieldValue("areaDamage", GenericMarshal.ToString(value));
        }

        public float AreaDamageRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("areaDamageRadius"));
            set => SetFieldValue("areaDamageRadius", GenericMarshal.ToString(value));
        }

        public float AreaDamageImpulse {
            get => GenericMarshal.StringTo<float>(GetFieldValue("areaDamageImpulse"));
            set => SetFieldValue("areaDamageImpulse", GenericMarshal.ToString(value));
        }
    }
}