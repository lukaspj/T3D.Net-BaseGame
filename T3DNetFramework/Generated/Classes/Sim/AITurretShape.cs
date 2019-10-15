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
    public unsafe class AITurretShape : TurretShape {
        public AITurretShape(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public AITurretShape(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public AITurretShape(string pName) 
            : this(pName, false) {
        }
        
        public AITurretShape(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public AITurretShape(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public AITurretShape(SimObject pObj) 
            : base(pObj) {
        }
        
        public AITurretShape(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct RecenterTurret__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RecenterTurret(IntPtr _this, RecenterTurret__Args args);
            private static _RecenterTurret _RecenterTurretFunc;
            internal static _RecenterTurret RecenterTurret() {
                if (_RecenterTurretFunc == null) {
                    _RecenterTurretFunc =
                        (_RecenterTurret)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_recenterTurret"), typeof(_RecenterTurret));
                }
                
                return _RecenterTurretFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetGunSlotFiring__Args
            {
                internal int slot;
                [MarshalAs(UnmanagedType.I1)]
                internal bool fire;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetGunSlotFiring(IntPtr _this, SetGunSlotFiring__Args args);
            private static _SetGunSlotFiring _SetGunSlotFiringFunc;
            internal static _SetGunSlotFiring SetGunSlotFiring() {
                if (_SetGunSlotFiringFunc == null) {
                    _SetGunSlotFiringFunc =
                        (_SetGunSlotFiring)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_setGunSlotFiring"), typeof(_SetGunSlotFiring));
                }
                
                return _SetGunSlotFiringFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAllGunsFiring__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool fire;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAllGunsFiring(IntPtr _this, SetAllGunsFiring__Args args);
            private static _SetAllGunsFiring _SetAllGunsFiringFunc;
            internal static _SetAllGunsFiring SetAllGunsFiring() {
                if (_SetAllGunsFiringFunc == null) {
                    _SetAllGunsFiringFunc =
                        (_SetAllGunsFiring)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_setAllGunsFiring"), typeof(_SetAllGunsFiring));
                }
                
                return _SetAllGunsFiringFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetWeaponLeadVelocity__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetWeaponLeadVelocity(IntPtr _this, GetWeaponLeadVelocity__Args args);
            private static _GetWeaponLeadVelocity _GetWeaponLeadVelocityFunc;
            internal static _GetWeaponLeadVelocity GetWeaponLeadVelocity() {
                if (_GetWeaponLeadVelocityFunc == null) {
                    _GetWeaponLeadVelocityFunc =
                        (_GetWeaponLeadVelocity)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_getWeaponLeadVelocity"), typeof(_GetWeaponLeadVelocity));
                }
                
                return _GetWeaponLeadVelocityFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetWeaponLeadVelocity__Args
            {
                internal float velocity;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetWeaponLeadVelocity(IntPtr _this, SetWeaponLeadVelocity__Args args);
            private static _SetWeaponLeadVelocity _SetWeaponLeadVelocityFunc;
            internal static _SetWeaponLeadVelocity SetWeaponLeadVelocity() {
                if (_SetWeaponLeadVelocityFunc == null) {
                    _SetWeaponLeadVelocityFunc =
                        (_SetWeaponLeadVelocity)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_setWeaponLeadVelocity"), typeof(_SetWeaponLeadVelocity));
                }
                
                return _SetWeaponLeadVelocityFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ResetTarget__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ResetTarget(IntPtr _this, ResetTarget__Args args);
            private static _ResetTarget _ResetTargetFunc;
            internal static _ResetTarget ResetTarget() {
                if (_ResetTargetFunc == null) {
                    _ResetTargetFunc =
                        (_ResetTarget)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_resetTarget"), typeof(_ResetTarget));
                }
                
                return _ResetTargetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTarget__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _GetTarget(IntPtr _this, GetTarget__Args args);
            private static _GetTarget _GetTargetFunc;
            internal static _GetTarget GetTarget() {
                if (_GetTargetFunc == null) {
                    _GetTargetFunc =
                        (_GetTarget)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_getTarget"), typeof(_GetTarget));
                }
                
                return _GetTargetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct HasTarget__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _HasTarget(IntPtr _this, HasTarget__Args args);
            private static _HasTarget _HasTargetFunc;
            internal static _HasTarget HasTarget() {
                if (_HasTargetFunc == null) {
                    _HasTargetFunc =
                        (_HasTarget)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_hasTarget"), typeof(_HasTarget));
                }
                
                return _HasTargetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct StopTrackingTarget__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _StopTrackingTarget(IntPtr _this, StopTrackingTarget__Args args);
            private static _StopTrackingTarget _StopTrackingTargetFunc;
            internal static _StopTrackingTarget StopTrackingTarget() {
                if (_StopTrackingTargetFunc == null) {
                    _StopTrackingTargetFunc =
                        (_StopTrackingTarget)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_stopTrackingTarget"), typeof(_StopTrackingTarget));
                }
                
                return _StopTrackingTargetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct StartTrackingTarget__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _StartTrackingTarget(IntPtr _this, StartTrackingTarget__Args args);
            private static _StartTrackingTarget _StartTrackingTargetFunc;
            internal static _StartTrackingTarget StartTrackingTarget() {
                if (_StartTrackingTargetFunc == null) {
                    _StartTrackingTargetFunc =
                        (_StartTrackingTarget)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_startTrackingTarget"), typeof(_StartTrackingTarget));
                }
                
                return _StartTrackingTargetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct StopScanForTargets__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _StopScanForTargets(IntPtr _this, StopScanForTargets__Args args);
            private static _StopScanForTargets _StopScanForTargetsFunc;
            internal static _StopScanForTargets StopScanForTargets() {
                if (_StopScanForTargetsFunc == null) {
                    _StopScanForTargetsFunc =
                        (_StopScanForTargets)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_stopScanForTargets"), typeof(_StopScanForTargets));
                }
                
                return _StopScanForTargetsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct StartScanForTargets__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _StartScanForTargets(IntPtr _this, StartScanForTargets__Args args);
            private static _StartScanForTargets _StartScanForTargetsFunc;
            internal static _StartScanForTargets StartScanForTargets() {
                if (_StartScanForTargetsFunc == null) {
                    _StartScanForTargetsFunc =
                        (_StartScanForTargets)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_startScanForTargets"), typeof(_StartScanForTargets));
                }
                
                return _StartScanForTargetsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct DeactivateTurret__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DeactivateTurret(IntPtr _this, DeactivateTurret__Args args);
            private static _DeactivateTurret _DeactivateTurretFunc;
            internal static _DeactivateTurret DeactivateTurret() {
                if (_DeactivateTurretFunc == null) {
                    _DeactivateTurretFunc =
                        (_DeactivateTurret)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_deactivateTurret"), typeof(_DeactivateTurret));
                }
                
                return _DeactivateTurretFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ActivateTurret__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ActivateTurret(IntPtr _this, ActivateTurret__Args args);
            private static _ActivateTurret _ActivateTurretFunc;
            internal static _ActivateTurret ActivateTurret() {
                if (_ActivateTurretFunc == null) {
                    _ActivateTurretFunc =
                        (_ActivateTurret)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_activateTurret"), typeof(_ActivateTurret));
                }
                
                return _ActivateTurretFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetTurretState__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newState;
                [MarshalAs(UnmanagedType.I1)]
                internal bool force;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetTurretState(IntPtr _this, SetTurretState__Args args);
            private static _SetTurretState _SetTurretStateFunc;
            internal static _SetTurretState SetTurretState() {
                if (_SetTurretStateFunc == null) {
                    _SetTurretStateFunc =
                        (_SetTurretState)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_setTurretState"), typeof(_SetTurretState));
                }
                
                return _SetTurretStateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetIgnoreListObject__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _GetIgnoreListObject(IntPtr _this, GetIgnoreListObject__Args args);
            private static _GetIgnoreListObject _GetIgnoreListObjectFunc;
            internal static _GetIgnoreListObject GetIgnoreListObject() {
                if (_GetIgnoreListObjectFunc == null) {
                    _GetIgnoreListObjectFunc =
                        (_GetIgnoreListObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_getIgnoreListObject"), typeof(_GetIgnoreListObject));
                }
                
                return _GetIgnoreListObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IgnoreListCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _IgnoreListCount(IntPtr _this, IgnoreListCount__Args args);
            private static _IgnoreListCount _IgnoreListCountFunc;
            internal static _IgnoreListCount IgnoreListCount() {
                if (_IgnoreListCountFunc == null) {
                    _IgnoreListCountFunc =
                        (_IgnoreListCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_ignoreListCount"), typeof(_IgnoreListCount));
                }
                
                return _IgnoreListCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearIgnoreList__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearIgnoreList(IntPtr _this, ClearIgnoreList__Args args);
            private static _ClearIgnoreList _ClearIgnoreListFunc;
            internal static _ClearIgnoreList ClearIgnoreList() {
                if (_ClearIgnoreListFunc == null) {
                    _ClearIgnoreListFunc =
                        (_ClearIgnoreList)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_clearIgnoreList"), typeof(_ClearIgnoreList));
                }
                
                return _ClearIgnoreListFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveFromIgnoreList__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveFromIgnoreList(IntPtr _this, RemoveFromIgnoreList__Args args);
            private static _RemoveFromIgnoreList _RemoveFromIgnoreListFunc;
            internal static _RemoveFromIgnoreList RemoveFromIgnoreList() {
                if (_RemoveFromIgnoreListFunc == null) {
                    _RemoveFromIgnoreListFunc =
                        (_RemoveFromIgnoreList)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_removeFromIgnoreList"), typeof(_RemoveFromIgnoreList));
                }
                
                return _RemoveFromIgnoreListFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddToIgnoreList__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddToIgnoreList(IntPtr _this, AddToIgnoreList__Args args);
            private static _AddToIgnoreList _AddToIgnoreListFunc;
            internal static _AddToIgnoreList AddToIgnoreList() {
                if (_AddToIgnoreListFunc == null) {
                    _AddToIgnoreListFunc =
                        (_AddToIgnoreList)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAITurretShape_addToIgnoreList"), typeof(_AddToIgnoreList));
                }
                
                return _AddToIgnoreListFunc;
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
                                "fnAITurretShape_staticGetType"), typeof(_StaticGetType));
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
                                "fnAITurretShape_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void RecenterTurret() {
             InternalUnsafeMethods.RecenterTurret__Args _args = new InternalUnsafeMethods.RecenterTurret__Args() {
             };
             InternalUnsafeMethods.RecenterTurret()(ObjectPtr, _args);
        }

        public void SetGunSlotFiring(int slot, bool fire) {
             InternalUnsafeMethods.SetGunSlotFiring__Args _args = new InternalUnsafeMethods.SetGunSlotFiring__Args() {
                slot = slot,
                fire = fire,
             };
             InternalUnsafeMethods.SetGunSlotFiring()(ObjectPtr, _args);
        }

        public void SetAllGunsFiring(bool fire) {
             InternalUnsafeMethods.SetAllGunsFiring__Args _args = new InternalUnsafeMethods.SetAllGunsFiring__Args() {
                fire = fire,
             };
             InternalUnsafeMethods.SetAllGunsFiring()(ObjectPtr, _args);
        }

        public float GetWeaponLeadVelocity() {
             InternalUnsafeMethods.GetWeaponLeadVelocity__Args _args = new InternalUnsafeMethods.GetWeaponLeadVelocity__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetWeaponLeadVelocity()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetWeaponLeadVelocity(float velocity) {
             InternalUnsafeMethods.SetWeaponLeadVelocity__Args _args = new InternalUnsafeMethods.SetWeaponLeadVelocity__Args() {
                velocity = velocity,
             };
             InternalUnsafeMethods.SetWeaponLeadVelocity()(ObjectPtr, _args);
        }

        public void ResetTarget() {
             InternalUnsafeMethods.ResetTarget__Args _args = new InternalUnsafeMethods.ResetTarget__Args() {
             };
             InternalUnsafeMethods.ResetTarget()(ObjectPtr, _args);
        }

        public SimObject GetTarget() {
             InternalUnsafeMethods.GetTarget__Args _args = new InternalUnsafeMethods.GetTarget__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTarget()(ObjectPtr, _args);
             return new SimObject(_engineResult);
        }

        public bool HasTarget() {
             InternalUnsafeMethods.HasTarget__Args _args = new InternalUnsafeMethods.HasTarget__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.HasTarget()(ObjectPtr, _args);
             return _engineResult;
        }

        public void StopTrackingTarget() {
             InternalUnsafeMethods.StopTrackingTarget__Args _args = new InternalUnsafeMethods.StopTrackingTarget__Args() {
             };
             InternalUnsafeMethods.StopTrackingTarget()(ObjectPtr, _args);
        }

        public void StartTrackingTarget() {
             InternalUnsafeMethods.StartTrackingTarget__Args _args = new InternalUnsafeMethods.StartTrackingTarget__Args() {
             };
             InternalUnsafeMethods.StartTrackingTarget()(ObjectPtr, _args);
        }

        public void StopScanForTargets() {
             InternalUnsafeMethods.StopScanForTargets__Args _args = new InternalUnsafeMethods.StopScanForTargets__Args() {
             };
             InternalUnsafeMethods.StopScanForTargets()(ObjectPtr, _args);
        }

        public void StartScanForTargets() {
             InternalUnsafeMethods.StartScanForTargets__Args _args = new InternalUnsafeMethods.StartScanForTargets__Args() {
             };
             InternalUnsafeMethods.StartScanForTargets()(ObjectPtr, _args);
        }

        public void DeactivateTurret() {
             InternalUnsafeMethods.DeactivateTurret__Args _args = new InternalUnsafeMethods.DeactivateTurret__Args() {
             };
             InternalUnsafeMethods.DeactivateTurret()(ObjectPtr, _args);
        }

        public void ActivateTurret() {
             InternalUnsafeMethods.ActivateTurret__Args _args = new InternalUnsafeMethods.ActivateTurret__Args() {
             };
             InternalUnsafeMethods.ActivateTurret()(ObjectPtr, _args);
        }

        public void SetTurretState(string newState, bool force = false) {
             InternalUnsafeMethods.SetTurretState__Args _args = new InternalUnsafeMethods.SetTurretState__Args() {
                newState = newState,
                force = force,
             };
             InternalUnsafeMethods.SetTurretState()(ObjectPtr, _args);
        }

        public SimObject GetIgnoreListObject(int index) {
             InternalUnsafeMethods.GetIgnoreListObject__Args _args = new InternalUnsafeMethods.GetIgnoreListObject__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetIgnoreListObject()(ObjectPtr, _args);
             return new SimObject(_engineResult);
        }

        public int IgnoreListCount() {
             InternalUnsafeMethods.IgnoreListCount__Args _args = new InternalUnsafeMethods.IgnoreListCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.IgnoreListCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public void ClearIgnoreList() {
             InternalUnsafeMethods.ClearIgnoreList__Args _args = new InternalUnsafeMethods.ClearIgnoreList__Args() {
             };
             InternalUnsafeMethods.ClearIgnoreList()(ObjectPtr, _args);
        }

        public void RemoveFromIgnoreList(ShapeBase obj) {
             InternalUnsafeMethods.RemoveFromIgnoreList__Args _args = new InternalUnsafeMethods.RemoveFromIgnoreList__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.RemoveFromIgnoreList()(ObjectPtr, _args);
        }

        public void AddToIgnoreList(ShapeBase obj) {
             InternalUnsafeMethods.AddToIgnoreList__Args _args = new InternalUnsafeMethods.AddToIgnoreList__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.AddToIgnoreList()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}