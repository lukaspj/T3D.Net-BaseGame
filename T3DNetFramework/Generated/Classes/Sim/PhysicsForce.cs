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
    public unsafe class PhysicsForce : SceneObject {
        public PhysicsForce(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public PhysicsForce(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public PhysicsForce(string pName) 
            : this(pName, false) {
        }
        
        public PhysicsForce(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public PhysicsForce(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public PhysicsForce(SimObject pObj) 
            : base(pObj) {
        }
        
        public PhysicsForce(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct IsAttached__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsAttached(IntPtr _this, IsAttached__Args args);
            private static _IsAttached _IsAttachedFunc;
            internal static _IsAttached IsAttached() {
                if (_IsAttachedFunc == null) {
                    _IsAttachedFunc =
                        (_IsAttached)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPhysicsForce_isAttached"), typeof(_IsAttached));
                }
                
                return _IsAttachedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Detach__Args
            {
                internal IntPtr force;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Detach(IntPtr _this, Detach__Args args);
            private static _Detach _DetachFunc;
            internal static _Detach Detach() {
                if (_DetachFunc == null) {
                    _DetachFunc =
                        (_Detach)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPhysicsForce_detach"), typeof(_Detach));
                }
                
                return _DetachFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Attach__Args
            {
                internal IntPtr start;
                internal IntPtr direction;
                internal float maxDist;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Attach(IntPtr _this, Attach__Args args);
            private static _Attach _AttachFunc;
            internal static _Attach Attach() {
                if (_AttachFunc == null) {
                    _AttachFunc =
                        (_Attach)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPhysicsForce_attach"), typeof(_Attach));
                }
                
                return _AttachFunc;
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
                                "fnPhysicsForce_staticGetType"), typeof(_StaticGetType));
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
                                "fnPhysicsForce_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public bool IsAttached() {
             InternalUnsafeMethods.IsAttached__Args _args = new InternalUnsafeMethods.IsAttached__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsAttached()(ObjectPtr, _args);
             return _engineResult;
        }

        public void Detach(Point3F force = null) {
force = force ?? new Point3F("0 0 0");
force.Alloc();             InternalUnsafeMethods.Detach__Args _args = new InternalUnsafeMethods.Detach__Args() {
                force = force.internalStructPtr,
             };
             InternalUnsafeMethods.Detach()(ObjectPtr, _args);
force.Free();        }

        public void Attach(Point3F start, Point3F direction, float maxDist) {
start.Alloc();direction.Alloc();             InternalUnsafeMethods.Attach__Args _args = new InternalUnsafeMethods.Attach__Args() {
                start = start.internalStructPtr,
                direction = direction.internalStructPtr,
                maxDist = maxDist,
             };
             InternalUnsafeMethods.Attach()(ObjectPtr, _args);
start.Free();direction.Free();        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}