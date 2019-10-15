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
    public unsafe class PhysicsDebrisData : GameBaseData {
        public PhysicsDebrisData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public PhysicsDebrisData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public PhysicsDebrisData(string pName) 
            : this(pName, false) {
        }
        
        public PhysicsDebrisData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public PhysicsDebrisData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public PhysicsDebrisData(SimObject pObj) 
            : base(pObj) {
        }
        
        public PhysicsDebrisData(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Preload__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Preload(IntPtr _this, Preload__Args args);
            private static _Preload _PreloadFunc;
            internal static _Preload Preload() {
                if (_PreloadFunc == null) {
                    _PreloadFunc =
                        (_Preload)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPhysicsDebrisData_preload"), typeof(_Preload));
                }
                
                return _PreloadFunc;
            }

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
                                "fnPhysicsDebrisData_staticGetType"), typeof(_StaticGetType));
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
                                "fnPhysicsDebrisData_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void Preload() {
             InternalUnsafeMethods.Preload__Args _args = new InternalUnsafeMethods.Preload__Args() {
             };
             InternalUnsafeMethods.Preload()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string ShapeFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("shapeFile"));
            set => SetFieldValue("shapeFile", GenericMarshal.ToString(value));
        }

        public bool CastShadows {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("castShadows"));
            set => SetFieldValue("castShadows", GenericMarshal.ToString(value));
        }

        public float Lifetime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lifetime"));
            set => SetFieldValue("lifetime", GenericMarshal.ToString(value));
        }

        public float LifetimeVariance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lifetimeVariance"));
            set => SetFieldValue("lifetimeVariance", GenericMarshal.ToString(value));
        }

        public float Mass {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mass"));
            set => SetFieldValue("mass", GenericMarshal.ToString(value));
        }

        public float Friction {
            get => GenericMarshal.StringTo<float>(GetFieldValue("friction"));
            set => SetFieldValue("friction", GenericMarshal.ToString(value));
        }

        public float StaticFriction {
            get => GenericMarshal.StringTo<float>(GetFieldValue("staticFriction"));
            set => SetFieldValue("staticFriction", GenericMarshal.ToString(value));
        }

        public float Restitution {
            get => GenericMarshal.StringTo<float>(GetFieldValue("restitution"));
            set => SetFieldValue("restitution", GenericMarshal.ToString(value));
        }

        public float LinearDamping {
            get => GenericMarshal.StringTo<float>(GetFieldValue("linearDamping"));
            set => SetFieldValue("linearDamping", GenericMarshal.ToString(value));
        }

        public float AngularDamping {
            get => GenericMarshal.StringTo<float>(GetFieldValue("angularDamping"));
            set => SetFieldValue("angularDamping", GenericMarshal.ToString(value));
        }

        public float LinearSleepThreshold {
            get => GenericMarshal.StringTo<float>(GetFieldValue("linearSleepThreshold"));
            set => SetFieldValue("linearSleepThreshold", GenericMarshal.ToString(value));
        }

        public float AngularSleepThreshold {
            get => GenericMarshal.StringTo<float>(GetFieldValue("angularSleepThreshold"));
            set => SetFieldValue("angularSleepThreshold", GenericMarshal.ToString(value));
        }

        public float WaterDampingScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("waterDampingScale"));
            set => SetFieldValue("waterDampingScale", GenericMarshal.ToString(value));
        }

        public float BuoyancyDensity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("buoyancyDensity"));
            set => SetFieldValue("buoyancyDensity", GenericMarshal.ToString(value));
        }
    }
}