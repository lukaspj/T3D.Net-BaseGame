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
    public unsafe class ShapeBaseImageData : GameBaseData {
        public ShapeBaseImageData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ShapeBaseImageData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ShapeBaseImageData(string pName) 
            : this(pName, false) {
        }
        
        public ShapeBaseImageData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ShapeBaseImageData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ShapeBaseImageData(SimObject pObj) 
            : base(pObj) {
        }
        
        public ShapeBaseImageData(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnUnmount__Args
            {
                internal IntPtr obj;
                internal int slot;
                internal float dt;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnUnmount(IntPtr _this, OnUnmount__Args args);
            private static _OnUnmount _OnUnmountFunc;
            internal static _OnUnmount OnUnmount() {
                if (_OnUnmountFunc == null) {
                    _OnUnmountFunc =
                        (_OnUnmount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbShapeBaseImageData_onUnmount"), typeof(_OnUnmount));
                }
                
                return _OnUnmountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMount__Args
            {
                internal IntPtr obj;
                internal int slot;
                internal float dt;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMount(IntPtr _this, OnMount__Args args);
            private static _OnMount _OnMountFunc;
            internal static _OnMount OnMount() {
                if (_OnMountFunc == null) {
                    _OnMountFunc =
                        (_OnMount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbShapeBaseImageData_onMount"), typeof(_OnMount));
                }
                
                return _OnMountFunc;
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
                                "fnShapeBaseImageData_staticGetType"), typeof(_StaticGetType));
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
                                "fnShapeBaseImageData_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public virtual void OnUnmount(SceneObject obj, int slot, float dt) {
             InternalUnsafeMethods.OnUnmount__Args _args = new InternalUnsafeMethods.OnUnmount__Args() {
                obj = obj.ObjectPtr,
                slot = slot,
                dt = dt,
             };
             InternalUnsafeMethods.OnUnmount()(ObjectPtr, _args);
        }

        public virtual void OnMount(SceneObject obj, int slot, float dt) {
             InternalUnsafeMethods.OnMount__Args _args = new InternalUnsafeMethods.OnMount__Args() {
                obj = obj.ObjectPtr,
                slot = slot,
                dt = dt,
             };
             InternalUnsafeMethods.OnMount()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public bool Emap {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("emap"));
            set => SetFieldValue("emap", GenericMarshal.ToString(value));
        }

        public string ShapeFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("shapeFile"));
            set => SetFieldValue("shapeFile", GenericMarshal.ToString(value));
        }

        public string ShapeFileFP {
            get => GenericMarshal.StringTo<string>(GetFieldValue("shapeFileFP"));
            set => SetFieldValue("shapeFileFP", GenericMarshal.ToString(value));
        }

        public string ImageAnimPrefix {
            get => GenericMarshal.StringTo<string>(GetFieldValue("imageAnimPrefix"));
            set => SetFieldValue("imageAnimPrefix", GenericMarshal.ToString(value));
        }

        public string ImageAnimPrefixFP {
            get => GenericMarshal.StringTo<string>(GetFieldValue("imageAnimPrefixFP"));
            set => SetFieldValue("imageAnimPrefixFP", GenericMarshal.ToString(value));
        }

        public bool AnimateAllShapes {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("animateAllShapes"));
            set => SetFieldValue("animateAllShapes", GenericMarshal.ToString(value));
        }

        public bool AnimateOnServer {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("animateOnServer"));
            set => SetFieldValue("animateOnServer", GenericMarshal.ToString(value));
        }

        public float ScriptAnimTransitionTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("scriptAnimTransitionTime"));
            set => SetFieldValue("scriptAnimTransitionTime", GenericMarshal.ToString(value));
        }

        public ProjectileData Projectile {
            get => GenericMarshal.StringTo<ProjectileData>(GetFieldValue("Projectile"));
            set => SetFieldValue("Projectile", GenericMarshal.ToString(value));
        }

        public bool Cloakable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("cloakable"));
            set => SetFieldValue("cloakable", GenericMarshal.ToString(value));
        }

        public int MountPoint {
            get => GenericMarshal.StringTo<int>(GetFieldValue("mountPoint"));
            set => SetFieldValue("mountPoint", GenericMarshal.ToString(value));
        }

        public MatrixF Offset {
            get => GenericMarshal.StringTo<MatrixF>(GetFieldValue("offset"));
            set => SetFieldValue("offset", GenericMarshal.ToString(value));
        }

        public MatrixF Rotation {
            get => GenericMarshal.StringTo<MatrixF>(GetFieldValue("rotation"));
            set => SetFieldValue("rotation", GenericMarshal.ToString(value));
        }

        public MatrixF EyeOffset {
            get => GenericMarshal.StringTo<MatrixF>(GetFieldValue("eyeOffset"));
            set => SetFieldValue("eyeOffset", GenericMarshal.ToString(value));
        }

        public MatrixF EyeRotation {
            get => GenericMarshal.StringTo<MatrixF>(GetFieldValue("eyeRotation"));
            set => SetFieldValue("eyeRotation", GenericMarshal.ToString(value));
        }

        public bool UseEyeNode {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useEyeNode"));
            set => SetFieldValue("useEyeNode", GenericMarshal.ToString(value));
        }

        public bool CorrectMuzzleVector {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("correctMuzzleVector"));
            set => SetFieldValue("correctMuzzleVector", GenericMarshal.ToString(value));
        }

        public bool CorrectMuzzleVectorTP {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("correctMuzzleVectorTP"));
            set => SetFieldValue("correctMuzzleVectorTP", GenericMarshal.ToString(value));
        }

        public bool FirstPerson {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("firstPerson"));
            set => SetFieldValue("firstPerson", GenericMarshal.ToString(value));
        }

        public float Mass {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mass"));
            set => SetFieldValue("mass", GenericMarshal.ToString(value));
        }

        public bool UsesEnergy {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("usesEnergy"));
            set => SetFieldValue("usesEnergy", GenericMarshal.ToString(value));
        }

        public float MinEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minEnergy"));
            set => SetFieldValue("minEnergy", GenericMarshal.ToString(value));
        }

        public bool AccuFire {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("accuFire"));
            set => SetFieldValue("accuFire", GenericMarshal.ToString(value));
        }

        public ShapeBaseImageLightType LightType {
            get => GenericMarshal.StringTo<ShapeBaseImageLightType>(GetFieldValue("lightType"));
            set => SetFieldValue("lightType", GenericMarshal.ToString(value));
        }

        public LinearColorF LightColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("lightColor"));
            set => SetFieldValue("lightColor", GenericMarshal.ToString(value));
        }

        public int LightDuration {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lightDuration"));
            set => SetFieldValue("lightDuration", GenericMarshal.ToString(value));
        }

        public float LightRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lightRadius"));
            set => SetFieldValue("lightRadius", GenericMarshal.ToString(value));
        }

        public float LightBrightness {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lightBrightness"));
            set => SetFieldValue("lightBrightness", GenericMarshal.ToString(value));
        }

        public bool ShakeCamera {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("shakeCamera"));
            set => SetFieldValue("shakeCamera", GenericMarshal.ToString(value));
        }

        public Point3F CamShakeFreq {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("camShakeFreq"));
            set => SetFieldValue("camShakeFreq", GenericMarshal.ToString(value));
        }

        public Point3F CamShakeAmp {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("camShakeAmp"));
            set => SetFieldValue("camShakeAmp", GenericMarshal.ToString(value));
        }

        public float CamShakeDuration {
            get => GenericMarshal.StringTo<float>(GetFieldValue("camShakeDuration"));
            set => SetFieldValue("camShakeDuration", GenericMarshal.ToString(value));
        }

        public float CamShakeRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("camShakeRadius"));
            set => SetFieldValue("camShakeRadius", GenericMarshal.ToString(value));
        }

        public float CamShakeFalloff {
            get => GenericMarshal.StringTo<float>(GetFieldValue("camShakeFalloff"));
            set => SetFieldValue("camShakeFalloff", GenericMarshal.ToString(value));
        }

        public DebrisData Casing {
            get => GenericMarshal.StringTo<DebrisData>(GetFieldValue("casing"));
            set => SetFieldValue("casing", GenericMarshal.ToString(value));
        }

        public Point3F ShellExitDir {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("shellExitDir"));
            set => SetFieldValue("shellExitDir", GenericMarshal.ToString(value));
        }

        public float ShellExitVariance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shellExitVariance"));
            set => SetFieldValue("shellExitVariance", GenericMarshal.ToString(value));
        }

        public float ShellVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shellVelocity"));
            set => SetFieldValue("shellVelocity", GenericMarshal.ToString(value));
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

        public DynamicFieldVector<string> StateTransitionOnLoaded {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnLoaded", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnNotLoaded {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnNotLoaded", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnAmmo {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnAmmo", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnNoAmmo {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnNoAmmo", 
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

        public DynamicFieldVector<string> StateTransitionOnWet {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnWet", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnNotWet {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnNotWet", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnMotion {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnMotion", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnNoMotion {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnNoMotion", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnTriggerUp {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnTriggerUp", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnTriggerDown {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnTriggerDown", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnAltTriggerUp {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnAltTriggerUp", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionOnAltTriggerDown {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionOnAltTriggerDown", 
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

        public DynamicFieldVector<string> StateTransitionGeneric0In {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionGeneric0In", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionGeneric0Out {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionGeneric0Out", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionGeneric1In {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionGeneric1In", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionGeneric1Out {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionGeneric1Out", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionGeneric2In {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionGeneric2In", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionGeneric2Out {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionGeneric2Out", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionGeneric3In {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionGeneric3In", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateTransitionGeneric3Out {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateTransitionGeneric3Out", 
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

        public DynamicFieldVector<bool> StateAlternateFire {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateAlternateFire", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateReload {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateReload", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateEjectShell {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateEjectShell", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> StateEnergyDrain {
            get => new DynamicFieldVector<float>(
                    this, 
                    "stateEnergyDrain", 
                    31, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateAllowImageChange {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateAllowImageChange", 
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

        public DynamicFieldVector<ShapeBaseImageLoadedState> StateLoadedFlag {
            get => new DynamicFieldVector<ShapeBaseImageLoadedState>(
                    this, 
                    "stateLoadedFlag", 
                    31, 
                    val => GenericMarshal.StringTo<ShapeBaseImageLoadedState>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<ShapeBaseImageSpinState> StateSpinThread {
            get => new DynamicFieldVector<ShapeBaseImageSpinState>(
                    this, 
                    "stateSpinThread", 
                    31, 
                    val => GenericMarshal.StringTo<ShapeBaseImageSpinState>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<ShapeBaseImageRecoilState> StateRecoil {
            get => new DynamicFieldVector<ShapeBaseImageRecoilState>(
                    this, 
                    "stateRecoil", 
                    31, 
                    val => GenericMarshal.StringTo<ShapeBaseImageRecoilState>(val),
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

        public DynamicFieldVector<bool> StateSequenceRandomFlash {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateSequenceRandomFlash", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
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

        public DynamicFieldVector<bool> StateScaleAnimationFP {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateScaleAnimationFP", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateSequenceTransitionIn {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateSequenceTransitionIn", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateSequenceTransitionOut {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateSequenceTransitionOut", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateSequenceNeverTransition {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateSequenceNeverTransition", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> StateSequenceTransitionTime {
            get => new DynamicFieldVector<float>(
                    this, 
                    "stateSequenceTransitionTime", 
                    31, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateShapeSequence {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateShapeSequence", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateScaleShapeSequence {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateScaleShapeSequence", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<SFXTrack> StateSound {
            get => new DynamicFieldVector<SFXTrack>(
                    this, 
                    "stateSound", 
                    31, 
                    val => GenericMarshal.StringTo<SFXTrack>(val),
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

        public DynamicFieldVector<ParticleEmitterData> StateEmitter {
            get => new DynamicFieldVector<ParticleEmitterData>(
                    this, 
                    "stateEmitter", 
                    31, 
                    val => GenericMarshal.StringTo<ParticleEmitterData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> StateEmitterTime {
            get => new DynamicFieldVector<float>(
                    this, 
                    "stateEmitterTime", 
                    31, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> StateEmitterNode {
            get => new DynamicFieldVector<string>(
                    this, 
                    "stateEmitterNode", 
                    31, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> StateIgnoreLoadedForReady {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "stateIgnoreLoadedForReady", 
                    31, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public bool ComputeCRC {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("computeCRC"));
            set => SetFieldValue("computeCRC", GenericMarshal.ToString(value));
        }

        public int MaxConcurrentSounds {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxConcurrentSounds"));
            set => SetFieldValue("maxConcurrentSounds", GenericMarshal.ToString(value));
        }

        public bool UseRemainderDT {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useRemainderDT"));
            set => SetFieldValue("useRemainderDT", GenericMarshal.ToString(value));
        }
    }
}