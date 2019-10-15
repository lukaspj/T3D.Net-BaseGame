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
    public unsafe class AITurretShapeData : TurretShapeData {
        public AITurretShapeData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public AITurretShapeData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public AITurretShapeData(string pName) 
            : this(pName, false) {
        }
        
        public AITurretShapeData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public AITurretShapeData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public AITurretShapeData(SimObject pObj) 
            : base(pObj) {
        }
        
        public AITurretShapeData(IntPtr pObj) 
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
                                "fnAITurretShapeData_staticGetType"), typeof(_StaticGetType));
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
                                "fnAITurretShapeData_create"), typeof(_Create));
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

        public float MaxScanHeading {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxScanHeading"));
            set => SetFieldValue("maxScanHeading", GenericMarshal.ToString(value));
        }

        public float MaxScanPitch {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxScanPitch"));
            set => SetFieldValue("maxScanPitch", GenericMarshal.ToString(value));
        }

        public float MaxScanDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxScanDistance"));
            set => SetFieldValue("maxScanDistance", GenericMarshal.ToString(value));
        }

        public int ScanTickFrequency {
            get => GenericMarshal.StringTo<int>(GetFieldValue("scanTickFrequency"));
            set => SetFieldValue("scanTickFrequency", GenericMarshal.ToString(value));
        }

        public int ScanTickFrequencyVariance {
            get => GenericMarshal.StringTo<int>(GetFieldValue("scanTickFrequencyVariance"));
            set => SetFieldValue("scanTickFrequencyVariance", GenericMarshal.ToString(value));
        }

        public float TrackLostTargetTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("trackLostTargetTime"));
            set => SetFieldValue("trackLostTargetTime", GenericMarshal.ToString(value));
        }

        public float MaxWeaponRange {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxWeaponRange"));
            set => SetFieldValue("maxWeaponRange", GenericMarshal.ToString(value));
        }

        public float WeaponLeadVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("weaponLeadVelocity"));
            set => SetFieldValue("weaponLeadVelocity", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<string> StateName {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateName", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnAtRest {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnAtRest", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnNotAtRest {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnNotAtRest", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnTarget {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnTarget", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnNoTarget {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnNoTarget", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnActivated {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnActivated", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnDeactivated {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnDeactivated", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnTimeout {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnTimeout", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> StateTimeoutValue {
            get => new DynamicFieldVector<float>(
                    this, 
                    "stateTimeoutValue", 
                    31, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateWaitForTimeout {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateWaitForTimeout", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateFire {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateFire", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateScan {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateScan", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateDirection {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateDirection", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateSequence {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateSequence", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateScaleAnimation {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateScaleAnimation", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateScript {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateScript", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }
    }
}