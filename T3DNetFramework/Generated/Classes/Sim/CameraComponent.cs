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
    public unsafe class CameraComponent : Component {
        public CameraComponent(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public CameraComponent(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public CameraComponent(string pName) 
            : this(pName, false) {
        }
        
        public CameraComponent(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public CameraComponent(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public CameraComponent(SimObject pObj) 
            : base(pObj) {
        }
        
        public CameraComponent(IntPtr pObj) 
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
                                "fnCameraComponent_staticGetType"), typeof(_StaticGetType));
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
                                "fnCameraComponent_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ValidateCameraFov__Args
            {
                internal float fov;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _ValidateCameraFov(IntPtr _this, ValidateCameraFov__Args args);
            private static _ValidateCameraFov _ValidateCameraFovFunc;
            internal static _ValidateCameraFov ValidateCameraFov() {
                if (_ValidateCameraFovFunc == null) {
                    _ValidateCameraFovFunc =
                        (_ValidateCameraFov)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbCameraComponent_validateCameraFov"), typeof(_ValidateCameraFov));
                }
                
                return _ValidateCameraFovFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetWorldPosition__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetWorldPosition(IntPtr _this, GetWorldPosition__Args args);
            private static _GetWorldPosition _GetWorldPositionFunc;
            internal static _GetWorldPosition GetWorldPosition() {
                if (_GetWorldPositionFunc == null) {
                    _GetWorldPositionFunc =
                        (_GetWorldPosition)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCameraComponent_getWorldPosition"), typeof(_GetWorldPosition));
                }
                
                return _GetWorldPositionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetForwardVector__Args
            {
                internal IntPtr newForward;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetForwardVector(IntPtr _this, SetForwardVector__Args args);
            private static _SetForwardVector _SetForwardVectorFunc;
            internal static _SetForwardVector SetForwardVector() {
                if (_SetForwardVectorFunc == null) {
                    _SetForwardVectorFunc =
                        (_SetForwardVector)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCameraComponent_setForwardVector"), typeof(_SetForwardVector));
                }
                
                return _SetForwardVectorFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetUpVector__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetUpVector(IntPtr _this, GetUpVector__Args args);
            private static _GetUpVector _GetUpVectorFunc;
            internal static _GetUpVector GetUpVector() {
                if (_GetUpVectorFunc == null) {
                    _GetUpVectorFunc =
                        (_GetUpVector)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCameraComponent_getUpVector"), typeof(_GetUpVector));
                }
                
                return _GetUpVectorFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRightVector__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetRightVector(IntPtr _this, GetRightVector__Args args);
            private static _GetRightVector _GetRightVectorFunc;
            internal static _GetRightVector GetRightVector() {
                if (_GetRightVectorFunc == null) {
                    _GetRightVectorFunc =
                        (_GetRightVector)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCameraComponent_getRightVector"), typeof(_GetRightVector));
                }
                
                return _GetRightVectorFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetForwardVector__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetForwardVector(IntPtr _this, GetForwardVector__Args args);
            private static _GetForwardVector _GetForwardVectorFunc;
            internal static _GetForwardVector GetForwardVector() {
                if (_GetForwardVectorFunc == null) {
                    _GetForwardVectorFunc =
                        (_GetForwardVector)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCameraComponent_getForwardVector"), typeof(_GetForwardVector));
                }
                
                return _GetForwardVectorFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMode__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMode(IntPtr _this, GetMode__Args args);
            private static _GetMode _GetModeFunc;
            internal static _GetMode GetMode() {
                if (_GetModeFunc == null) {
                    _GetModeFunc =
                        (_GetMode)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCameraComponent_getMode"), typeof(_GetMode));
                }
                
                return _GetModeFunc;
            }
        }
        #endregion

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public float ValidateCameraFov(float fov) {
             InternalUnsafeMethods.ValidateCameraFov__Args _args = new InternalUnsafeMethods.ValidateCameraFov__Args() {
                fov = fov,
             };
             float _engineResult = InternalUnsafeMethods.ValidateCameraFov()(ObjectPtr, _args);
             return _engineResult;
        }

        public Point3F GetWorldPosition() {
             InternalUnsafeMethods.GetWorldPosition__Args _args = new InternalUnsafeMethods.GetWorldPosition__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetWorldPosition()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        public void SetForwardVector(Point3F newForward = null) {
newForward = newForward ?? new Point3F("0 0 0");
newForward.Alloc();             InternalUnsafeMethods.SetForwardVector__Args _args = new InternalUnsafeMethods.SetForwardVector__Args() {
                newForward = newForward.internalStructPtr,
             };
             InternalUnsafeMethods.SetForwardVector()(ObjectPtr, _args);
newForward.Free();        }

        public Point3F GetUpVector() {
             InternalUnsafeMethods.GetUpVector__Args _args = new InternalUnsafeMethods.GetUpVector__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetUpVector()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        public Point3F GetRightVector() {
             InternalUnsafeMethods.GetRightVector__Args _args = new InternalUnsafeMethods.GetRightVector__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetRightVector()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        public Point3F GetForwardVector() {
             InternalUnsafeMethods.GetForwardVector__Args _args = new InternalUnsafeMethods.GetForwardVector__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetForwardVector()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        public string GetMode() {
             InternalUnsafeMethods.GetMode__Args _args = new InternalUnsafeMethods.GetMode__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMode()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public float FOV {
            get => GenericMarshal.StringTo<float>(GetFieldValue("FOV"));
            set => SetFieldValue("FOV", GenericMarshal.ToString(value));
        }

        public float MinFOV {
            get => GenericMarshal.StringTo<float>(GetFieldValue("MinFOV"));
            set => SetFieldValue("MinFOV", GenericMarshal.ToString(value));
        }

        public float MaxFOV {
            get => GenericMarshal.StringTo<float>(GetFieldValue("MaxFOV"));
            set => SetFieldValue("MaxFOV", GenericMarshal.ToString(value));
        }

        public Point2I ScreenAspect {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("ScreenAspect"));
            set => SetFieldValue("ScreenAspect", GenericMarshal.ToString(value));
        }

        public string TargetNode {
            get => GenericMarshal.StringTo<string>(GetFieldValue("targetNode"));
            set => SetFieldValue("targetNode", GenericMarshal.ToString(value));
        }

        public Point3F PositionOffset {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("positionOffset"));
            set => SetFieldValue("positionOffset", GenericMarshal.ToString(value));
        }

        public RotationF RotationOffset {
            get => GenericMarshal.StringTo<RotationF>(GetFieldValue("rotationOffset"));
            set => SetFieldValue("rotationOffset", GenericMarshal.ToString(value));
        }

        public bool UseParentTransform {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useParentTransform"));
            set => SetFieldValue("useParentTransform", GenericMarshal.ToString(value));
        }
    }
}