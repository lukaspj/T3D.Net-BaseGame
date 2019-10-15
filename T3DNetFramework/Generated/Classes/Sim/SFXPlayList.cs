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
    public unsafe class SFXPlayList : SFXTrack {
        public SFXPlayList(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public SFXPlayList(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public SFXPlayList(string pName) 
            : this(pName, false) {
        }
        
        public SFXPlayList(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public SFXPlayList(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public SFXPlayList(SimObject pObj) 
            : base(pObj) {
        }
        
        public SFXPlayList(IntPtr pObj) 
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
                                "fnSFXPlayList_staticGetType"), typeof(_StaticGetType));
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
                                "fnSFXPlayList_create"), typeof(_Create));
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

        public SFXPlayListRandomMode Random {
            get => GenericMarshal.StringTo<SFXPlayListRandomMode>(GetFieldValue("random"));
            set => SetFieldValue("random", GenericMarshal.ToString(value));
        }

        public SFXPlayListLoopMode LoopMode {
            get => GenericMarshal.StringTo<SFXPlayListLoopMode>(GetFieldValue("loopMode"));
            set => SetFieldValue("loopMode", GenericMarshal.ToString(value));
        }

        public int NumSlotsToPlay {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numSlotsToPlay"));
            set => SetFieldValue("numSlotsToPlay", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<SFXTrack> Track {
            get => new DynamicFieldVector<SFXTrack>(
                    this, 
                    "track", 
                    12, 
                    val => GenericMarshal.StringTo<SFXTrack>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<SFXPlayListReplayMode> Replay {
            get => new DynamicFieldVector<SFXPlayListReplayMode>(
                    this, 
                    "replay", 
                    12, 
                    val => GenericMarshal.StringTo<SFXPlayListReplayMode>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<SFXPlayListTransitionMode> TransitionIn {
            get => new DynamicFieldVector<SFXPlayListTransitionMode>(
                    this, 
                    "transitionIn", 
                    12, 
                    val => GenericMarshal.StringTo<SFXPlayListTransitionMode>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<SFXPlayListTransitionMode> TransitionOut {
            get => new DynamicFieldVector<SFXPlayListTransitionMode>(
                    this, 
                    "transitionOut", 
                    12, 
                    val => GenericMarshal.StringTo<SFXPlayListTransitionMode>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> DelayTimeIn {
            get => new DynamicFieldVector<float>(
                    this, 
                    "delayTimeIn", 
                    12, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<Point2F> DelayTimeInVariance {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "delayTimeInVariance", 
                    12, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> DelayTimeOut {
            get => new DynamicFieldVector<float>(
                    this, 
                    "delayTimeOut", 
                    12, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<Point2F> DelayTimeOutVariance {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "delayTimeOutVariance", 
                    12, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> FadeTimeIn {
            get => new DynamicFieldVector<float>(
                    this, 
                    "fadeTimeIn", 
                    12, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<Point2F> FadeTimeInVariance {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "fadeTimeInVariance", 
                    12, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> FadeTimeOut {
            get => new DynamicFieldVector<float>(
                    this, 
                    "fadeTimeOut", 
                    12, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<Point2F> FadeTimeOutVariance {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "fadeTimeOutVariance", 
                    12, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> ReferenceDistance {
            get => new DynamicFieldVector<float>(
                    this, 
                    "referenceDistance", 
                    12, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<Point2F> ReferenceDistanceVariance {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "referenceDistanceVariance", 
                    12, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> MaxDistance {
            get => new DynamicFieldVector<float>(
                    this, 
                    "maxDistance", 
                    12, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<Point2F> MaxDistanceVariance {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "maxDistanceVariance", 
                    12, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> VolumeScale {
            get => new DynamicFieldVector<float>(
                    this, 
                    "volumeScale", 
                    12, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<Point2F> VolumeScaleVariance {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "volumeScaleVariance", 
                    12, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> PitchScale {
            get => new DynamicFieldVector<float>(
                    this, 
                    "pitchScale", 
                    12, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<Point2F> PitchScaleVariance {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "pitchScaleVariance", 
                    12, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<int> RepeatCount {
            get => new DynamicFieldVector<int>(
                    this, 
                    "repeatCount", 
                    12, 
                    val => GenericMarshal.StringTo<int>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<SFXState> State {
            get => new DynamicFieldVector<SFXState>(
                    this, 
                    "state", 
                    12, 
                    val => GenericMarshal.StringTo<SFXState>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<SFXPlayListStateMode> StateMode {
            get => new DynamicFieldVector<SFXPlayListStateMode>(
                    this, 
                    "stateMode", 
                    12, 
                    val => GenericMarshal.StringTo<SFXPlayListStateMode>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public bool Trace {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("trace"));
            set => SetFieldValue("trace", GenericMarshal.ToString(value));
        }
    }
}