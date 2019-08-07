using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DSharpFramework.Engine;
using T3DSharpFramework.Engine.Util;
using T3DSharpFramework.Generated.Classes.Global;
using T3DSharpFramework.Generated.Classes.Reflection;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Classes.Sim.Net;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Enums.Reflection;
using T3DSharpFramework.Generated.Structs.Global;
using T3DSharpFramework.Generated.Structs.Gui;
using T3DSharpFramework.Generated.Structs.Math;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Generated.Classes.Sim {    

    public unsafe class PhysicsShapeData : GameBaseData {



        public PhysicsShapeData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public PhysicsShapeData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public PhysicsShapeData(string pName) 
            : this(pName, false) {
        }
        
        public PhysicsShapeData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public PhysicsShapeData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public PhysicsShapeData(SimObject pObj) 
            : base(pObj) {
        }
        
        public PhysicsShapeData(IntPtr pObj) 
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
                                    "fnPhysicsShapeData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnPhysicsShapeData_create"), typeof(_Create));
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
	





        public string ShapeName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("shapeName"));
            set => SetFieldValue("shapeName", GenericMarshal.ToString(value));
        }


        public PhysicsDebrisData Debris {
            get => GenericMarshal.StringTo<PhysicsDebrisData>(GetFieldValue("Debris"));
            set => SetFieldValue("Debris", GenericMarshal.ToString(value));
        }


        public ExplosionData Explosion {
            get => GenericMarshal.StringTo<ExplosionData>(GetFieldValue("Explosion"));
            set => SetFieldValue("Explosion", GenericMarshal.ToString(value));
        }


        public PhysicsShapeData DestroyedShape {
            get => GenericMarshal.StringTo<PhysicsShapeData>(GetFieldValue("destroyedShape"));
            set => SetFieldValue("destroyedShape", GenericMarshal.ToString(value));
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


        public PhysicsSimType SimType {
            get => GenericMarshal.StringTo<PhysicsSimType>(GetFieldValue("simType"));
            set => SetFieldValue("simType", GenericMarshal.ToString(value));
        }


    }
}