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

    public unsafe class FlyingVehicleData : VehicleData {



        public FlyingVehicleData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public FlyingVehicleData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public FlyingVehicleData(string pName) 
            : this(pName, false) {
        }
        
        public FlyingVehicleData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public FlyingVehicleData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public FlyingVehicleData(SimObject pObj) 
            : base(pObj) {
        }
        
        public FlyingVehicleData(IntPtr pObj) 
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
                                    "fnFlyingVehicleData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnFlyingVehicleData_create"), typeof(_Create));
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
	





        public SFXProfile JetSound {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("jetSound"));
            set => SetFieldValue("jetSound", GenericMarshal.ToString(value));
        }


        public SFXProfile EngineSound {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("engineSound"));
            set => SetFieldValue("engineSound", GenericMarshal.ToString(value));
        }


        public float ManeuveringForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maneuveringForce"));
            set => SetFieldValue("maneuveringForce", GenericMarshal.ToString(value));
        }


        public float HorizontalSurfaceForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("horizontalSurfaceForce"));
            set => SetFieldValue("horizontalSurfaceForce", GenericMarshal.ToString(value));
        }


        public float VerticalSurfaceForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("verticalSurfaceForce"));
            set => SetFieldValue("verticalSurfaceForce", GenericMarshal.ToString(value));
        }


        public float VertThrustMultiple {
            get => GenericMarshal.StringTo<float>(GetFieldValue("vertThrustMultiple"));
            set => SetFieldValue("vertThrustMultiple", GenericMarshal.ToString(value));
        }


        public float SteeringForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("steeringForce"));
            set => SetFieldValue("steeringForce", GenericMarshal.ToString(value));
        }


        public float SteeringRollForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("steeringRollForce"));
            set => SetFieldValue("steeringRollForce", GenericMarshal.ToString(value));
        }


        public float RollForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("rollForce"));
            set => SetFieldValue("rollForce", GenericMarshal.ToString(value));
        }


        public float RotationalDrag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("rotationalDrag"));
            set => SetFieldValue("rotationalDrag", GenericMarshal.ToString(value));
        }


        public float MaxAutoSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxAutoSpeed"));
            set => SetFieldValue("maxAutoSpeed", GenericMarshal.ToString(value));
        }


        public float AutoInputDamping {
            get => GenericMarshal.StringTo<float>(GetFieldValue("autoInputDamping"));
            set => SetFieldValue("autoInputDamping", GenericMarshal.ToString(value));
        }


        public float AutoLinearForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("autoLinearForce"));
            set => SetFieldValue("autoLinearForce", GenericMarshal.ToString(value));
        }


        public float AutoAngularForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("autoAngularForce"));
            set => SetFieldValue("autoAngularForce", GenericMarshal.ToString(value));
        }


        public float HoverHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("hoverHeight"));
            set => SetFieldValue("hoverHeight", GenericMarshal.ToString(value));
        }


        public float CreateHoverHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("createHoverHeight"));
            set => SetFieldValue("createHoverHeight", GenericMarshal.ToString(value));
        }


        public ParticleEmitterData ForwardJetEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("forwardJetEmitter"));
            set => SetFieldValue("forwardJetEmitter", GenericMarshal.ToString(value));
        }


        public ParticleEmitterData BackwardJetEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("backwardJetEmitter"));
            set => SetFieldValue("backwardJetEmitter", GenericMarshal.ToString(value));
        }


        public ParticleEmitterData DownJetEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("downJetEmitter"));
            set => SetFieldValue("downJetEmitter", GenericMarshal.ToString(value));
        }


        public ParticleEmitterData TrailEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("trailEmitter"));
            set => SetFieldValue("trailEmitter", GenericMarshal.ToString(value));
        }


        public float MinTrailSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minTrailSpeed"));
            set => SetFieldValue("minTrailSpeed", GenericMarshal.ToString(value));
        }


    }
}