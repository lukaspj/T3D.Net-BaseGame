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
    public unsafe class PhysicalZone : SceneObject {
        public PhysicalZone(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public PhysicalZone(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public PhysicalZone(string pName) 
            : this(pName, false) {
        }
        
        public PhysicalZone(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public PhysicalZone(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public PhysicalZone(SimObject pObj) 
            : base(pObj) {
        }
        
        public PhysicalZone(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Deactivate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Deactivate(IntPtr _this, Deactivate__Args args);
            private static _Deactivate _DeactivateFunc;
            internal static _Deactivate Deactivate() {
                if (_DeactivateFunc == null) {
                    _DeactivateFunc =
                        (_Deactivate)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPhysicalZone_deactivate"), typeof(_Deactivate));
                }
                
                return _DeactivateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Activate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Activate(IntPtr _this, Activate__Args args);
            private static _Activate _ActivateFunc;
            internal static _Activate Activate() {
                if (_ActivateFunc == null) {
                    _ActivateFunc =
                        (_Activate)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPhysicalZone_activate"), typeof(_Activate));
                }
                
                return _ActivateFunc;
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
                                "fnPhysicalZone_staticGetType"), typeof(_StaticGetType));
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
                                "fnPhysicalZone_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void Deactivate() {
             InternalUnsafeMethods.Deactivate__Args _args = new InternalUnsafeMethods.Deactivate__Args() {
             };
             InternalUnsafeMethods.Deactivate()(ObjectPtr, _args);
        }

        public void Activate() {
             InternalUnsafeMethods.Activate__Args _args = new InternalUnsafeMethods.Activate__Args() {
             };
             InternalUnsafeMethods.Activate()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public float VelocityMod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("velocityMod"));
            set => SetFieldValue("velocityMod", GenericMarshal.ToString(value));
        }

        public float GravityMod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gravityMod"));
            set => SetFieldValue("gravityMod", GenericMarshal.ToString(value));
        }

        public Point3F AppliedForce {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("appliedForce"));
            set => SetFieldValue("appliedForce", GenericMarshal.ToString(value));
        }

        public FloatVector Polyhedron {
            get => GenericMarshal.StringTo<FloatVector>(GetFieldValue("polyhedron"));
            set => SetFieldValue("polyhedron", GenericMarshal.ToString(value));
        }

        public PhysicalZone_ForceType ForceType {
            get => GenericMarshal.StringTo<PhysicalZone_ForceType>(GetFieldValue("forceType"));
            set => SetFieldValue("forceType", GenericMarshal.ToString(value));
        }

        public bool OrientForce {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("orientForce"));
            set => SetFieldValue("orientForce", GenericMarshal.ToString(value));
        }
    }
}