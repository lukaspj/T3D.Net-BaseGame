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

    public unsafe class HoverVehicleData : VehicleData {



        public HoverVehicleData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public HoverVehicleData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public HoverVehicleData(string pName) 
            : this(pName, false) {
        }
        
        public HoverVehicleData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public HoverVehicleData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public HoverVehicleData(SimObject pObj) 
            : base(pObj) {
        }
        
        public HoverVehicleData(IntPtr pObj) 
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
                                    "fnHoverVehicleData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnHoverVehicleData_create"), typeof(_Create));
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
	





        public float DragForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dragForce"));
            set => SetFieldValue("dragForce", GenericMarshal.ToString(value));
        }


        public float VertFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("vertFactor"));
            set => SetFieldValue("vertFactor", GenericMarshal.ToString(value));
        }


        public float FloatingThrustFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("floatingThrustFactor"));
            set => SetFieldValue("floatingThrustFactor", GenericMarshal.ToString(value));
        }


        public float MainThrustForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mainThrustForce"));
            set => SetFieldValue("mainThrustForce", GenericMarshal.ToString(value));
        }


        public float ReverseThrustForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverseThrustForce"));
            set => SetFieldValue("reverseThrustForce", GenericMarshal.ToString(value));
        }


        public float StrafeThrustForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("strafeThrustForce"));
            set => SetFieldValue("strafeThrustForce", GenericMarshal.ToString(value));
        }


        public float TurboFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("turboFactor"));
            set => SetFieldValue("turboFactor", GenericMarshal.ToString(value));
        }


        public float StabLenMin {
            get => GenericMarshal.StringTo<float>(GetFieldValue("stabLenMin"));
            set => SetFieldValue("stabLenMin", GenericMarshal.ToString(value));
        }


        public float StabLenMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("stabLenMax"));
            set => SetFieldValue("stabLenMax", GenericMarshal.ToString(value));
        }


        public float StabSpringConstant {
            get => GenericMarshal.StringTo<float>(GetFieldValue("stabSpringConstant"));
            set => SetFieldValue("stabSpringConstant", GenericMarshal.ToString(value));
        }


        public float StabDampingConstant {
            get => GenericMarshal.StringTo<float>(GetFieldValue("stabDampingConstant"));
            set => SetFieldValue("stabDampingConstant", GenericMarshal.ToString(value));
        }


        public float GyroDrag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gyroDrag"));
            set => SetFieldValue("gyroDrag", GenericMarshal.ToString(value));
        }


        public float NormalForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("normalForce"));
            set => SetFieldValue("normalForce", GenericMarshal.ToString(value));
        }


        public float RestorativeForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("restorativeForce"));
            set => SetFieldValue("restorativeForce", GenericMarshal.ToString(value));
        }


        public float SteeringForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("steeringForce"));
            set => SetFieldValue("steeringForce", GenericMarshal.ToString(value));
        }


        public float RollForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("rollForce"));
            set => SetFieldValue("rollForce", GenericMarshal.ToString(value));
        }


        public float PitchForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("pitchForce"));
            set => SetFieldValue("pitchForce", GenericMarshal.ToString(value));
        }


        public SFXProfile JetSound {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("jetSound"));
            set => SetFieldValue("jetSound", GenericMarshal.ToString(value));
        }


        public SFXProfile EngineSound {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("engineSound"));
            set => SetFieldValue("engineSound", GenericMarshal.ToString(value));
        }


        public SFXProfile FloatSound {
            get => GenericMarshal.StringTo<SFXProfile>(GetFieldValue("floatSound"));
            set => SetFieldValue("floatSound", GenericMarshal.ToString(value));
        }


        public ParticleEmitterData DustTrailEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("dustTrailEmitter"));
            set => SetFieldValue("dustTrailEmitter", GenericMarshal.ToString(value));
        }


        public Point3F DustTrailOffset {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("dustTrailOffset"));
            set => SetFieldValue("dustTrailOffset", GenericMarshal.ToString(value));
        }


        public float TriggerTrailHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("triggerTrailHeight"));
            set => SetFieldValue("triggerTrailHeight", GenericMarshal.ToString(value));
        }


        public float DustTrailFreqMod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dustTrailFreqMod"));
            set => SetFieldValue("dustTrailFreqMod", GenericMarshal.ToString(value));
        }


        public float FloatingGravMag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("floatingGravMag"));
            set => SetFieldValue("floatingGravMag", GenericMarshal.ToString(value));
        }


        public float BrakingForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("brakingForce"));
            set => SetFieldValue("brakingForce", GenericMarshal.ToString(value));
        }


        public float BrakingActivationSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("brakingActivationSpeed"));
            set => SetFieldValue("brakingActivationSpeed", GenericMarshal.ToString(value));
        }


        public ParticleEmitterData ForwardJetEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("forwardJetEmitter"));
            set => SetFieldValue("forwardJetEmitter", GenericMarshal.ToString(value));
        }


    }
}