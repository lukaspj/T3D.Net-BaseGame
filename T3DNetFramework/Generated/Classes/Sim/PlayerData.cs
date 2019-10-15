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
    public unsafe class PlayerData : ShapeBaseData {
        public PlayerData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public PlayerData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public PlayerData(string pName) 
            : this(pName, false) {
        }
        
        public PlayerData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public PlayerData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public PlayerData(SimObject pObj) 
            : base(pObj) {
        }
        
        public PlayerData(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnLeaveMissionArea__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnLeaveMissionArea(IntPtr _this, OnLeaveMissionArea__Args args);
            private static _OnLeaveMissionArea _OnLeaveMissionAreaFunc;
            internal static _OnLeaveMissionArea OnLeaveMissionArea() {
                if (_OnLeaveMissionAreaFunc == null) {
                    _OnLeaveMissionAreaFunc =
                        (_OnLeaveMissionArea)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPlayerData_onLeaveMissionArea"), typeof(_OnLeaveMissionArea));
                }
                
                return _OnLeaveMissionAreaFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnEnterMissionArea__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnEnterMissionArea(IntPtr _this, OnEnterMissionArea__Args args);
            private static _OnEnterMissionArea _OnEnterMissionAreaFunc;
            internal static _OnEnterMissionArea OnEnterMissionArea() {
                if (_OnEnterMissionAreaFunc == null) {
                    _OnEnterMissionAreaFunc =
                        (_OnEnterMissionArea)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPlayerData_onEnterMissionArea"), typeof(_OnEnterMissionArea));
                }
                
                return _OnEnterMissionAreaFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AnimationDone__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AnimationDone(IntPtr _this, AnimationDone__Args args);
            private static _AnimationDone _AnimationDoneFunc;
            internal static _AnimationDone AnimationDone() {
                if (_AnimationDoneFunc == null) {
                    _AnimationDoneFunc =
                        (_AnimationDone)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPlayerData_animationDone"), typeof(_AnimationDone));
                }
                
                return _AnimationDoneFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnLeaveLiquid__Args
            {
                internal IntPtr obj;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnLeaveLiquid(IntPtr _this, OnLeaveLiquid__Args args);
            private static _OnLeaveLiquid _OnLeaveLiquidFunc;
            internal static _OnLeaveLiquid OnLeaveLiquid() {
                if (_OnLeaveLiquidFunc == null) {
                    _OnLeaveLiquidFunc =
                        (_OnLeaveLiquid)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPlayerData_onLeaveLiquid"), typeof(_OnLeaveLiquid));
                }
                
                return _OnLeaveLiquidFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnEnterLiquid__Args
            {
                internal IntPtr obj;
                internal float coverage;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnEnterLiquid(IntPtr _this, OnEnterLiquid__Args args);
            private static _OnEnterLiquid _OnEnterLiquidFunc;
            internal static _OnEnterLiquid OnEnterLiquid() {
                if (_OnEnterLiquidFunc == null) {
                    _OnEnterLiquidFunc =
                        (_OnEnterLiquid)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPlayerData_onEnterLiquid"), typeof(_OnEnterLiquid));
                }
                
                return _OnEnterLiquidFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct DoDismount__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DoDismount(IntPtr _this, DoDismount__Args args);
            private static _DoDismount _DoDismountFunc;
            internal static _DoDismount DoDismount() {
                if (_DoDismountFunc == null) {
                    _DoDismountFunc =
                        (_DoDismount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPlayerData_doDismount"), typeof(_DoDismount));
                }
                
                return _DoDismountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnStopSprintMotion__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnStopSprintMotion(IntPtr _this, OnStopSprintMotion__Args args);
            private static _OnStopSprintMotion _OnStopSprintMotionFunc;
            internal static _OnStopSprintMotion OnStopSprintMotion() {
                if (_OnStopSprintMotionFunc == null) {
                    _OnStopSprintMotionFunc =
                        (_OnStopSprintMotion)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPlayerData_onStopSprintMotion"), typeof(_OnStopSprintMotion));
                }
                
                return _OnStopSprintMotionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnStartSprintMotion__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnStartSprintMotion(IntPtr _this, OnStartSprintMotion__Args args);
            private static _OnStartSprintMotion _OnStartSprintMotionFunc;
            internal static _OnStartSprintMotion OnStartSprintMotion() {
                if (_OnStartSprintMotionFunc == null) {
                    _OnStartSprintMotionFunc =
                        (_OnStartSprintMotion)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPlayerData_onStartSprintMotion"), typeof(_OnStartSprintMotion));
                }
                
                return _OnStartSprintMotionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnStopSwim__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnStopSwim(IntPtr _this, OnStopSwim__Args args);
            private static _OnStopSwim _OnStopSwimFunc;
            internal static _OnStopSwim OnStopSwim() {
                if (_OnStopSwimFunc == null) {
                    _OnStopSwimFunc =
                        (_OnStopSwim)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPlayerData_onStopSwim"), typeof(_OnStopSwim));
                }
                
                return _OnStopSwimFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnStartSwim__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnStartSwim(IntPtr _this, OnStartSwim__Args args);
            private static _OnStartSwim _OnStartSwimFunc;
            internal static _OnStartSwim OnStartSwim() {
                if (_OnStartSwimFunc == null) {
                    _OnStartSwimFunc =
                        (_OnStartSwim)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPlayerData_onStartSwim"), typeof(_OnStartSwim));
                }
                
                return _OnStartSwimFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnPoseChange__Args
            {
                internal IntPtr obj;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string oldPose;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newPose;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnPoseChange(IntPtr _this, OnPoseChange__Args args);
            private static _OnPoseChange _OnPoseChangeFunc;
            internal static _OnPoseChange OnPoseChange() {
                if (_OnPoseChangeFunc == null) {
                    _OnPoseChangeFunc =
                        (_OnPoseChange)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPlayerData_onPoseChange"), typeof(_OnPoseChange));
                }
                
                return _OnPoseChangeFunc;
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
                                "fnPlayerData_staticGetType"), typeof(_StaticGetType));
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
                                "fnPlayerData_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public virtual void OnLeaveMissionArea(Player obj) {
             InternalUnsafeMethods.OnLeaveMissionArea__Args _args = new InternalUnsafeMethods.OnLeaveMissionArea__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnLeaveMissionArea()(ObjectPtr, _args);
        }

        public virtual void OnEnterMissionArea(Player obj) {
             InternalUnsafeMethods.OnEnterMissionArea__Args _args = new InternalUnsafeMethods.OnEnterMissionArea__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnEnterMissionArea()(ObjectPtr, _args);
        }

        public virtual void AnimationDone(Player obj) {
             InternalUnsafeMethods.AnimationDone__Args _args = new InternalUnsafeMethods.AnimationDone__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.AnimationDone()(ObjectPtr, _args);
        }

        public virtual void OnLeaveLiquid(Player obj, string type) {
             InternalUnsafeMethods.OnLeaveLiquid__Args _args = new InternalUnsafeMethods.OnLeaveLiquid__Args() {
                obj = obj.ObjectPtr,
                type = type,
             };
             InternalUnsafeMethods.OnLeaveLiquid()(ObjectPtr, _args);
        }

        public virtual void OnEnterLiquid(Player obj, float coverage, string type) {
             InternalUnsafeMethods.OnEnterLiquid__Args _args = new InternalUnsafeMethods.OnEnterLiquid__Args() {
                obj = obj.ObjectPtr,
                coverage = coverage,
                type = type,
             };
             InternalUnsafeMethods.OnEnterLiquid()(ObjectPtr, _args);
        }

        public virtual void DoDismount(Player obj) {
             InternalUnsafeMethods.DoDismount__Args _args = new InternalUnsafeMethods.DoDismount__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.DoDismount()(ObjectPtr, _args);
        }

        public virtual void OnStopSprintMotion(Player obj) {
             InternalUnsafeMethods.OnStopSprintMotion__Args _args = new InternalUnsafeMethods.OnStopSprintMotion__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnStopSprintMotion()(ObjectPtr, _args);
        }

        public virtual void OnStartSprintMotion(Player obj) {
             InternalUnsafeMethods.OnStartSprintMotion__Args _args = new InternalUnsafeMethods.OnStartSprintMotion__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnStartSprintMotion()(ObjectPtr, _args);
        }

        public virtual void OnStopSwim(Player obj) {
             InternalUnsafeMethods.OnStopSwim__Args _args = new InternalUnsafeMethods.OnStopSwim__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnStopSwim()(ObjectPtr, _args);
        }

        public virtual void OnStartSwim(Player obj) {
             InternalUnsafeMethods.OnStartSwim__Args _args = new InternalUnsafeMethods.OnStartSwim__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnStartSwim()(ObjectPtr, _args);
        }

        public virtual void OnPoseChange(Player obj, string oldPose, string newPose) {
             InternalUnsafeMethods.OnPoseChange__Args _args = new InternalUnsafeMethods.OnPoseChange__Args() {
                obj = obj.ObjectPtr,
                oldPose = oldPose,
                newPose = newPose,
             };
             InternalUnsafeMethods.OnPoseChange()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public float PickupRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("pickupRadius"));
            set => SetFieldValue("pickupRadius", GenericMarshal.ToString(value));
        }

        public float MaxTimeScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxTimeScale"));
            set => SetFieldValue("maxTimeScale", GenericMarshal.ToString(value));
        }

        public bool RenderFirstPerson {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderFirstPerson"));
            set => SetFieldValue("renderFirstPerson", GenericMarshal.ToString(value));
        }

        public bool FirstPersonShadows {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("firstPersonShadows"));
            set => SetFieldValue("firstPersonShadows", GenericMarshal.ToString(value));
        }

        public float MinLookAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minLookAngle"));
            set => SetFieldValue("minLookAngle", GenericMarshal.ToString(value));
        }

        public float MaxLookAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxLookAngle"));
            set => SetFieldValue("maxLookAngle", GenericMarshal.ToString(value));
        }

        public float MaxFreelookAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxFreelookAngle"));
            set => SetFieldValue("maxFreelookAngle", GenericMarshal.ToString(value));
        }

        public float MaxStepHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxStepHeight"));
            set => SetFieldValue("maxStepHeight", GenericMarshal.ToString(value));
        }

        public float RunForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("runForce"));
            set => SetFieldValue("runForce", GenericMarshal.ToString(value));
        }

        public float RunEnergyDrain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("runEnergyDrain"));
            set => SetFieldValue("runEnergyDrain", GenericMarshal.ToString(value));
        }

        public float MinRunEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minRunEnergy"));
            set => SetFieldValue("minRunEnergy", GenericMarshal.ToString(value));
        }

        public float MaxForwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxForwardSpeed"));
            set => SetFieldValue("maxForwardSpeed", GenericMarshal.ToString(value));
        }

        public float MaxBackwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxBackwardSpeed"));
            set => SetFieldValue("maxBackwardSpeed", GenericMarshal.ToString(value));
        }

        public float MaxSideSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSideSpeed"));
            set => SetFieldValue("maxSideSpeed", GenericMarshal.ToString(value));
        }

        public float RunSurfaceAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("runSurfaceAngle"));
            set => SetFieldValue("runSurfaceAngle", GenericMarshal.ToString(value));
        }

        public float MinImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minImpactSpeed"));
            set => SetFieldValue("minImpactSpeed", GenericMarshal.ToString(value));
        }

        public float MinLateralImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minLateralImpactSpeed"));
            set => SetFieldValue("minLateralImpactSpeed", GenericMarshal.ToString(value));
        }

        public float HorizMaxSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("horizMaxSpeed"));
            set => SetFieldValue("horizMaxSpeed", GenericMarshal.ToString(value));
        }

        public float HorizResistSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("horizResistSpeed"));
            set => SetFieldValue("horizResistSpeed", GenericMarshal.ToString(value));
        }

        public float HorizResistFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("horizResistFactor"));
            set => SetFieldValue("horizResistFactor", GenericMarshal.ToString(value));
        }

        public float UpMaxSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("upMaxSpeed"));
            set => SetFieldValue("upMaxSpeed", GenericMarshal.ToString(value));
        }

        public float UpResistSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("upResistSpeed"));
            set => SetFieldValue("upResistSpeed", GenericMarshal.ToString(value));
        }

        public float UpResistFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("upResistFactor"));
            set => SetFieldValue("upResistFactor", GenericMarshal.ToString(value));
        }

        public float JumpForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jumpForce"));
            set => SetFieldValue("jumpForce", GenericMarshal.ToString(value));
        }

        public float JumpEnergyDrain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jumpEnergyDrain"));
            set => SetFieldValue("jumpEnergyDrain", GenericMarshal.ToString(value));
        }

        public float MinJumpEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minJumpEnergy"));
            set => SetFieldValue("minJumpEnergy", GenericMarshal.ToString(value));
        }

        public float MinJumpSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minJumpSpeed"));
            set => SetFieldValue("minJumpSpeed", GenericMarshal.ToString(value));
        }

        public float MaxJumpSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxJumpSpeed"));
            set => SetFieldValue("maxJumpSpeed", GenericMarshal.ToString(value));
        }

        public float JumpSurfaceAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jumpSurfaceAngle"));
            set => SetFieldValue("jumpSurfaceAngle", GenericMarshal.ToString(value));
        }

        public int JumpDelay {
            get => GenericMarshal.StringTo<int>(GetFieldValue("jumpDelay"));
            set => SetFieldValue("jumpDelay", GenericMarshal.ToString(value));
        }

        public float AirControl {
            get => GenericMarshal.StringTo<float>(GetFieldValue("airControl"));
            set => SetFieldValue("airControl", GenericMarshal.ToString(value));
        }

        public bool JumpTowardsNormal {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("jumpTowardsNormal"));
            set => SetFieldValue("jumpTowardsNormal", GenericMarshal.ToString(value));
        }

        public float SprintForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sprintForce"));
            set => SetFieldValue("sprintForce", GenericMarshal.ToString(value));
        }

        public float SprintEnergyDrain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sprintEnergyDrain"));
            set => SetFieldValue("sprintEnergyDrain", GenericMarshal.ToString(value));
        }

        public float MinSprintEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minSprintEnergy"));
            set => SetFieldValue("minSprintEnergy", GenericMarshal.ToString(value));
        }

        public float MaxSprintForwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSprintForwardSpeed"));
            set => SetFieldValue("maxSprintForwardSpeed", GenericMarshal.ToString(value));
        }

        public float MaxSprintBackwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSprintBackwardSpeed"));
            set => SetFieldValue("maxSprintBackwardSpeed", GenericMarshal.ToString(value));
        }

        public float MaxSprintSideSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSprintSideSpeed"));
            set => SetFieldValue("maxSprintSideSpeed", GenericMarshal.ToString(value));
        }

        public float SprintStrafeScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sprintStrafeScale"));
            set => SetFieldValue("sprintStrafeScale", GenericMarshal.ToString(value));
        }

        public float SprintYawScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sprintYawScale"));
            set => SetFieldValue("sprintYawScale", GenericMarshal.ToString(value));
        }

        public float SprintPitchScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sprintPitchScale"));
            set => SetFieldValue("sprintPitchScale", GenericMarshal.ToString(value));
        }

        public bool SprintCanJump {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("sprintCanJump"));
            set => SetFieldValue("sprintCanJump", GenericMarshal.ToString(value));
        }

        public float SwimForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("swimForce"));
            set => SetFieldValue("swimForce", GenericMarshal.ToString(value));
        }

        public float MaxUnderwaterForwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxUnderwaterForwardSpeed"));
            set => SetFieldValue("maxUnderwaterForwardSpeed", GenericMarshal.ToString(value));
        }

        public float MaxUnderwaterBackwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxUnderwaterBackwardSpeed"));
            set => SetFieldValue("maxUnderwaterBackwardSpeed", GenericMarshal.ToString(value));
        }

        public float MaxUnderwaterSideSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxUnderwaterSideSpeed"));
            set => SetFieldValue("maxUnderwaterSideSpeed", GenericMarshal.ToString(value));
        }

        public float CrouchForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("crouchForce"));
            set => SetFieldValue("crouchForce", GenericMarshal.ToString(value));
        }

        public float MaxCrouchForwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxCrouchForwardSpeed"));
            set => SetFieldValue("maxCrouchForwardSpeed", GenericMarshal.ToString(value));
        }

        public float MaxCrouchBackwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxCrouchBackwardSpeed"));
            set => SetFieldValue("maxCrouchBackwardSpeed", GenericMarshal.ToString(value));
        }

        public float MaxCrouchSideSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxCrouchSideSpeed"));
            set => SetFieldValue("maxCrouchSideSpeed", GenericMarshal.ToString(value));
        }

        public float ProneForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("proneForce"));
            set => SetFieldValue("proneForce", GenericMarshal.ToString(value));
        }

        public float MaxProneForwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxProneForwardSpeed"));
            set => SetFieldValue("maxProneForwardSpeed", GenericMarshal.ToString(value));
        }

        public float MaxProneBackwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxProneBackwardSpeed"));
            set => SetFieldValue("maxProneBackwardSpeed", GenericMarshal.ToString(value));
        }

        public float MaxProneSideSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxProneSideSpeed"));
            set => SetFieldValue("maxProneSideSpeed", GenericMarshal.ToString(value));
        }

        public float JetJumpForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetJumpForce"));
            set => SetFieldValue("jetJumpForce", GenericMarshal.ToString(value));
        }

        public float JetJumpEnergyDrain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetJumpEnergyDrain"));
            set => SetFieldValue("jetJumpEnergyDrain", GenericMarshal.ToString(value));
        }

        public float JetMinJumpEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetMinJumpEnergy"));
            set => SetFieldValue("jetMinJumpEnergy", GenericMarshal.ToString(value));
        }

        public float JetMinJumpSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetMinJumpSpeed"));
            set => SetFieldValue("jetMinJumpSpeed", GenericMarshal.ToString(value));
        }

        public float JetMaxJumpSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetMaxJumpSpeed"));
            set => SetFieldValue("jetMaxJumpSpeed", GenericMarshal.ToString(value));
        }

        public float JetJumpSurfaceAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetJumpSurfaceAngle"));
            set => SetFieldValue("jetJumpSurfaceAngle", GenericMarshal.ToString(value));
        }

        public float FallingSpeedThreshold {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fallingSpeedThreshold"));
            set => SetFieldValue("fallingSpeedThreshold", GenericMarshal.ToString(value));
        }

        public int RecoverDelay {
            get => GenericMarshal.StringTo<int>(GetFieldValue("recoverDelay"));
            set => SetFieldValue("recoverDelay", GenericMarshal.ToString(value));
        }

        public float RecoverRunForceScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("recoverRunForceScale"));
            set => SetFieldValue("recoverRunForceScale", GenericMarshal.ToString(value));
        }

        public float LandSequenceTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("landSequenceTime"));
            set => SetFieldValue("landSequenceTime", GenericMarshal.ToString(value));
        }

        public bool TransitionToLand {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("transitionToLand"));
            set => SetFieldValue("transitionToLand", GenericMarshal.ToString(value));
        }

        public Point3F BoundingBox {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("boundingBox"));
            set => SetFieldValue("boundingBox", GenericMarshal.ToString(value));
        }

        public Point3F CrouchBoundingBox {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("crouchBoundingBox"));
            set => SetFieldValue("crouchBoundingBox", GenericMarshal.ToString(value));
        }

        public Point3F ProneBoundingBox {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("proneBoundingBox"));
            set => SetFieldValue("proneBoundingBox", GenericMarshal.ToString(value));
        }

        public Point3F SwimBoundingBox {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("swimBoundingBox"));
            set => SetFieldValue("swimBoundingBox", GenericMarshal.ToString(value));
        }

        public float BoxHeadPercentage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxHeadPercentage"));
            set => SetFieldValue("boxHeadPercentage", GenericMarshal.ToString(value));
        }

        public float BoxTorsoPercentage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxTorsoPercentage"));
            set => SetFieldValue("boxTorsoPercentage", GenericMarshal.ToString(value));
        }

        public float BoxHeadLeftPercentage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxHeadLeftPercentage"));
            set => SetFieldValue("boxHeadLeftPercentage", GenericMarshal.ToString(value));
        }

        public float BoxHeadRightPercentage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxHeadRightPercentage"));
            set => SetFieldValue("boxHeadRightPercentage", GenericMarshal.ToString(value));
        }

        public float BoxHeadBackPercentage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxHeadBackPercentage"));
            set => SetFieldValue("boxHeadBackPercentage", GenericMarshal.ToString(value));
        }

        public float BoxHeadFrontPercentage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxHeadFrontPercentage"));
            set => SetFieldValue("boxHeadFrontPercentage", GenericMarshal.ToString(value));
        }

        public ParticleEmitterData FootPuffEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("footPuffEmitter"));
            set => SetFieldValue("footPuffEmitter", GenericMarshal.ToString(value));
        }

        public int FootPuffNumParts {
            get => GenericMarshal.StringTo<int>(GetFieldValue("footPuffNumParts"));
            set => SetFieldValue("footPuffNumParts", GenericMarshal.ToString(value));
        }

        public float FootPuffRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("footPuffRadius"));
            set => SetFieldValue("footPuffRadius", GenericMarshal.ToString(value));
        }

        public ParticleEmitterData DustEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("dustEmitter"));
            set => SetFieldValue("dustEmitter", GenericMarshal.ToString(value));
        }

        public DecalData DecalData {
            get => GenericMarshal.StringTo<DecalData>(GetFieldValue("DecalData"));
            set => SetFieldValue("DecalData", GenericMarshal.ToString(value));
        }

        public float DecalOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("decalOffset"));
            set => SetFieldValue("decalOffset", GenericMarshal.ToString(value));
        }

        public SFXTrack FootSoftSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("FootSoftSound"));
            set => SetFieldValue("FootSoftSound", GenericMarshal.ToString(value));
        }

        public SFXTrack FootHardSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("FootHardSound"));
            set => SetFieldValue("FootHardSound", GenericMarshal.ToString(value));
        }

        public SFXTrack FootMetalSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("FootMetalSound"));
            set => SetFieldValue("FootMetalSound", GenericMarshal.ToString(value));
        }

        public SFXTrack FootSnowSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("FootSnowSound"));
            set => SetFieldValue("FootSnowSound", GenericMarshal.ToString(value));
        }

        public SFXTrack FootShallowSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("FootShallowSound"));
            set => SetFieldValue("FootShallowSound", GenericMarshal.ToString(value));
        }

        public SFXTrack FootWadingSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("FootWadingSound"));
            set => SetFieldValue("FootWadingSound", GenericMarshal.ToString(value));
        }

        public SFXTrack FootUnderwaterSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("FootUnderwaterSound"));
            set => SetFieldValue("FootUnderwaterSound", GenericMarshal.ToString(value));
        }

        public SFXTrack FootBubblesSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("FootBubblesSound"));
            set => SetFieldValue("FootBubblesSound", GenericMarshal.ToString(value));
        }

        public SFXTrack MovingBubblesSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("movingBubblesSound"));
            set => SetFieldValue("movingBubblesSound", GenericMarshal.ToString(value));
        }

        public SFXTrack WaterBreathSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("waterBreathSound"));
            set => SetFieldValue("waterBreathSound", GenericMarshal.ToString(value));
        }

        public SFXTrack ImpactSoftSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("impactSoftSound"));
            set => SetFieldValue("impactSoftSound", GenericMarshal.ToString(value));
        }

        public SFXTrack ImpactHardSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("impactHardSound"));
            set => SetFieldValue("impactHardSound", GenericMarshal.ToString(value));
        }

        public SFXTrack ImpactMetalSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("impactMetalSound"));
            set => SetFieldValue("impactMetalSound", GenericMarshal.ToString(value));
        }

        public SFXTrack ImpactSnowSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("impactSnowSound"));
            set => SetFieldValue("impactSnowSound", GenericMarshal.ToString(value));
        }

        public SFXTrack ImpactWaterEasy {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("impactWaterEasy"));
            set => SetFieldValue("impactWaterEasy", GenericMarshal.ToString(value));
        }

        public SFXTrack ImpactWaterMedium {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("impactWaterMedium"));
            set => SetFieldValue("impactWaterMedium", GenericMarshal.ToString(value));
        }

        public SFXTrack ImpactWaterHard {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("impactWaterHard"));
            set => SetFieldValue("impactWaterHard", GenericMarshal.ToString(value));
        }

        public SFXTrack ExitingWater {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("exitingWater"));
            set => SetFieldValue("exitingWater", GenericMarshal.ToString(value));
        }

        public SplashData Splash {
            get => GenericMarshal.StringTo<SplashData>(GetFieldValue("Splash"));
            set => SetFieldValue("Splash", GenericMarshal.ToString(value));
        }

        public float SplashVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashVelocity"));
            set => SetFieldValue("splashVelocity", GenericMarshal.ToString(value));
        }

        public float SplashAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashAngle"));
            set => SetFieldValue("splashAngle", GenericMarshal.ToString(value));
        }

        public float SplashFreqMod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashFreqMod"));
            set => SetFieldValue("splashFreqMod", GenericMarshal.ToString(value));
        }

        public float SplashVelEpsilon {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashVelEpsilon"));
            set => SetFieldValue("splashVelEpsilon", GenericMarshal.ToString(value));
        }

        public float BubbleEmitTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("bubbleEmitTime"));
            set => SetFieldValue("bubbleEmitTime", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<ParticleEmitterData> SplashEmitter {
            get => new DynamicFieldVector<ParticleEmitterData>(
                    this, 
                    "splashEmitter", 
                    3, 
                    val => GenericMarshal.StringTo<ParticleEmitterData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public float FootstepSplashHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("footstepSplashHeight"));
            set => SetFieldValue("footstepSplashHeight", GenericMarshal.ToString(value));
        }

        public float MediumSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mediumSplashSoundVelocity"));
            set => SetFieldValue("mediumSplashSoundVelocity", GenericMarshal.ToString(value));
        }

        public float HardSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("hardSplashSoundVelocity"));
            set => SetFieldValue("hardSplashSoundVelocity", GenericMarshal.ToString(value));
        }

        public float ExitSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("exitSplashSoundVelocity"));
            set => SetFieldValue("exitSplashSoundVelocity", GenericMarshal.ToString(value));
        }

        public float GroundImpactMinSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("groundImpactMinSpeed"));
            set => SetFieldValue("groundImpactMinSpeed", GenericMarshal.ToString(value));
        }

        public Point3F GroundImpactShakeFreq {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("groundImpactShakeFreq"));
            set => SetFieldValue("groundImpactShakeFreq", GenericMarshal.ToString(value));
        }

        public Point3F GroundImpactShakeAmp {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("groundImpactShakeAmp"));
            set => SetFieldValue("groundImpactShakeAmp", GenericMarshal.ToString(value));
        }

        public float GroundImpactShakeDuration {
            get => GenericMarshal.StringTo<float>(GetFieldValue("groundImpactShakeDuration"));
            set => SetFieldValue("groundImpactShakeDuration", GenericMarshal.ToString(value));
        }

        public float GroundImpactShakeFalloff {
            get => GenericMarshal.StringTo<float>(GetFieldValue("groundImpactShakeFalloff"));
            set => SetFieldValue("groundImpactShakeFalloff", GenericMarshal.ToString(value));
        }

        public string PhysicsPlayerType {
            get => GenericMarshal.StringTo<string>(GetFieldValue("physicsPlayerType"));
            set => SetFieldValue("physicsPlayerType", GenericMarshal.ToString(value));
        }

        public string ImageAnimPrefixFP {
            get => GenericMarshal.StringTo<string>(GetFieldValue("imageAnimPrefixFP"));
            set => SetFieldValue("imageAnimPrefixFP", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<string> ShapeNameFP {
            get => new DynamicFieldVector<string>(
                    this, 
                    "shapeNameFP", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public string ImageAnimPrefix {
            get => GenericMarshal.StringTo<string>(GetFieldValue("imageAnimPrefix"));
            set => SetFieldValue("imageAnimPrefix", GenericMarshal.ToString(value));
        }

        public bool AllowImageStateAnimation {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowImageStateAnimation"));
            set => SetFieldValue("allowImageStateAnimation", GenericMarshal.ToString(value));
        }
    }
}