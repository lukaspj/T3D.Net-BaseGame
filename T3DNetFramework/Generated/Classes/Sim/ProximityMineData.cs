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
    public unsafe class ProximityMineData : ItemData {
        public ProximityMineData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ProximityMineData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ProximityMineData(string pName) 
            : this(pName, false) {
        }
        
        public ProximityMineData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ProximityMineData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ProximityMineData(SimObject pObj) 
            : base(pObj) {
        }
        
        public ProximityMineData(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnExplode__Args
            {
                internal IntPtr obj;
                internal IntPtr pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnExplode(IntPtr _this, OnExplode__Args args);
            private static _OnExplode _OnExplodeFunc;
            internal static _OnExplode OnExplode() {
                if (_OnExplodeFunc == null) {
                    _OnExplodeFunc =
                        (_OnExplode)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbProximityMineData_onExplode"), typeof(_OnExplode));
                }
                
                return _OnExplodeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnTriggered__Args
            {
                internal IntPtr obj;
                internal IntPtr target;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnTriggered(IntPtr _this, OnTriggered__Args args);
            private static _OnTriggered _OnTriggeredFunc;
            internal static _OnTriggered OnTriggered() {
                if (_OnTriggeredFunc == null) {
                    _OnTriggeredFunc =
                        (_OnTriggered)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbProximityMineData_onTriggered"), typeof(_OnTriggered));
                }
                
                return _OnTriggeredFunc;
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
                                "fnProximityMineData_staticGetType"), typeof(_StaticGetType));
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
                                "fnProximityMineData_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public virtual void OnExplode(ProximityMine obj, Point3F pos) {
pos.Alloc();             InternalUnsafeMethods.OnExplode__Args _args = new InternalUnsafeMethods.OnExplode__Args() {
                obj = obj.ObjectPtr,
                pos = pos.internalStructPtr,
             };
             InternalUnsafeMethods.OnExplode()(ObjectPtr, _args);
pos.Free();        }

        public virtual void OnTriggered(ProximityMine obj, SceneObject target) {
             InternalUnsafeMethods.OnTriggered__Args _args = new InternalUnsafeMethods.OnTriggered__Args() {
                obj = obj.ObjectPtr,
                target = target.ObjectPtr,
             };
             InternalUnsafeMethods.OnTriggered()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public float ArmingDelay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("armingDelay"));
            set => SetFieldValue("armingDelay", GenericMarshal.ToString(value));
        }

        public SFXTrack ArmingSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("armingSound"));
            set => SetFieldValue("armingSound", GenericMarshal.ToString(value));
        }

        public float AutoTriggerDelay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("autoTriggerDelay"));
            set => SetFieldValue("autoTriggerDelay", GenericMarshal.ToString(value));
        }

        public bool TriggerOnOwner {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("triggerOnOwner"));
            set => SetFieldValue("triggerOnOwner", GenericMarshal.ToString(value));
        }

        public float TriggerRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("triggerRadius"));
            set => SetFieldValue("triggerRadius", GenericMarshal.ToString(value));
        }

        public float TriggerSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("triggerSpeed"));
            set => SetFieldValue("triggerSpeed", GenericMarshal.ToString(value));
        }

        public float TriggerDelay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("triggerDelay"));
            set => SetFieldValue("triggerDelay", GenericMarshal.ToString(value));
        }

        public SFXTrack TriggerSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("triggerSound"));
            set => SetFieldValue("triggerSound", GenericMarshal.ToString(value));
        }

        public float ExplosionOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("explosionOffset"));
            set => SetFieldValue("explosionOffset", GenericMarshal.ToString(value));
        }
    }
}