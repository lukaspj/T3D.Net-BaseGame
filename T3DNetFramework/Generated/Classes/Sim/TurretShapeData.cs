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
    public unsafe class TurretShapeData : ItemData {
        public TurretShapeData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public TurretShapeData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public TurretShapeData(string pName) 
            : this(pName, false) {
        }
        
        public TurretShapeData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public TurretShapeData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public TurretShapeData(SimObject pObj) 
            : base(pObj) {
        }
        
        public TurretShapeData(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnStickyCollision__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnStickyCollision(IntPtr _this, OnStickyCollision__Args args);
            private static _OnStickyCollision _OnStickyCollisionFunc;
            internal static _OnStickyCollision OnStickyCollision() {
                if (_OnStickyCollisionFunc == null) {
                    _OnStickyCollisionFunc =
                        (_OnStickyCollision)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbTurretShapeData_onStickyCollision"), typeof(_OnStickyCollision));
                }
                
                return _OnStickyCollisionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnUnmountObject__Args
            {
                internal IntPtr turret;
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnUnmountObject(IntPtr _this, OnUnmountObject__Args args);
            private static _OnUnmountObject _OnUnmountObjectFunc;
            internal static _OnUnmountObject OnUnmountObject() {
                if (_OnUnmountObjectFunc == null) {
                    _OnUnmountObjectFunc =
                        (_OnUnmountObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbTurretShapeData_onUnmountObject"), typeof(_OnUnmountObject));
                }
                
                return _OnUnmountObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMountObject__Args
            {
                internal IntPtr turret;
                internal IntPtr obj;
                internal int node;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMountObject(IntPtr _this, OnMountObject__Args args);
            private static _OnMountObject _OnMountObjectFunc;
            internal static _OnMountObject OnMountObject() {
                if (_OnMountObjectFunc == null) {
                    _OnMountObjectFunc =
                        (_OnMountObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbTurretShapeData_onMountObject"), typeof(_OnMountObject));
                }
                
                return _OnMountObjectFunc;
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
                                "fnTurretShapeData_staticGetType"), typeof(_StaticGetType));
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
                                "fnTurretShapeData_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public virtual void OnStickyCollision(TurretShape obj) {
             InternalUnsafeMethods.OnStickyCollision__Args _args = new InternalUnsafeMethods.OnStickyCollision__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnStickyCollision()(ObjectPtr, _args);
        }

        public virtual void OnUnmountObject(SceneObject turret, SceneObject obj) {
             InternalUnsafeMethods.OnUnmountObject__Args _args = new InternalUnsafeMethods.OnUnmountObject__Args() {
                turret = turret.ObjectPtr,
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnUnmountObject()(ObjectPtr, _args);
        }

        public virtual void OnMountObject(SceneObject turret, SceneObject obj, int node) {
             InternalUnsafeMethods.OnMountObject__Args _args = new InternalUnsafeMethods.OnMountObject__Args() {
                turret = turret.ObjectPtr,
                obj = obj.ObjectPtr,
                node = node,
             };
             InternalUnsafeMethods.OnMountObject()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public bool ZRotOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("zRotOnly"));
            set => SetFieldValue("zRotOnly", GenericMarshal.ToString(value));
        }

        public TurretShapeFireLinkType WeaponLinkType {
            get => GenericMarshal.StringTo<TurretShapeFireLinkType>(GetFieldValue("weaponLinkType"));
            set => SetFieldValue("weaponLinkType", GenericMarshal.ToString(value));
        }

        public bool StartLoaded {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("startLoaded"));
            set => SetFieldValue("startLoaded", GenericMarshal.ToString(value));
        }

        public float CameraOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraOffset"));
            set => SetFieldValue("cameraOffset", GenericMarshal.ToString(value));
        }

        public float MaxHeading {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxHeading"));
            set => SetFieldValue("maxHeading", GenericMarshal.ToString(value));
        }

        public float MinPitch {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minPitch"));
            set => SetFieldValue("minPitch", GenericMarshal.ToString(value));
        }

        public float MaxPitch {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxPitch"));
            set => SetFieldValue("maxPitch", GenericMarshal.ToString(value));
        }

        public float HeadingRate {
            get => GenericMarshal.StringTo<float>(GetFieldValue("headingRate"));
            set => SetFieldValue("headingRate", GenericMarshal.ToString(value));
        }

        public float PitchRate {
            get => GenericMarshal.StringTo<float>(GetFieldValue("pitchRate"));
            set => SetFieldValue("pitchRate", GenericMarshal.ToString(value));
        }
    }
}