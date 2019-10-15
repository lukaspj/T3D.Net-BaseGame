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
    public unsafe class SFXEnvironment : SimDataBlock {
        public SFXEnvironment(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public SFXEnvironment(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public SFXEnvironment(string pName) 
            : this(pName, false) {
        }
        
        public SFXEnvironment(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public SFXEnvironment(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public SFXEnvironment(SimObject pObj) 
            : base(pObj) {
        }
        
        public SFXEnvironment(IntPtr pObj) 
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
                                "fnSFXEnvironment_staticGetType"), typeof(_StaticGetType));
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
                                "fnSFXEnvironment_create"), typeof(_Create));
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

        public float ReverbDensity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbDensity"));
            set => SetFieldValue("reverbDensity", GenericMarshal.ToString(value));
        }

        public float ReverbDiffusion {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbDiffusion"));
            set => SetFieldValue("reverbDiffusion", GenericMarshal.ToString(value));
        }

        public float ReverbGain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbGain"));
            set => SetFieldValue("reverbGain", GenericMarshal.ToString(value));
        }

        public float ReverbGainHF {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbGainHF"));
            set => SetFieldValue("reverbGainHF", GenericMarshal.ToString(value));
        }

        public float ReverbGainLF {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbGainLF"));
            set => SetFieldValue("reverbGainLF", GenericMarshal.ToString(value));
        }

        public float ReverbDecayTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbDecayTime"));
            set => SetFieldValue("reverbDecayTime", GenericMarshal.ToString(value));
        }

        public float ReverbDecayHFRatio {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbDecayHFRatio"));
            set => SetFieldValue("reverbDecayHFRatio", GenericMarshal.ToString(value));
        }

        public float ReverbDecayLFRatio {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbDecayLFRatio"));
            set => SetFieldValue("reverbDecayLFRatio", GenericMarshal.ToString(value));
        }

        public float ReflectionsGain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reflectionsGain"));
            set => SetFieldValue("reflectionsGain", GenericMarshal.ToString(value));
        }

        public float ReflectionDelay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reflectionDelay"));
            set => SetFieldValue("reflectionDelay", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<float> ReflectionsPan {
            get => new DynamicFieldVector<float>(
                    this, 
                    "reflectionsPan", 
                    3, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public float LateReverbGain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lateReverbGain"));
            set => SetFieldValue("lateReverbGain", GenericMarshal.ToString(value));
        }

        public float LateReverbDelay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lateReverbDelay"));
            set => SetFieldValue("lateReverbDelay", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<float> LateReverbPan {
            get => new DynamicFieldVector<float>(
                    this, 
                    "lateReverbPan", 
                    3, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public float ReverbEchoTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbEchoTime"));
            set => SetFieldValue("reverbEchoTime", GenericMarshal.ToString(value));
        }

        public float ReverbEchoDepth {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbEchoDepth"));
            set => SetFieldValue("reverbEchoDepth", GenericMarshal.ToString(value));
        }

        public float ReverbModTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbModTime"));
            set => SetFieldValue("reverbModTime", GenericMarshal.ToString(value));
        }

        public float ReverbModDepth {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbModDepth"));
            set => SetFieldValue("reverbModDepth", GenericMarshal.ToString(value));
        }

        public float AirAbsorbtionGainHF {
            get => GenericMarshal.StringTo<float>(GetFieldValue("airAbsorbtionGainHF"));
            set => SetFieldValue("airAbsorbtionGainHF", GenericMarshal.ToString(value));
        }

        public float ReverbHFRef {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbHFRef"));
            set => SetFieldValue("reverbHFRef", GenericMarshal.ToString(value));
        }

        public float ReverbLFRef {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverbLFRef"));
            set => SetFieldValue("reverbLFRef", GenericMarshal.ToString(value));
        }

        public float RoomRolloffFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("roomRolloffFactor"));
            set => SetFieldValue("roomRolloffFactor", GenericMarshal.ToString(value));
        }

        public int DecayHFLimit {
            get => GenericMarshal.StringTo<int>(GetFieldValue("decayHFLimit"));
            set => SetFieldValue("decayHFLimit", GenericMarshal.ToString(value));
        }
    }
}