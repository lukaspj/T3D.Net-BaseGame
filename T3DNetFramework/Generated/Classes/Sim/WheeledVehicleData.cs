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
    public unsafe class WheeledVehicleData : VehicleData {
        public WheeledVehicleData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public WheeledVehicleData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public WheeledVehicleData(string pName) 
            : this(pName, false) {
        }
        
        public WheeledVehicleData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public WheeledVehicleData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public WheeledVehicleData(SimObject pObj) 
            : base(pObj) {
        }
        
        public WheeledVehicleData(IntPtr pObj) 
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
                                "fnWheeledVehicleData_staticGetType"), typeof(_StaticGetType));
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
                                "fnWheeledVehicleData_create"), typeof(_Create));
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

        public SFXTrack JetSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("jetSound"));
            set => SetFieldValue("jetSound", GenericMarshal.ToString(value));
        }

        public SFXTrack EngineSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("engineSound"));
            set => SetFieldValue("engineSound", GenericMarshal.ToString(value));
        }

        public SFXTrack SquealSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("squealSound"));
            set => SetFieldValue("squealSound", GenericMarshal.ToString(value));
        }

        public SFXTrack WheelImpactSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("WheelImpactSound"));
            set => SetFieldValue("WheelImpactSound", GenericMarshal.ToString(value));
        }

        public ParticleEmitterData TireEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("tireEmitter"));
            set => SetFieldValue("tireEmitter", GenericMarshal.ToString(value));
        }

        public float MaxWheelSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxWheelSpeed"));
            set => SetFieldValue("maxWheelSpeed", GenericMarshal.ToString(value));
        }

        public float EngineTorque {
            get => GenericMarshal.StringTo<float>(GetFieldValue("engineTorque"));
            set => SetFieldValue("engineTorque", GenericMarshal.ToString(value));
        }

        public float EngineBrake {
            get => GenericMarshal.StringTo<float>(GetFieldValue("engineBrake"));
            set => SetFieldValue("engineBrake", GenericMarshal.ToString(value));
        }

        public float BrakeTorque {
            get => GenericMarshal.StringTo<float>(GetFieldValue("brakeTorque"));
            set => SetFieldValue("brakeTorque", GenericMarshal.ToString(value));
        }
    }
}